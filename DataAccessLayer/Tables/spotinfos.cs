using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entites;
using System.Data.SqlClient;

namespace DataAccessLayer.Tables
{
    class spotinfos
    {
        public List<spotinfo> Get()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "select * from SPOT_INFO";
            SqlCommand cmd = new SqlCommand(query, con);

            List<spotinfo> data = new List<spotinfo>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spotinfo temp = new spotinfo();
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

        }
        void delete()
        {

        }
        void update()
        {

        }
    }
}
