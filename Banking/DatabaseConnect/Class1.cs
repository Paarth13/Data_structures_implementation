using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseConnect
{
    class Class1
    {
        public SqlConnection NewConnection()
        {
            SqlConnection conn = new SqlConnection(
             "Data Source=TAVDESK015;Initial Catalog=Banking;Integrated Security=true");
            return conn;
        }


        public void Execution_display(SqlConnection conn)
        {
            SqlDataReader output=null ;
            try
            {

                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("select * from Account_Info", conn);

                //
                // 4. Use the connection
                //

                // get query results
                output = cmd.ExecuteReader();

                // print the CustomerID of each record
                while (output.Read())
                {
                    Console.WriteLine(output[0]);
                }
            }
            finally
            {
                // close the reader
                if (output != null)
                {
                    output.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }



        public void Execution_Entry(SqlConnection conn)
        {
            SqlDataReader output = null;
            try
            {

                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("insert into Account_Info {0}", conn);

                //
                // 4. Use the connection
                //

                // get query results
                output = cmd.ExecuteReader();

                // print the CustomerID of each record
                while (output.Read())
                {
                    Console.WriteLine(output[0]);
                }
            }
            finally
            {
                // close the reader
                if (output != null)
                {
                    output.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }
    }
}
