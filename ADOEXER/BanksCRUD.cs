using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ADOEXER
{
    public class BanksCRUD
    {
        string constr;

        public BanksCRUD()
        {
            constr = ConfigurationManager.ConnectionStrings["FINTECH_DB"].ConnectionString;  
        }

        public List<Banks> getAll()
        {
            List<Banks> list = new List<Banks>();

            using (var conn = new SqlConnection(constr))
            {
                conn.Open();
                string query = "select*from Banks"; 
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Banks b = null;
                while (reader.Read())
                {
                    b = new Banks(reader);
                    list.Add(b);
                }
                conn.Close();
            }
            return list;
        }

        public List<Banks> GetSemua()
        {
            List<Banks> list = new List<Banks>();

            var conn =new  SqlConnection(constr);
            conn.Open();
            string query = "Select*from Banks";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Banks b = null;
            while (reader.Read())
            {
                b = new Banks(reader);
                list.Add(b);
            }
            conn.Close();
            return list;
        }

        public List<Banks> getByAccountID(int aid)
        {
            List<Banks> list = new List<Banks>();
            using (var conn=new SqlConnection(constr))
            {
                conn.Open();
                string query = "SELECT * FROM BANKS where AccountID=@0";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@0",aid);
                SqlDataReader reader = cmd.ExecuteReader();
                Banks b= null;

                while (reader.Read())
                {
                    b = new Banks(reader);
                    list.Add(b);
                }
                conn.Close();
            }
            return list;
        }
    }
}
