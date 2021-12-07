using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entites;
using System.Data.SqlClient;

namespace DataAccessLayer.Tables
{
   public class admininfos
    {
        public List<admininfo> Get()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "select * from ADMIN_INFO";
            SqlCommand cmd = new SqlCommand(query, con);

            List<admininfo> data = new List<admininfo>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                admininfo temp = new  admininfo();
                /*  temp.id = reader.GetString(reader.GetOrdinal("User_id"));
                  temp.name = reader.GetString(reader.GetOrdinal("User_name"));
                  temp.email = reader.GetString(reader.GetOrdinal("User_mail"));
                  temp.pass = reader.GetString(reader.GetOrdinal("User_pass"));
                  temp.phone = reader.GetString(reader.GetOrdinal("User_phone"));
                  temp.gender = reader.GetString(reader.GetOrdinal("User_gender"));
                  */
                data.Add(temp);
            }
            return data;

        }
        void indert()
        {
            /*admininfo temp = new admininfo();
            temp.id = reader.GetString(reader.GetOrdinal("Admin_id"));
            temp.name = reader.GetString(reader.GetOrdinal("Admin_name"));
            temp.email = reader.GetString(reader.GetOrdinal("Admin_mail"));
            temp.pass = reader.GetString(reader.GetOrdinal("Admin_pass"));
            temp.phone = reader.GetString(reader.GetOrdinal("Admin_phone"));
            temp.gender = reader.GetString(reader.GetOrdinal("Admin_gender"));
            data.Add(temp);*/

        }
    }
}
