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
    public class SelectedBorrower : ApiController
    {
        // GET: Api/SelectedBorrower

        public IEnumerable<Borrower> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            string query;
            List<SelectedBorrower> output = new List<SelectedBorrower>();


            try
            {
                conn.Open();

                query = "select * from Borrower";

                cmd = new SqlCommand(query, conn);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output.Add(new SelectedBorrower(Int32.Parse(rdr.GetValue(0).ToString()),
                        rdr.GetValue(1).ToString(),
                        rdr.GetValue(2).ToString(),
                        rdr.GetValue(3).ToString(),
                            new Books(Int32.Parse(rdr.GetValue(0).ToString()),
                            rdr.GetValue(1).ToString(),
                            Int32.Parse(rdr.GetValue(2).ToString(),
                            Int32.Parse(rdr.GetValue(3).ToString())))));


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
