using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace PosAndAccountant_DataAccess
{
    public class clsSaleData
    {
 public static int AddSale(clsSaleDTO SaleDTO)
        {

            int SaleID = -1;

            DataTable SaleDetails = new DataTable();
            SaleDetails.Columns.Add("ProductID", typeof(int));
            SaleDetails.Columns.Add("SellingPrice", typeof(decimal));

            SaleDetails.Columns.Add("Quantity", typeof(int));
             SaleDetails.Columns.Add("ReturnQuantity", typeof(int));
            SaleDetails.Columns.Add("DiscountAmount", typeof(decimal));


            foreach (var item in SaleDTO.SaleDetails)
            {
                SaleDetails.Rows.Add(item.ProductID, item.SellingPrice, item.Quantity , item.ReturnQ,item.DiscountAmount);

            }



            try
            {  // Send everything in ONE call q
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("[Sales].[SP_SaveSale]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", SaleDTO.UserID);
                    cmd.Parameters.AddWithValue("@CustomerID", SaleDTO.CustomerID);
                    if (string.IsNullOrEmpty(SaleDTO.Notes.Trim()))
                        cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Notes", SaleDTO.Notes);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", SaleDTO.PaymentMethodID);
                    cmd.Parameters.AddWithValue("@TotalAmount", SaleDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@PaidAmount", SaleDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", SaleDTO.DiscountAmount);
 

                    var p = cmd.Parameters.AddWithValue("@Details", SaleDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "SaleDetailType";


                    // Setup the OUTPUT Parameter to capture the new identity
                    SqlParameter outputIdParameter = new SqlParameter();
                    outputIdParameter.ParameterName = "@SaleID";
                    outputIdParameter.SqlDbType = SqlDbType.Int;
                    outputIdParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputIdParameter);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    // Retrieve the value returned from the stored procedure
                    if (outputIdParameter.Value != DBNull.Value)
                    {
                        SaleID = (int)outputIdParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                //loging erro
                return -1;
            }


            return SaleID;


        }
        public static bool UpdateSale(clsSaleDTO SaleDTO)
        {

 
            DataTable SaleDetails = new DataTable();
            SaleDetails.Columns.Add("ProductID", typeof(int));
            SaleDetails.Columns.Add("SellingPrice", typeof(decimal));

            SaleDetails.Columns.Add("Quantity", typeof(int));
            SaleDetails.Columns.Add("ReturnQuantity", typeof(int));
            SaleDetails.Columns.Add("DiscountAmount", typeof(decimal));


            foreach (var item in SaleDTO.SaleDetails)
            {
                SaleDetails.Rows.Add(item.ProductID, item.SellingPrice, item.Quantity, item.ReturnQ, item.DiscountAmount);

            }



            try
            {  // Send everything in ONE call
                using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (var cmd = new SqlCommand("[Sales].[SP_UpdateSale]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", SaleDTO.UserID);
                    cmd.Parameters.AddWithValue("@CustomerID", SaleDTO.CustomerID);
                    if (string.IsNullOrEmpty(SaleDTO.Notes.Trim()))
                        cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Notes", SaleDTO.Notes);
                    cmd.Parameters.AddWithValue("@PaymentMethodID", SaleDTO.PaymentMethodID);
                    cmd.Parameters.AddWithValue("@TotalAmount", SaleDTO.TotalAmount);
                    cmd.Parameters.AddWithValue("@PaidAmount", SaleDTO.PaidAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", SaleDTO.DiscountAmount);


                    var p = cmd.Parameters.AddWithValue("@Details", SaleDetails); // ✅ DataTable directly
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "SaleDetailType";


                    cmd.Parameters.AddWithValue("@SaleID", SaleDTO.SaleID);


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


       
        public static BindingList<clsSaleDetailDTO> GetSaleDetailBySaleID(int SaleID)
        {

            BindingList<clsSaleDetailDTO> SaleDetails = new BindingList<clsSaleDetailDTO>();
            string query = @"SELECT ROW_NUMBER() over(order by SaleDetailID)as Counter,
ProductName      
      ,[SellingPrice]
      ,[Quantity]
      ,[ReturnedQuantity]
      ,ProductID
      
  FROM [AccountantDB].[dbo].[SaleDetails]
  where SaleID=@SaleID



";
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
                            while (reader.Read())
                            {

                                SaleDetails.Add(new clsSaleDetailDTO(
    Convert.ToInt32(reader["Counter"]),
    reader["ProductName"].ToString(),
    Convert.ToDecimal(reader["SellingPrice"]),
    Convert.ToInt32(reader["Quantity"]),
    Convert.ToInt32(reader["ReturnedQuantity"]),
    Convert.ToInt32(reader["ProductID"])));



                            }



                        }
                    }
                    catch { return null; }
                }
            }
            return SaleDetails;





        }

        public static clsSaleDTO GetSale(int SaleID)
        {

            clsSaleDTO SaleDTO = null;
            string query = @"SELECT   SaleID, UserID, CustomerID, PaymentMethodID, TotalAmount, PaidAmount, DiscountAmount, Notes
FROM    Sales
where SaleID=@SaleID";
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
                                SaleDTO.UserID = Convert.ToInt32(reader["UserID"]);
                                SaleDTO.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                                SaleDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SaleDTO.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                SaleDTO.DiscountAmount = Convert.ToDecimal(reader["DiscountAmount"]);
                                SaleDTO.PaymentMethodID = Convert.ToInt16(reader["PaymentMethodID"]);
                                SaleDTO.PaidAmount = Convert.ToDecimal(reader["PaidAmount"]);
                                SaleDTO.SaleDetails = GetSaleDetailBySaleID(SaleID);
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

        public static decimal MaxSaleToday()
        {
            {
                decimal TotalAmount = 0;
                string query = @"select Cast (ISNULL( max(TotalAmount),0) as decimal(16,2)) AS TotalAmount  from Sales
where day(getdate())=day(CreateDate);";
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
                                TotalAmount = total;
                            }
                            else
                            {
                                TotalAmount = 0;
                            }
                        }
                        catch { return -1; }
                    }
                }
                return TotalAmount;
            }


            }
        public static decimal TotalDebtToday()
        {
            {
                decimal TotalDebt = 0;
                string query = @"select Cast (ISNULL( Sum(TotalAmount-PaidAmount-DiscountAmount),0) as decimal(16,2)) AS TotalDebt  from Sales
where day(getdate())=day(CreateDate	);";
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
                                TotalDebt = total;
                            }
                            else
                            {
                                TotalDebt = 0;
                            }
                        }
                        catch { return -1; }
                    }
                }
                return TotalDebt;
            }


        }
        public static decimal TotalDiscountToday()
        {
            {
                decimal Total = 0;
                string query = @" 
select Cast( ISNULL( Sum(s.DiscountAmount),0) +ISNULL(sum(sd.[DiscountAmount]),0) as decimal(16,2)) as TotalDiscount  from SaleDetails  sd join Sales s on sd.SaleID=s.SaleID
where day(getdate())=day(CreateDate	)

;";
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
                                Total = total;
                            }
                            else
                            {
                                Total = 0;
                            }
                        }
                        catch { return -1; }
                    }
                }
                return Total;
            }


        }
        public static DataTable GetLast10TotalProfitByDay()
        {
            DataTable dt = new DataTable();
            string query = @"
    select top 10 Cast( ISNULL( Sum(NetProfit),0)   as decimal(16,2)) as Profit,cast(CreatedDate  as date) Date from ProfitRuns 
     group by cast(CreatedDate as date)
     order by Date desc
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


    }

}
