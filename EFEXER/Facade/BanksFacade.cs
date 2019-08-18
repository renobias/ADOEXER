using EFEXER.Context;
using EFEXER.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Data.Entity;

namespace EFEXER.Facade
{
    public class BanksFacade
    {
        public Banks GetByID(int id)
        {
            var context = new FintechContext();
            return context.Banks.FirstOrDefault(c=>c.BankID.Equals(id));
        }

        public List<Banks> GetAll()
        {
            var context = new FintechContext();
            return context.Banks.ToList();
        }

    }
}
