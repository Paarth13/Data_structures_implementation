using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseAccess
{
    public class Db
    {
        public SqlConnection NewConnection()
        {
            SqlConnection conn = new SqlConnection(
             "Data Source=TAVDESK015;Initial Catalog=Banking;Integrated Security=true");
            return conn;
        }


        public void ExecutionDisplay()
        {
            SqlConnection conn=NewConnection();


            SqlDataReader output = null;
            try
            {

                conn.Open();

                
                SqlCommand cmd = new SqlCommand("select * from Account_Info", conn);

                output = cmd.ExecuteReader();

                
                while (output.Read())
                {
                    Console.WriteLine("Clientid:" + output.GetValue(0));
                    Console.WriteLine("Clientname:" + output.GetValue(1));
                    Console.WriteLine("accountType:" + output.GetValue(2));
                    Console.WriteLine("Balance:" + output.GetValue(3));
                    Console.WriteLine();
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


        public void ExecutionDeposit(int Id,int balance)
        {
            SqlConnection conn = NewConnection();

            
            try
            {

                conn.Open();
          
                string Query = "update Account_Info set Balance=Balance+" + balance + " where Id=" + Id;

                SqlCommand cmd = new SqlCommand(Query, conn);

                cmd.ExecuteNonQuery();
                
            }

            finally
            {
                

                if (conn != null)
                {
                    conn.Close();
                }

            }

        }


        public void ExecutionWithdrawl(int Id, int balance)
        {
            SqlConnection conn = NewConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Account_Info" + " where Id=" + Id, conn);
                string s1=null;
                SqlDataReader output = cmd.ExecuteReader();
                while (output.Read())
                {
                     s1 = output[2].ToString();
                }
                int flag = 0;
                if (output.Read())
                {
                    if (s1.Equals("Savings") && (int)output.GetValue(3)-balance < 1000)
                        flag = 0;
                    else if (s1.Equals("Current") && (int)output.GetValue(3) - balance < 0)
                        flag = 0;
                    else if (s1.Equals("DMAT") && (int)output.GetValue(3) - balance < -10000)
                        flag = 0;
                    else
                        flag = 1;
                    output.Close();  
                }

                if (flag == 0)
                {
                    Console.WriteLine("Balance Insufficient");
                }

                else
                {
                    string Query = "update Account_Info set Balance=Balance-" + balance + " where id=" + Id;

                    cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            finally
            {

               

                if (conn != null)
                {
                    conn.Close();
                }

            }

        }
        public void ExecutionEntry(string name, int id, string AccountType,int balance)
        {
            SqlConnection conn = NewConnection();
            string Query = "Insert into Account_Info values(" + id + ",' " + name + " ',' " + AccountType + " ', " + balance + ")";
            SqlDataReader output = null;
            try
            {

                conn.Open();

                
                SqlCommand cmd = new SqlCommand(Query,conn);

                output = cmd.ExecuteReader();

               
               
            }
            finally
            {
                
                if (output != null)
                {
                    output.Close();
                }

                
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }

        public void SimpleInterest(int Id)
        {
            SqlConnection conn = NewConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Account_Info" + " where Id=" + Id, conn);
            int bal=0 ;
            SqlDataReader output = cmd.ExecuteReader();
            while (output.Read())
            {
                bal = (int)output[3];
            }
            Console.WriteLine(bal*0.1);
        }
    }
}
