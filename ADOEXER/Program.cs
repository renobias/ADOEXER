using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOEXER
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BanksCRUD Bank = new BanksCRUD();

            /** SEMUA LIST BANK **/
            var semua = Bank.getAll();
            Console.WriteLine("\n");
            Console.WriteLine("{0,70}","-BANKS LIST-\n\n");
            Console.WriteLine("====================================================================================================================================================");
            Console.WriteLine("| {0,-13} | {1,-13} | {2,-30} | {3,-30} | {4,-30} | {5,-13} |","Bank ID","Bank Name","Contact Email","Contact Name","Contact Phone", "Account ID");
            Console.WriteLine("====================================================================================================================================================");
            foreach (Banks a in semua)
            {
                Console.WriteLine("| {0,-13} | {1,-13} | {2,-30} | {3,-30} | {4,-30} | {5,-13} |",a.BankID,a.BankName,a.ContactEmail,a.ContactName,a.ContactPhone, a.AccountID);
            }
            Console.WriteLine("====================================================================================================================================================");

            /** LIST BANK BY ID**/
            var bankbyaid = Bank.getByAccountID(10008);
            Console.WriteLine("\n");
            Console.WriteLine("{0,80}", "-BANKS LIST BY ID -\n\n");
            Console.WriteLine("==================================================================================================================================");
            Console.WriteLine("| {0,-13} | {1,-13} | {2,-13} | {3,-30} | {4,-30} | {5,-13} |", "Account ID", "Bank ID", "Bank Name", "Contact Email", "Contact Name", "Contact Phone");
            Console.WriteLine("==================================================================================================================================");
            foreach (Banks a in bankbyaid)
            {
                Console.WriteLine("| {0,-13} | {1,-13} | {2,-13} | {3,-30} | {4,-30} | {5,-13} |", a.AccountID, a.BankID, a.BankName, a.ContactEmail, a.ContactName, a.ContactPhone);
            }
            Console.WriteLine("==================================================================================================================================");
            Console.ReadKey();
        }
    }
}
