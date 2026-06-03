



using System;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PosAndAccountant_DataAccess;

namespace PosAndAccountant_business
{
    public class clsAiReportManager
    {
        private static readonly string _apiKey = ConfigurationManager.AppSettings["GroqApiKey"];
       
        // الرابط الموحد والمتوافق مع سيرفر Groq لكسر الحظر
        private static readonly string _uri = "https://api.groq.com/openai/v1/chat/completions";                                                                                                                                                                       /// الدالة الرئيسية والوحيدة التي ستراها طبقة الـ Presentation.


        public static async Task<DataTable> GetReportDataTableFromAiAsync(string userPrompt, Action<string> onErrorOrForbidden)
        {
            string sqlQuery = await GetSqlFieldsFromAiAsync(userPrompt);

            if (sqlQuery == "FORBIDDEN" || sqlQuery == "ERROR" || sqlQuery.StartsWith("ERROR:"))
            {
                onErrorOrForbidden?.Invoke(sqlQuery);
                return null;
            }

            try
            {
                DataTable dtResult = clsReportData.GetDataTable(sqlQuery);
                return dtResult;
            }
            catch (Exception ex)
            {
                onErrorOrForbidden?.Invoke("ERROR: " + ex.Message);
                return null;
            }
        }

        private static async Task<string> GetSqlFieldsFromAiAsync(string userPrompt)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // إضافة الـ Authorization Header الخاص بـ OpenAI
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

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
                        "5. Fallback: If the request is unrelated to the schema or impossible,or not even a question return the exact word: 'ERROR'.";

                    // الهيكلية الصحيحة لطلب OpenAI (Chat Completions)
                    var requestBody = new
                    {
                        model = "llama-3.1-8b-instant", // هذا هو الموديل البديل الأحدث، السريع والمجاني بالكامل
                        messages = new[]
    {
        new { role = "system", content = systemPrompt },
        new { role = "user", content = userPrompt }
    },
                        temperature = 0.1
                    };

                    string jsonPayload = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(_uri, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        return "ERROR: السيرفر رفض الطلب -> " + errorContent;
                    }

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // تفكيك الـ JSON الخاص بـ OpenAI لطباعة النص الصافي
                    dynamic dynamicObject = JsonConvert.DeserializeObject(jsonResponse);
                    string rawSql = dynamicObject.choices[0].message.content;

                    rawSql = rawSql.Trim();
                    if (rawSql != "ERROR")

                        if (IsQueryDangerous(rawSql)) return "FORBIDDEN";

                    return rawSql;
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        private static bool IsQueryDangerous(string query)
        {
            string upperQuery = query.ToUpper();
            if (!upperQuery.StartsWith("SELECT")) return true;
            if (upperQuery.Contains("DROP") || upperQuery.Contains("DELETE") || upperQuery.Contains("UPDATE") || upperQuery.Contains("INSERT") || upperQuery.Contains("ALTER") || upperQuery.Contains("TRUNCATE")) return true;
            return false;
        }
    }
}