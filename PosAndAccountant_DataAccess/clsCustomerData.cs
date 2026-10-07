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
    public class clsCustomerData
    {

        public static clsCustomerDTO FindCustomerByID(int CustomerID)
        {

            clsCustomerDTO CustomerDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Customers].[SP_GetCustomerByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustomerDTO = new clsCustomerDTO();

                                CustomerDTO.CustomerID = CustomerID;
                                CustomerDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                CustomerDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                CustomerDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                CustomerDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                                CustomerDTO.CreditLimit = Convert.ToDouble(reader["CreditLimit"]);
                                CustomerDTO.CustomerType =reader["CustomerType"]!=DBNull.Value? Convert.ToInt32(reader["CustomerType"]):1;
                                CustomerDTO.DiscountPercentage = Convert.ToDouble(reader["DiscountPercentage"]);
                                CustomerDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                CustomerDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }




            return CustomerDTO;
        }
        public static clsCustomerDTO FindCustomerByPhone(string Phone)
        {

             clsCustomerDTO CustomerDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Customers].[SP_GetCustomerByPhone]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Phone", Phone);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustomerDTO = new clsCustomerDTO();

                                CustomerDTO.CustomerID = Convert.ToInt32(reader["CustomerID"]); ;
                                CustomerDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                CustomerDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                CustomerDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                CustomerDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                                CustomerDTO.CreditLimit = Convert.ToDouble(reader["CreditLimit"]);
                                CustomerDTO.CustomerType = reader["CustomerType"] != DBNull.Value ? Convert.ToInt32(reader["CustomerType"]) : 1;
                                CustomerDTO.DiscountPercentage = Convert.ToDouble(reader["DiscountPercentage"]);
                                CustomerDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                CustomerDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }




            return CustomerDTO;
        }

        public static clsCustomerDTO FindCustomerByPersonID(int PersonID)
        {
            clsCustomerDTO CustomerDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Customers].[SP_GetCustomerByPersonID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustomerDTO = new clsCustomerDTO();

                                CustomerDTO.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                CustomerDTO.PersonID = PersonID;
                                CustomerDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                CustomerDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                CustomerDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                                CustomerDTO.CreditLimit = Convert.ToDouble(reader["CreditLimit"]);
                                CustomerDTO.CustomerType = reader["CustomerType"] != DBNull.Value ? Convert.ToInt32(reader["CustomerType"]) : 1;
                                CustomerDTO.DiscountPercentage = Convert.ToDouble(reader["DiscountPercentage"]);
                                CustomerDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                CustomerDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }




            return CustomerDTO;
        }


        public static DataTable GetAllCustomers(int PageNumber,int PageSize)
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Customers].[SP_GetAllCustomers]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@PageSize", PageSize);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                                return dataTable;

                            }
                            else
                            {
                                return null;
                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }





        }

        public static bool DeleteCustomerByID(int CustomerID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Customers].[SP_DeleteCustomerByID]", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        connection.Open();
                        IsDeleted = command.ExecuteNonQuery() != 0;

                    }




                }


            }
            catch (Exception ex)
            {
                //log error
                IsDeleted = false;
            }



            return IsDeleted;
        }


        public static bool UpdateCustomerByID(clsCustomerDTO CustomerDTO)
        {
            int RowAffected = 0;

            try
            {



                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Customers].[SP_UpdateCustomerByID]", connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerDTO.CustomerID);

                        command.Parameters.AddWithValue("@PersonID", CustomerDTO.PersonID);
                        command.Parameters.AddWithValue("@IsActive", CustomerDTO.IsActive);
                        command.Parameters.AddWithValue("@TotalRemainingDebt", CustomerDTO.TotalRemainingDebt);

                        if (!string.IsNullOrEmpty(CustomerDTO.Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", CustomerDTO.Notes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);

                        }

                        command.Parameters.AddWithValue("@CreditLimit", CustomerDTO.CreditLimit);
                        command.Parameters.AddWithValue("@CustomerType", CustomerDTO.CustomerType);
                        command.Parameters.AddWithValue("@DiscountPercentage", CustomerDTO.DiscountPercentage);



                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        RowAffected = command.ExecuteNonQuery();

                    }



                }

            }
            catch (Exception ex)
            {
                //log;
            }

            return RowAffected > 0;
        }

        public static int AddNewCustomer(clsCustomerDTO CustomerDTO)
        {
            int CustomerID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Customers].[SP_AddNewCustomer]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", CustomerDTO.PersonID);
                    command.Parameters.AddWithValue("@IsActive", CustomerDTO.IsActive);

                    if (!string.IsNullOrEmpty(CustomerDTO.Notes))
                    {
                        command.Parameters.AddWithValue("@Notes", CustomerDTO.IsActive);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);

                    }
                    command.Parameters.AddWithValue("@TotalRemainingDebt", CustomerDTO.TotalRemainingDebt);
                    command.Parameters.AddWithValue("@CreditLimit", CustomerDTO.CreditLimit);
                    if (CustomerDTO.CustomerType < 1)
                        command.Parameters.AddWithValue("@CustomerType", DBNull.Value);
                    else
                    {
                        command.Parameters.AddWithValue("@CustomerType", CustomerDTO.CustomerType);

                    }

                    command.Parameters.AddWithValue("@DiscountPercentage", CustomerDTO.DiscountPercentage);



                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out CustomerID))
                    {

                    }
                    else
                    {
                        CustomerID = -1;
                    }


                }



            }

            return CustomerID;

        }

        public static bool IsPersonCustomer(int PersonID)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Customers].[SP_IsPersonCustomer]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);


                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            IsFound = Convert.ToBoolean(result);
                        }
                        else
                        {
                            IsFound = false;
                        }


                    }



                }


            }

            catch (Exception ex)
            {
                //LogInEventLog;
                IsFound = false;
            }


            return IsFound;




        }

        public static decimal GetAllCustomersDebt()
        {

            decimal TotalDebt = 0;
            string query = @"select  FORMAT(sum(TotalRemainingDebt)  , '0.##')from Customers ";
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
        public static int CountDebtCustomers()
        {

            int TotalDebt = 0;
            string query = @"
select count(1) as CountDebt from Customers where
TotalRemainingDebt>0
 ";
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
        public static int CountCustomers()
        {

            int TotalCustomers = 0;
            string query = @"select count(1) as CountCustomers	 from Customers  

 ";
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
                            TotalCustomers = total;
                        }
                        else
                        {
                            TotalCustomers = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalCustomers;

        }
        public static int CountCustomersToday()
        {

            int TotalCustomers = 0;
            string query = @"
select count(1) as CountCustomerToday from
(
 select  distinct   s.CustomerID  from SaleDetails sd join 
Sales s on sd.SaleID=s.SaleID
where CreateDate>= cast(GETDATE() as date) and
  CreateDate <Dateadd(day,1,cast(getdate() as date))
 )r
 ";
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
                            TotalCustomers = total;
                        }
                        else
                        {
                            TotalCustomers = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return TotalCustomers;

        }
        public static DataTable GetCustomersMostSaled(int PageNumber,int PageSize)
        {
            string query = @"

SELECT Customers.CustomerID, Concat_ws(' ', People.FirstName, People.SecondName, People.LastName) AS FullName,case when People.Phone is null then 'لا يوجد' else People.Phone end as Phone,  case when People.Address is null then 'لا يوجد' else People.Address end as Address, Customers.IsActive,

Customers.TotalRemainingDebt, 
                  Customers.CustomerType
FROM     Customers INNER JOIN
                  People ON Customers.PersonID = People.PersonID
			join (
select CustomerID,sum(TotalAmount-DiscountAmount) as Total from Sales	
group by CustomerID) s on Customers.CustomerID=s.CustomerID
order by s.Total desc  
 offset(@PageNumber - 1) * @PageSize rows
 fetch next @PageSize rows only";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                     command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@PageSize", PageSize);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                                return dataTable;

                            }
                            else
                            {
                                return null;
                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }





        }
         public static DataTable GetCustomersLowSaled(int PageNumber,int PageSize)
        {
            string query = @"

SELECT Customers.CustomerID, Concat_ws(' ', People.FirstName, People.SecondName, People.LastName) AS FullName,case when People.Phone is null then 'لا يوجد' else People.Phone end as Phone,  case when People.Address is null then 'لا يوجد' else People.Address end as Address, Customers.IsActive,

Customers.TotalRemainingDebt, 
                  Customers.CustomerType
FROM     Customers INNER JOIN
                  People ON Customers.PersonID = People.PersonID
			join (
select CustomerID,sum(TotalAmount-DiscountAmount) as Total from Sales	
group by CustomerID) s on Customers.CustomerID=s.CustomerID
order by s.Total asc
 offset(@PageNumber - 1) * @PageSize rows
 fetch next @PageSize rows only";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                     command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@PageSize", PageSize);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                                return dataTable;

                            }
                            else
                            {
                                return null;
                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }





        }
        public static DataTable GetCustomersMostProfit(int PageNumber, int PageSize)
        {
            string query = @" 

SELECT Customers.CustomerID, Concat_ws(' ', People.FirstName, People.SecondName, People.LastName) AS FullName,case when People.Phone is null then 'لا يوجد' else People.Phone end as Phone,  case when People.Address is null then 'لا يوجد' else People.Address end as Address, Customers.IsActive,

Customers.TotalRemainingDebt, 
                  Customers.CustomerType
FROM     Customers INNER JOIN
                  People ON Customers.PersonID = People.PersonID
			join (

select s.CustomerID,sum(p.NetProfit) as Profit from ProfitRuns p
join Sales s on p.SaleID=s.SaleID
group  by s.CustomerID ) pr on pr.CustomerID =Customers.CustomerID
order by pr.Profit desc
 offset(@PageNumber - 1) * @PageSize rows
 fetch next @PageSize rows only";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@PageSize", PageSize);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                                return dataTable;

                            }
                            else
                            {
                                return null;
                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }





        }
        public static DataTable GetCustomersWithDebt(int PageNumber, int PageSize)
        {
            string query = @" 

SELECT Customers.CustomerID, Concat_ws(' ', People.FirstName, People.SecondName, People.LastName) AS FullName,case when People.Phone is null then 'لا يوجد' else People.Phone end as Phone,  case when People.Address is null then 'لا يوجد' else People.Address end as Address, Customers.IsActive,

Customers.TotalRemainingDebt, 
                  Customers.CustomerType
FROM     Customers INNER JOIN
                  People ON Customers.PersonID = People.PersonID
			  
order by TotalRemainingDebt desc
 offset(@PageNumber - 1) * @PageSize rows
 fetch next @PageSize rows only";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    command.Parameters.AddWithValue("@PageSize", PageSize);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                                return dataTable;

                            }
                            else
                            {
                                return null;
                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        //Loging in event lopg
                        return null;

                    }



                }




            }





        }


    }
}
