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
    public class clsPartnerTransactionData
    {
        public static int AddPartnerTransaction(clsPartnerTransactionDTO partnerTransactionDTO)
        {

            partnerTransactionDTO.PartnerTransactionID = -1;



            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("PartnerTransactions.SP_AddPartnerTransaction", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Pass Input Parameters directly from the DTO properties
                    command.Parameters.AddWithValue("@PartnerID", partnerTransactionDTO.PartnerID);
                    command.Parameters.AddWithValue("@TransactionType", partnerTransactionDTO.TransactionType);
                    command.Parameters.AddWithValue("@Amount", partnerTransactionDTO.Amount);
                    command.Parameters.AddWithValue("@Notes", partnerTransactionDTO.Notes);


                    // Setup the OUTPUT Parameter to capture the new identity
                    SqlParameter outputIdParameter = new SqlParameter();
                    outputIdParameter.ParameterName = "@PartnerTransactionID";
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
                            partnerTransactionDTO.PartnerTransactionID = (int)outputIdParameter.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log your exception here
                        partnerTransactionDTO.PartnerTransactionID = -1;
                    }
                }
            }

            return partnerTransactionDTO.PartnerTransactionID;






        }

        public static DataTable GetAllPartnerTransactions(int PageNumber, int PageSize)
        {
            string query = @" SELECT   [PartnerTransactionID]
      ,pe.FirstName +' '+pe.LastName as FullName
      , case [TransactionType] when 1 then 'سحب' when 2 then 
	  'ايداع' when 3 then 'ربح' else 'مصروف' end as [TransactionType]
      ,Format([Amount],'0.##') as Amount
      ,t.[CreatedDate]
      ,ISNULL( [Notes],'لا يوجد') AS Notes
  FROM [AccountantDB].[dbo].[PartnerTransactions] t 
  join Partners p on t.PartnerID=p.PartnerID join People pe on
  pe.PersonID=p.PersonID
  order by t.CreatedDate desc

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
