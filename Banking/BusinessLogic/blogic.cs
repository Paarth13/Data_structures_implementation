using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseAccess;
namespace BusinessLogic
{
  public  class blogic {
       
        public Db DataVal = new Db();
        public void DataEntry(string name,int id,string AccountType,int balance)
        {
            
            DataVal.ExecutionEntry(name, ++id, AccountType,balance);

        }

        public void Display()
        {
            DataVal.ExecutionDisplay();
        }

        public void Deposit(int id,int balance)
        {
            DataVal.ExecutionDeposit(id ,balance);
        }

        public void Withdrawl(int id, int balance)
        {
            DataVal.ExecutionWithdrawl(id, balance);
        }

        public void Simple(int id)
        {
            DataVal.SimpleInterest(id);
        }
    }
}
