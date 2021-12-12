using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entites;
using System.Data.SqlClient;

namespace DataAccessLayer.Tables
{
    public class hotelinfos
    {
        public List<hotelinfo> Get()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "select * from HOTEL_INFO";
            SqlCommand cmd = new SqlCommand(query, con);

            List<hotelinfo> data = new List<hotelinfo>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hotelinfo temp = new hotelinfo();
                 temp.h1_t1 = reader.GetInt32(reader.GetOrdinal("h1_t1"));
                 temp.h1_t2 = reader.GetInt32(reader.GetOrdinal("h1_t2"));
                 temp.h1_t3 = reader.GetInt32(reader.GetOrdinal("h1_t3"));
                 temp.h2_t1 = reader.GetInt32(reader.GetOrdinal("h2_t1"));
                 temp.h2_t2 = reader.GetInt32(reader.GetOrdinal("h2_t2"));
                 temp.h2_t3 = reader.GetInt32(reader.GetOrdinal("h2_t3"));
                 temp.h3_t1 = reader.GetInt32(reader.GetOrdinal("h3_t1"));
                 temp.h3_t2 = reader.GetInt32(reader.GetOrdinal("h3_t2"));
                 temp.h3_t3 = reader.GetInt32(reader.GetOrdinal("h3_t3"));
                  
                  
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
