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
    public class BooksController : ApiController
    {
        // GET: api/Books
        public IEnumerable<BriefBook> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            string query;
            List<BriefBook> output = new List<BriefBook>();


            try
            {
                conn.Open();

                query = "select * from Books";
                cmd = new SqlCommand(query, conn);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    output.Add(new BriefBook(Int32.Parse(rdr.GetValue(0).ToString()),
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
