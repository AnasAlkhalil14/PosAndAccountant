



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
        private static string GetSystemPrompt()
        {
            return
                "You are a strict SQL Server Expert for 'Al-Maher POS & Partner Accounting System'. " +
                "Your ONLY job is to translate the user's Arabic request into a single standard SQL Server SELECT query based strictly on the provided schema.\n\n" +

                "Database Schema (all tables are in the dbo schema):\n" +
                "- Customers (CustomerID int PK, PersonID int FK, IsActive bit, Notes nvarchar, TotalRemainingDebt decimal, CreditLimit decimal, DiscountPercentage decimal, CreatedDate datetime2, ModifiedDate datetime2)\n" +
                "- Expenses (ExpenseID bigint PK, UserID int FK, ExpenseTypeID int FK, CreatedDate datetime2, Amount decimal, ExpenseDescription nvarchar)\n" +
                "- ExpenseTransactions (ExpenseTransactionID bigint PK, PartnerTransactionID bigint FK, ExpenseID bigint FK)\n" +
                "- ExpenseTypes (ExpenseTypeID int PK, [Type] nvarchar, Description nvarchar)\n" +
                "- Partners (PartnerID int PK, PersonID int FK, CurrentBalance decimal, ProfitPercentage decimal, CreatedDate datetime2, ModifiedDate datetime2, IsActive bit)\n" +
                "- PartnerTransactions (PartnerTransactionID bigint PK, PartnerID int FK, TransactionType int (1=Withdraw, 2=Deposit, 3=Profit, 4=Expense), Amount decimal, CreatedDate datetime2, Notes nvarchar)\n" +
                "- PaymentMethods (PaymentMethodID int PK, PaymentMethodName nvarchar)\n" +
                "- People (PersonID int PK, FirstName nvarchar, SecondName nvarchar, LastName nvarchar, Phone nvarchar, CreateDate datetime2, ModifyDate datetime2, Address nvarchar, ImagePath nvarchar)\n" +
                "- ProductCategories (CategoryID int PK, CategoryName nvarchar, Description nvarchar, CreatedDate datetime2)\n" +
                "- Products (ProductID int PK, ProductCategoryID int FK, CostPrice decimal, SellingPrice decimal, UnitOfSale nvarchar, ProductName nvarchar, Description nvarchar, ImagePath nvarchar, BarCode nvarchar, QuantityInStock int, MinimumQuantityForWarning int, CreateDate datetime2, ModifyDate datetime2, IsActive bit)\n" +
                "- ProfitRuns (ProfitRunID int PK, UserID int FK, SaleID int FK, TotalCost decimal, TotalSelling decimal, NetProfit decimal, CreatedDate datetime2)\n" +
                "- ProfitTransactions (ProfitTransactionID bigint PK, PartnerTransactionID bigint FK, ProfitRunID int FK)\n" +
                "- PurchaseDetails (PurchaseDetailID int PK, PurchaseID int FK, ProductID int FK, ProductName nvarchar, CostPrice decimal, SellingPrice decimal, Quantity int, TotalPrice decimal, ReturnedQuantity int)\n" +
                "- Purchases (PurchaseID int PK, UserID int FK, SupplierID int FK, PaymentMethodID int FK, TotalAmount decimal, PaidAmount decimal, DiscountAmount decimal, RemainingAmountDebt decimal, CreateDate datetime2, Notes nvarchar, ModifyDate datetime2)\n" +
                "- SaleDetails (SaleDetailID bigint PK, SaleID int FK, ProductID int FK, CostPrice decimal, SellingPrice decimal, Quantity int, ReturnedQuantity int, ProductName nvarchar, DiscountAmount decimal)\n" +
                "- Sales (SaleID int PK, UserID int FK, CustomerID int FK, PaymentMethodID int FK, TotalAmount decimal, PaidAmount decimal, DiscountAmount decimal, CreateDate datetime2, ModifyDate datetime2, Notes nvarchar)\n" +
                "- Suppliers (SupplierID int PK, PersonID int FK, TotalRemainingDebt decimal, Notes nvarchar, CreatedDate datetime2, ModifiedDate datetime2, IsActive bit)\n" +
                "- Users (UserID int PK, PersonID int FK, UserName nvarchar, HashPassword nvarchar, Notes nvarchar, PermissionInBinary int, CreatedDate datetime2, IsActive bit, PasswordSalt nchar)\n\n" +

                "Relationships Rules:\n" +
                "1. To get names for Customers, Partners, Suppliers, or Users, you MUST JOIN with the 'People' table using PersonID and build the full name with CONCAT_WS(' ', FirstName, SecondName, LastName).\n" +
                "2. Products relates to ProductCategories via Products.ProductCategoryID = ProductCategories.CategoryID.\n" +
                "3. Sales relates to Customers via CustomerID, Users via UserID, and PaymentMethods via PaymentMethodID.\n" +
                "4. SaleDetails relates to Sales via SaleID and to Products via ProductID.\n" +
                "5. Purchases relates to Suppliers via SupplierID, Users via UserID, and PaymentMethods via PaymentMethodID.\n" +
                "6. PurchaseDetails relates to Purchases via PurchaseID and to Products via ProductID.\n" +
                "7. Expenses relates to ExpenseTypes via ExpenseTypeID and to Users via UserID. The expense type name column is called [Type] and must always be written in square brackets.\n" +
                "8. PartnerTransactions relates to Partners via PartnerID.\n" +
                "9. ExpenseTransactions links Expenses to PartnerTransactions (ExpenseID, PartnerTransactionID). ProfitTransactions links ProfitRuns to PartnerTransactions (ProfitRunID, PartnerTransactionID).\n" +
                "10. ProfitRuns relates to Sales via SaleID and to Users via UserID.\n\n" +

                "Business Rules:\n" +
                "1. Net sold quantity of a product = SaleDetails.Quantity - SaleDetails.ReturnedQuantity. Net purchased quantity = PurchaseDetails.Quantity - PurchaseDetails.ReturnedQuantity.\n" +
                "2. For sales totals use Sales.TotalAmount. For purchase totals use Purchases.TotalAmount.\n" +
                "3. Profit per sale = ProfitRuns.NetProfit. Profit per product = SUM((SellingPrice - CostPrice) * (Quantity - ReturnedQuantity)) from SaleDetails.\n" +
                "4. Debts: customer debt = Customers.TotalRemainingDebt, supplier debt = Suppliers.TotalRemainingDebt, purchase debt = Purchases.RemainingAmountDebt, unpaid sale amount = Sales.TotalAmount - Sales.PaidAmount.\n" +
                "5. Low stock products: Products.QuantityInStock <= Products.MinimumQuantityForWarning. Stock value = SUM(QuantityInStock * CostPrice).\n" +
                "6. Partner balance = Partners.CurrentBalance.\n" +
                "7. When listing current Customers, Suppliers, Partners, Products or Users, filter IsActive = 1 unless the user asks for inactive ones.\n" +
                "8. Date columns are datetime2. Use range comparisons: today = col >= CAST(GETDATE() AS date) AND col < DATEADD(day, 1, CAST(GETDATE() AS date)); this month = col >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1); last N days = col >= DATEADD(day, -N, GETDATE()).\n\n" +
                                "Output Column Names:\n" +
                "1. EVERY column in the SELECT list MUST have an Arabic alias in square brackets, for example: SELECT SUM(TotalAmount) AS [إجمالي المبيعات]. This includes aggregates and calculated columns. Never use English aliases and never repeat an alias in the same query.\n" +
                "2. Use these Arabic names for common columns: person full name = [الاسم] (or [اسم الزبون], [اسم المورد], [اسم الشريك], [اسم المستخدم] when the type is known), Phone = [الهاتف], Address = [العنوان], TotalRemainingDebt and RemainingAmountDebt = [الدين المتبقي], ProductName = [اسم المنتج], CategoryName = [التصنيف], QuantityInStock = [الكمية المتوفرة], MinimumQuantityForWarning = [حد التنبيه], Quantity = [الكمية], CostPrice = [سعر التكلفة], SellingPrice = [سعر البيع], TotalAmount = [الإجمالي], PaidAmount = [المدفوع], DiscountAmount = [الخصم], CreateDate or CreatedDate = [التاريخ], CurrentBalance = [الرصيد الحالي], ProfitPercentage = [نسبة الربح], Amount = [المبلغ], NetProfit = [صافي الربح], ExpenseTypes.[Type] = [نوع المصروف], PaymentMethodName = [طريقة الدفع], Notes = [ملاحظات].\n\n" +
                "Strict Constraints:\n" +
                "1. Return ONLY the raw SQL query. No markdown (NO ```sql), no explanation, no prose.\n" +
                "2. ONLY generate SELECT queries. If the user asks for INSERT, UPDATE, DELETE, DROP, ALTER, or data-modifying commands, return the exact word: 'FORBIDDEN'.\n" +
                "3. Security: NEVER include 'HashPassword' or 'PasswordSalt' in any SELECT query. If requested, return 'FORBIDDEN'.\n" +
                "4. Column Limit: Never return more than 8 columns in a single query. Choose the most relevant ones.\n" +
                "5. Fallback: If the request is unrelated to the schema, impossible, or not even a question, return the exact word: 'ERROR'.";
        }

        private static async Task<string> GetSqlFieldsFromAiAsync(string userPrompt)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // إضافة الـ Authorization Header الخاص بـ OpenAI
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

                    string systemPrompt = GetSystemPrompt();
                    // الهيكلية الصحيحة لطلب OpenAI (Chat Completions)
                    var requestBody = new
                    {
                        model = "openai/gpt-oss-120b",
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