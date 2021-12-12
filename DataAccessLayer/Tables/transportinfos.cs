using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entites;
using System.Data.SqlClient;

namespace DataAccessLayer.Tables
{
    public class transportinfos
    {

        public List<transportinfo> Get()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\tour-guide-C-sharp\P_DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            //string query = "create or replace view as h TRANSPORT_INFO";
            string query = "select * from TRANSPORT_INFO";
            //create or replace view DEPT20 as  select employee_id, first_name as employee, department_id from employees where department_id=20
            SqlCommand cmd = new SqlCommand(query, con);

            List<transportinfo> data = new List<transportinfo>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                transportinfo temp = new transportinfo();
                temp.h_ac = reader.GetInt32(reader.GetOrdinal("h_ac"));
                temp.h_nac = reader.GetInt32(reader.GetOrdinal("h_nac"));
                temp.e_ac = reader.GetInt32(reader.GetOrdinal("e_ac"));
                temp.e_nac = reader.GetInt32(reader.GetOrdinal("e_nac"));
                temp.s_ac = reader.GetInt32(reader.GetOrdinal("s_ac"));
                temp.s_nac = reader.GetInt32(reader.GetOrdinal("s_nac"));

                data.Add(temp);
            }
            return data;
            
        }
        void insert()
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "INSERT INTO VALUES('" + textBox101.Text + "','" + textBox102.Text + "','" + textBox103.Text + "','"+ textBox104.Text+"','"+ textBox105.Text+"','"+ textBox106.Text)";
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
        void delete()
        {
        }
        void update()
        {
        }
    }
}
