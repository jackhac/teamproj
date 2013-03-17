using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public class MCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MCategory()
        {

        }

        public MCategory(int id2)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from [Main Category] where ID=" + id2, con);

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            this.Id = (int)rdr[0];
            this.Name = (string)rdr[1];
        }

    }
}