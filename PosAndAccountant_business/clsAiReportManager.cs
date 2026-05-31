using Newtonsoft.Json;
using PosAndAccountant_DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsAiReportManager
    {
        private static readonly string _apiKey = ConfigurationManager.AppSettings["GeminiApiKey"];

        // رابط الاتصال بموديل Gemini 2.0 Flash الرسمي
        // غير السطر هذا ليكون gemini-1.5-flash بدلاً من gemini-2.0-flash
        // التعديل الصحيح والمطابق لإصدار v1beta
        private static readonly string _uri = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash-latest:generateContent?key={_apiKey}";        /// <summary>
                                                                                                                                                                       /// الدالة الرئيسية والوحيدة التي ستراها طبقة الـ Presentation.
                                                                                                                                                                       /// تأخذ طلب المستخدم وتعود بجدول البيانات الجاهز بعد المرور بالـ AI والـ DAL.
                                                                                                                                                                       /// </summary>
        public static async Task<DataTable> GetReportDataTableFromAiAsync(string userPrompt, Action<string> onErrorOrForbidden)
        {
            // أ. استدعاء التابع الداخلي للاتصال بالـ AI وتوليد الـ SQL
            string sqlQuery = await GetSqlFieldsFromAiAsync(userPrompt);

            // ب. التحقق من حالات الرفض أو الأخطاء وتمريرها للواجهة عبر الـ Callback (Action)
            if (sqlQuery == "FORBIDDEN" || sqlQuery == "ERROR" || sqlQuery.StartsWith("ERROR:"))
            {
                onErrorOrForbidden?.Invoke(sqlQuery);
                return null;
            }

            try
            {
                // جـ. هنا البزنس يتكلم مع الداتا أكسس بكل احترافية برمجية
                // استدعينا الدالة اللي ثبتناها بالـ DAL في الخطوة الأولى والتي تعمل بالـ DataAdapter
                DataTable dtResult = clsReportData.GetDataTable(sqlQuery);
                return dtResult;
            }
            catch (Exception ex)
            {
                // إذا أرسل الـ AI جملة فيها اسم حقل خاطئ مثلاً، نمرر الخطأ للواجهة لتنبيه المستخدم
                onErrorOrForbidden?.Invoke("ERROR: " + ex.Message);
                return null;
            }
        }



        /// <summary>
        /// دالة ترسل طلب المستخدم للـ AI وتسترجع جملة SQL SELECT صافية ومفحوصة أمنياً
        /// </summary>
        private static async Task<string> GetSqlFieldsFromAiAsync(string userPrompt)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 1. تجهيز الـ System Prompt الصارم وتوصيف قاعدة بيانات نظام "الماهر"
                    string systemPrompt = "You are a strict SQL Server Expert for 'Al-Maher POS & Partner Accounting System'. " +
                         "Your ONLY job is to translate the user's Arabic request into a single standard SQL Server SELECT query based strictly on the provided schema.\n\n" +

                         "Database Schema:\n" +
                         "- Customers (CustomerID int PK, PersonID int FK, IsActive bit, Notes nvarchar, TotalRemainingDebt decimal, CreditLimit decimal, CustomerType nvarchar, DiscountPercentage decimal, CreatedDate datetime, ModifiedDate datetime)\n" +
                         "- Partners (PartnerID int PK, PersonID int FK, CurrentBalance decimal, ProfitPercentage decimal, CreatedDate datetime, ModifiedDate datetime, IsActive bit)\n" +
                         "- PaymentMethods (PaymentMethodID int PK, PaymentMethodName nvarchar)\n" +
                         "- People (PersonID int PK, FirstName nvarchar, SecondName nvarchar, LastName nvarchar, Phone nvarchar, CreateDate datetime, ModifyDate datetime, Address nvarchar, ImagePath nvarchar)\n" +
                         "- ProductCategories (CategoryID int PK, CategoryName nvarchar, Description nvarchar, CreatedDate datetime)\n" +
                         "- Products (ProductID int PK, ProductCategoryID int FK, CostPrice decimal, SellingPrice decimal, UnitOfSale nvarchar, ProductName nvarchar, Description nvarchar, ImagePath nvarchar, BarCode nvarchar, QuantityInStock decimal, MinimumQuantityForWarning decimal, CreateDate datetime, ModifyDate datetime, IsActive bit)\n" +
                         "- SaleDetails (SaleDetailID int PK, SaleID int FK, ProductID int FK, CostPrice decimal, SellingPrice decimal, Quantity decimal, ReturnedQuantity decimal, ProductName nvarchar, DiscountAmount decimal)\n" +
                         "- Sales (SaleID int PK, UserID int FK, CustomerID int FK, PaymentMethodID int FK, Status int (1 created when open the form 2 click saved ), TotalAmount decimal, PaidAmount decimal, DiscountAmount decimal, CreateDate datetime, ModifyDate datetime, Notes nvarchar)\n" +
                         "- Suppliers (SupplierID int PK, PersonID int FK, TotalRemainingDebt decimal, Notes nvarchar, CreatedDate datetime, ModifiedDate datetime, IsActive bit)\n" +
                         "- Users (UserID int PK, PersonID int FK, UserName nvarchar, HashPassword nvarchar, Notes nvarchar, PermissionInBinary int, CreatedDate datetime, IsActive bit, PasswordSalt nvarchar)\n\n" +

                         "Relationships Rules:\n" +
                         "1. To get names for Customers, Partners, Suppliers, or Users, you MUST JOIN with the 'People' table using PersonID and combine FirstName, SecondName, and LastName.\n" +
                         "2. Table ProductCategories relates to Products via ProductCategoryID.\n" +
                         "3. Table Sales relates to Customers via CustomerID, Users via UserID, and PaymentMethods via PaymentMethodID.\n" +
                         "4. Table SaleDetails relates to Sales via SaleID and Products via ProductProductID.\n\n" +

                         "Strict Constraints:\n" +
                         "1. Return ONLY the raw SQL query. No markdown (NO ```sql), no explanation, no prose.\n" +
                         "2. ONLY generate SELECT queries. If the user asks for INSERT, UPDATE, DELETE, DROP, ALTER, or data-modifying commands, return the exact word: 'FORBIDDEN'.\n" +
                         "3. Security: NEVER include 'HashPassword' or 'PasswordSalt' in any SELECT query. If requested, return 'FORBIDDEN'.\n" +
                         "4. Column Limit: Never return more than 8 columns in a single query. Choose the most relevant ones.\n" +
                         "5. Fallback: If the request is unrelated to the schema or impossible, return: 'ERROR'.";
                    // 2. دمج التلقين الصارم مع سؤال المستخدم وتجهيز الـ Body بصيغة الـ JSON المطلوبة من جوجل
                    var requestBody = new
                    {
                        contents = new[]
                        {
                            new
                            {
                                parts = new[]
                                {
                                    new { text = systemPrompt + "\n\nUser Request: " + userPrompt }
                                }
                            }
                        }
                    };

                    // تحويل الكائن البرمجي إلى نص JSON باستخدام مكتبة Newtonsoft
                    string jsonPayload = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    // 3. إرسال الطلب للسيرفر وانتظار الرد
                    HttpResponseMessage response = await client.PostAsync(_uri, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        return "ERROR: " + response.StatusCode + " -> " + errorContent;
                        //return "ERROR: فشل الاتصال بسيرفر الذكاء الاصطناعي.";
                    }

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // 4. تفكيك الـ JSON المرتجع من جوجل للوصول للنص الصافي
                    dynamic dynamicObject = JsonConvert.DeserializeObject(jsonResponse);
                    string rawSql = dynamicObject.candidates[0].content.parts[0].text;

                    // تنظيف النص من أي فراغات زائدة أو أسطر سفلية
                    rawSql = rawSql.Trim();


                    // 5. الفحص الأمني الصارم (Security Validation) لحماية نظام الماهر
                    if (IsQueryDangerous(rawSql))
                    {
                        return "FORBIDDEN";
                    }

                    return rawSql;
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        /// <summary>
        /// تابع يفحص الجملة برمجياً للتأكد من خلوها من أي تعليمات تخريبية
        /// </summary>
        private static bool IsQueryDangerous(string query)
        {
            string upperQuery = query.ToUpper();

            // يجب أن تبدأ الجملة بـ SELECT حصراً
            if (!upperQuery.StartsWith("SELECT"))
                return true;

            // التحقق من عدم وجود كلمات مفتاحية للتعديل أو الحذف
            if (upperQuery.Contains("DROP") ||
                upperQuery.Contains("DELETE") ||
                upperQuery.Contains("UPDATE") ||
                upperQuery.Contains("INSERT") ||
                upperQuery.Contains("ALTER") ||
                upperQuery.Contains("TRUNCATE"))
            {
                return true;
            }

            return false;
        }

    }
}
