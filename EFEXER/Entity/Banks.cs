using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEXER.Entity
{
    [Serializable]
    public class Banks
    {
        [Key]
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string HeadOffice { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public int AccountID { get; set; }
    }
}
