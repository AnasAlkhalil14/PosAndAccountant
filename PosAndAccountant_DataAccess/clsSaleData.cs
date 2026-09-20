using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace PosAndAccountant_DataAccess
{
    public class clsSaleData
    {
 public static int AddSale(clsSaleDTO clsSaleDTO)
        {
            return -1;
        }
        public static bool UpdateSale(clsSaleDTO saleDTO)
        {
            return false;
        }

        //-------(Has work  to do here)------------
        public static clsSaleDTO GetSale(int SaleID)
        {
            return null;
        }
        public static int AddNewSale(int UserID)
        {
            int newSaleID = -1;

             

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Sales.SP_AddNewSale", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Pass Input Parameters directly from the DTO properties
                    command.Parameters.AddWithValue("@UserID", UserID);

           
                    // Setup the OUTPUT Parameter to capture the new identity
                    SqlParameter outputIdParameter = new SqlParameter();
                    outputIdParameter.ParameterName = "@NewSaleID";
                    outputIdParameter.SqlDbType = SqlDbType.Int;
                    outputIdParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputIdParameter);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Retrieve the value returned from the stored procedure
                        if (outputIdParameter.Value != DBNull.Value)
                        {
                            newSaleID = (int)outputIdParameter.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log your exception here
                        newSaleID = -1;
                    }
                }
            }

            return newSaleID;
        }
    
       public static bool SaveSale(clsSaleDTO SaleDTO,DataTable SaleDetails)
        {


            try
            {  // Send everything in ONE call
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("Sales.SP_SaveSale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleID", SaleDTO.SaleID);  
                       cmd.Parameters.AddWithValue("@PaidAmount", SaleDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@CustomerID", SaleDTO.CustomerID);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", SaleDTO.PaymentMethodID);
                     cmd.Parameters.AddWithValue("@TotalAmount", SaleDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", SaleDTO.DiscountAmount);
                    cmd.Parameters.AddWithValue("@Notes", SaleDTO.Notes);


                    var p = cmd.Parameters.AddWithValue("@Details", SaleDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "SaleDetailType";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                //loging erro
            return false;
            }


            return true;

        }
        public static bool UpdateSale2(clsSaleDTO SaleDTO, DataTable SaleDetails)
        {


            try
            {  // Send everything in ONE call
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("[Sales].[SP_UpdateSale]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleID", SaleDTO.SaleID);
                    cmd.Parameters.AddWithValue("@PaidAmount", SaleDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@CustomerID", SaleDTO.CustomerID);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", SaleDTO.PaymentMethodID);
                          cmd.Parameters.AddWithValue("@TotalAmount", SaleDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", SaleDTO.DiscountAmount);
                    cmd.Parameters.AddWithValue("@Notes", SaleDTO.Notes);


                    var p = cmd.Parameters.AddWithValue("@Details", SaleDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "SaleDetailType";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //loging erro
                return false;
            }


            return true;

        }
        public static DataTable GetSaleDetailBySaleID(int SaleID)
        {

            DataTable dt = new DataTable();
            string query = "SELECT   ProductID, ProductName, SellingPrice, Quantity, ReturnedQuantity, DiscountAmount FROM  SaleDetails where SaleID=@SaleID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SaleID", SaleID);   
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                    catch { return null; }
                }
            }
            return dt;





        }

        public static clsSaleDTO GetSaleByID(int SaleID)
        {
            clsSaleDTO SaleDTO = null;
            string query = @"Select * from Sales where SaleID=@SaleID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@SaleID", SaleID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SaleDTO = new clsSaleDTO();
                                SaleDTO.SaleID = SaleID;
                                SaleDTO.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                                 SaleDTO.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
                                SaleDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SaleDTO.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                SaleDTO.DiscountAmount = Convert.ToDecimal(reader["DiscountAmount"]);
                                SaleDTO.PaymentMethodID = Convert.ToInt16(reader["PaymentMethodID"]);
                                SaleDTO.PaidAmount = Convert.ToDecimal(reader["PaidAmount"]);
                                
                            }
                        }
                    }
                    catch { return null; }
                }
            }
            return SaleDTO;
        }

        public static decimal GetDaySale()
        {

            decimal TotalSale = 0;
            string query = @"SELECT CAST(ISNULL(SUM(TotalAmount), 0) AS DECIMAL(10,2)) AS DaySale
FROM Sales
WHERE CreateDate >= CAST(GETDATE() AS DATE)
  AND CreateDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE));";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                     try
                    {
                        connection.Open();
                        object result= command.ExecuteScalar();
                        if(result != null&&decimal.TryParse(result.ToString(),out decimal total))
                            {
                            TotalSale = total;
                        }
                        else
                        {
                            TotalSale = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalSale;

        }
        public static decimal GetYesterdaySale()
        {
            decimal TotalSale = 0;
            string query = @"SELECT CAST(ISNULL(SUM(TotalAmount), 0) AS DECIMAL(10,2)) AS DaySale
FROM Sales
WHERE CreateDate >= DATEADD(DAY, -1, CAST(GETDATE() AS DATE))
  AND CreateDate < CAST(GETDATE() AS DATE);";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal total))
                        {
                            TotalSale = total;
                        }
                        else
                        {
                            TotalSale = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalSale;

        }

        public static decimal GetDayPaid()
        {

            decimal TotalPay = 0;
            string query = @" SELECT CAST(ISNULL(SUM(PaidAmount), 0) AS DECIMAL(16,2)) AS DayPaid
FROM Sales
WHERE CreateDate >= CAST(GETDATE() AS DATE)
  AND CreateDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE));";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal total))
                        {
                            TotalPay = total;
                        }
                        else
                        {
                            TotalPay     = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalPay;

        }

        public static decimal GetYesterdayPaid()
        {
            decimal TotalPaid = 0;
            string query = @"SELECT CAST(ISNULL(SUM(PaidAmount), 0) AS DECIMAL(10,2)) AS DayPaid
FROM Sales
WHERE CreateDate >= DATEADD(DAY, -1, CAST(GETDATE() AS DATE))
  AND CreateDate < CAST(GETDATE() AS DATE);";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal total))
                        {
                            TotalPaid = total;
                        }
                        else
                        {
                            TotalPaid = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalPaid;

        }

        public static decimal GetDayProfit()
        {

            decimal TotalProfit = 0;
            string query = @"SELECT cast( ISNULL( sum(NetProfit),0) as decimal(16,2) )as DayProfit
  FROM [AccountantDB].[dbo].[ProfitRuns]
  where CreatedDate>= cast(GETDATE() as date) and
  CreatedDate <Dateadd(day,1,cast(getdate() as date))";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal total))
                        {
                            TotalProfit = total;
                        }
                        else
                        {
                            TotalProfit = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalProfit;

        }
        public static decimal GetYesterdayProfit()
        {
            decimal TotalProfit = 0;
            string query = @"SELECT cast( ISNULL( sum(NetProfit),0) as decimal(16,2) )as DayProfit
  FROM [AccountantDB].[dbo].[ProfitRuns]
WHERE CreatedDate >= DATEADD(DAY, -1, CAST(GETDATE() AS DATE))
  AND CreatedDate < CAST(GETDATE() AS DATE);";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal total))
                        {
                            TotalProfit = total;
                        }
                        else
                        {
                            TotalProfit = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalProfit;

        }

        public static int GetCountDaySale()
        {

            int count = 0;
            string query = @"SELECT  Count(1)   as CountDaySale
  FROM [AccountantDB].[dbo].Sales
  where CreateDate>= cast(GETDATE() as date) and
  CreateDate <Dateadd(day,1,cast(getdate() as date))";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int total))
                        {
                            count = total;
                        }
                        else
                        {
                            count = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return count;

        }
        public static int GetYesterdayCountDaySale()
        {
            int count = 0;
            string query = @"SELECT  Count(1)   as CountDaySale
  FROM [AccountantDB].[dbo].Sales
WHERE CreateDate >= DATEADD(DAY, -1, CAST(GETDATE() AS DATE))
  AND CreateDate < CAST(GETDATE() AS DATE);";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int total))
                        {
                            count = total;
                        }
                        else
                        {
                            count = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return count;

        }

        public static DataTable GetLast10SalesToday()
        {
            DataTable dt= new DataTable();
            string query = @" SELECT  top 10      Sales.SaleID, People.FirstName+' '+People.LastName as FullName, CONVERT(VARCHAR(5), CreateDate, 108) AS CreateTime, Sales.TotalAmount
FROM            Sales INNER JOIN
                         Customers ON Sales.CustomerID = Customers.CustomerID INNER JOIN
                         People ON Customers.PersonID = People.PersonID

 where CreatedDate>= cast(GETDATE() as date) and
 CreatedDate <Dateadd(day,1,cast(getdate() as date))
";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                    catch { return null; }
                }
            }
            return dt;

        }
        public static DataTable GetLast10TotalSaleByDay()
        {
            DataTable dt = new DataTable();
            string query = @"select top 10 sum(totalAmount) as TotalSale,cast(CreateDate as date) as SaleDate from Sales
  group by CAST(CreateDate as date)";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                    catch { return null; }
                }
            }
            return dt;

        }
        public static DataTable GetAllSales(int PageNumber,int PageSize)
        {
            DataTable dt = new DataTable();
            string query = @" SELECT       Sales.SaleID, Sales.TotalAmount, Sales.PaidAmount, People.FirstName+' '+ People.LastName as CustomerName ,Sales.CreateDate
FROM            Sales INNER JOIN
                         Customers ON Sales.CustomerID = Customers.CustomerID INNER JOIN
                         People ON Customers.PersonID = People.PersonID
						 order by Sales.CreateDate desc
						 offset(@PageNumber - 1) * @PageSize rows
						 fetch next @PageSize rows only";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@PageSize", PageSize);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                    catch { return null; }
                }
            }
            return dt;

        }



    }

}
