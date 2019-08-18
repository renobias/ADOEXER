using EFEXER.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEXER.Context
{
    public class FintechContext : DbContext
    {
        public FintechContext() : base("FINTECH_DB") { }
        public virtual DbSet<Banks> Banks { get; set; }
    }
}
