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
    public class clsSupplierData
    {



        public static clsSupplierDTO FindSupplierByID(int SupplierID)
        {

            clsSupplierDTO SupplierDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_GetSupplierByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SupplierID", SupplierID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SupplierDTO = new clsSupplierDTO();

                                SupplierDTO.SupplierID = SupplierID;
                                SupplierDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                SupplierDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                SupplierDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SupplierDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                                SupplierDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                SupplierDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

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




            return SupplierDTO;
        }
        public static clsSupplierDTO FindSupplierByPhone(string Phone)
        {

            clsSupplierDTO SupplierDTO = null;
            string query = @"SELECT   Suppliers.*
FROM         Suppliers INNER JOIN
                         People ON Suppliers.PersonID = People.PersonID
						 where Phone=@Phone";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
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
                                SupplierDTO = new clsSupplierDTO();

                                SupplierDTO.SupplierID = Convert.ToInt32(reader["SupplierID"]); ;
                                SupplierDTO.PersonID = Convert.ToInt32(reader["PersonID"]);
                                SupplierDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                                SupplierDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SupplierDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                                SupplierDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                SupplierDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

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




            return SupplierDTO;
        }

        public static clsSupplierDTO FindSupplierByPersonID(int PersonID)
        {
            clsSupplierDTO SupplierDTO = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_GetSupplierByPersonID]", connection))
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
                               SupplierDTO = new clsSupplierDTO();
                                SupplierDTO.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                               SupplierDTO.PersonID = PersonID;
                               SupplierDTO.IsActive = Convert.ToBoolean(reader["IsActive"]);
                               SupplierDTO.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                                SupplierDTO.TotalRemainingDebt = Convert.ToDouble(reader["TotalRemainingDebt"]);
                               SupplierDTO.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                                SupplierDTO.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);

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




            return SupplierDTO;
        }


        public static DataTable GetAllSuppliers(int PageNumber,int PageSize)
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_GetAllSuppliers]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters
                        .AddWithValue("@PageNumber", PageNumber);
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

        public static bool DeleteSupplierByID(int SupplierID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Suppliers].[SP_DeleteSupplierByID]", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SupplierID", SupplierID);
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


        public static bool UpdateSupplierByID(clsSupplierDTO SupplierDTO)
        {
            int RowAffected = 0;

            try
            {



                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    using (SqlCommand command = new SqlCommand("[Suppliers].[SP_UpdateSupplierByID]", connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", SupplierDTO.SupplierID);

                        command.Parameters.AddWithValue("@PersonID", SupplierDTO.PersonID);
                        command.Parameters.AddWithValue("@IsActive", SupplierDTO.IsActive);
                        command.Parameters.AddWithValue("@TotalRemainingDebt", SupplierDTO.TotalRemainingDebt);

                        if (!string.IsNullOrEmpty(SupplierDTO.Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", SupplierDTO.Notes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);

                        }



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

        public static int AddNewSupplier(clsSupplierDTO SupplierDTO)
        {
            int SupplierID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("[Suppliers].[SP_AddNewSupplier]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", SupplierDTO.PersonID);
                    command.Parameters.AddWithValue("@IsActive", SupplierDTO.IsActive);

                    if (!string.IsNullOrEmpty(SupplierDTO.Notes))
                    {
                        command.Parameters.AddWithValue("@Notes", SupplierDTO.IsActive);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);

                    }
                    command.Parameters.AddWithValue("@TotalRemainingDebt", SupplierDTO.TotalRemainingDebt);
                  


                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out SupplierID))
                    {

                    }
                    else
                    {
                        SupplierID = -1;
                    }


                }



            }

            return SupplierID;

        }

        public static bool IsPersonSupplier(int PersonID)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("[Suppliers].[SP_IsPersonSupplier]", connection))
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
        public static decimal GetAllSuppliersDebt()
        {

            decimal TotalDebt = 0;  
            string query = @"select FORMAT(SUM(TotalRemainingDebt),'0.##') SuppliersDebt from Suppliers";
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
        public static int CountSuppliersToday()
        {

            int Count = 0;
            string query = @"
select count(1) as CountSupplierToday from
(
 select  distinct   p.PurchaseID from PurchaseDetails pd join 
Purchases p on pd.PurchaseID=p.PurchaseID
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
                            Count = total;
                        }
                        else
                        {
                            Count = 0;
                        }
                    }
                    catch { return -1; }
                }
            }
            return Count;

        }
        public static int CountDebtSuppliers()
        {

            int TotalDebt = 0;
            string query = @"
select count(1) as	 CountDebt from Suppliers
where TotalRemainingDebt>0
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
        public static DataTable GetSuppliersMostSaled(int PageNumber, int PageSize)
        {
            string query = @" SELECT sp.[SupplierID], FullName=CONCAT_WS(' ',p.FirstName,p.SecondName,p.LastName),case when p.Phone is null then 'لا يوجد' else p.Phone end as Phone ,
	case when p.Address is null then 'لا يوجد' else p.Address end as Address,
	
	[IsActive],FORMAT( [TotalRemainingDebt],'0.##') as [TotalRemainingDebt]
    FROM [dbo].[Suppliers] s join People p on s.PersonID=p.PersonID
    join (
select SupplierID,sum(TotalAmount-DiscountAmount) as Total from Purchases	
group by SupplierID) sp on s.SupplierID=sp.SupplierID
order by sp.Total desc  
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
        public static DataTable GetSuppliersLowSaled(int PageNumber, int PageSize)
        {
            string query = @" SELECT sp.[SupplierID], FullName=CONCAT_WS(' ',p.FirstName,p.SecondName,p.LastName),case when p.Phone is null then 'لا يوجد' else p.Phone end as Phone ,
	case when p.Address is null then 'لا يوجد' else p.Address end as Address,
	
	[IsActive],FORMAT( [TotalRemainingDebt],'0.##') as [TotalRemainingDebt]
    FROM [dbo].[Suppliers] s join People p on s.PersonID=p.PersonID
    join (
select SupplierID,sum(TotalAmount-DiscountAmount) as Total from Purchases	
group by SupplierID) sp on s.SupplierID=sp.SupplierID
order by sp.Total asc  
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
