using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOEXER
{
    public class Banks
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string HeadOffice { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public int AccountID { get; set; }
        public Banks() { }

        public Banks(
            int Bid,
            string BName,
            string HOffice,
            string CName,
            string CPhone,
            string CEmail,
            int AId)
        {
            BankID = Bid;
            BankName = BName;
            HeadOffice = HOffice;
            ContactName = CName;
            ContactPhone = CPhone;
            ContactEmail = CEmail;
            AccountID = AId;
        }

        public Banks(SqlDataReader reader)
        {
            BankID = reader.GetInt32(0);
            BankName = reader.GetString(1);
            HeadOffice = reader.GetString(2);
            ContactName = reader.GetString(3);
            ContactPhone = reader.GetString(4);
            ContactEmail = reader.GetString(5);
            AccountID = reader.GetInt32(6);
        }

    }
}
