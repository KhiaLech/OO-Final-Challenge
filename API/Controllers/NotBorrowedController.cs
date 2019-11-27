using API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class NotBorrowedController : ApiController
    {
        // GET: Api/NotBorrowed

        public IEnumerable<NotBorrowed> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            string query;
            List<NotBorrowed> output = new List<NotBorrowed>();


            try
            {
                conn.Open();

                query = "SELECT ISBN, Title from Books WHERE borrower IS NULL;";

                cmd = new SqlCommand(query, conn);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output.Add(new NotBorrowed(Int32.Parse(rdr.GetValue(0).ToString()),
                        rdr.GetValue(1).ToString()));
                        
                        





                }

            }

            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return output;

        }


    }
}
