using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public class SCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SCategory()
        {

        }

        public SCategory(int id2,int id3)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd;
            if (id2 == 1)
            {
                cmd = new SqlCommand("select * from [Computer SubCategory] where ID=" + id3, con);
            }
            else if (id2 == 2)
            {
                cmd = new SqlCommand("select * from [Computer Parts SubCategory] where ID=" + id3, con);
            }
            else if (id2 == 3)
            {
                cmd = new SqlCommand("select * from [Video Games SubCategory] where ID=" + id3, con);
            }
            else
            {
                cmd = new SqlCommand("select * from [Computer SubCategory] where ID=" + id3, con);
            }

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            this.Id = (int)rdr[0];
            this.Name = (string)rdr[1];
            con.Close();
        }
    }
}