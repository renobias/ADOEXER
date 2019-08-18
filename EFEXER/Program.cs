using EFEXER.Entity;
using EFEXER.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEXER
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bankfacade = new BanksFacade();
            var bankData = bankfacade.GetByID(100);
            Console.WriteLine("{0,50}","Get By ID BANKS\n");
            Console.Write("{0} | {1} | {2} | {3} | {4} | {5} | {6}",bankData.BankID,bankData.BankName,bankData.ContactEmail,bankData.ContactName,bankData.ContactPhone, bankData.HeadOffice,bankData.AccountID);
            Console.WriteLine();

            var bankdataAll = bankfacade.GetAll();
            foreach (var bAll in bankdataAll)
            {
                Console.WriteLine(bAll.BankID);
            }

            string data = "anjing.pdf";
            // Split string on spaces (this will separate all the words).
            string words = data.Split('.')[0];

                Console.WriteLine(words);
       

            Console.ReadKey();
        }
    }
}
