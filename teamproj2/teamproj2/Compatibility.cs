using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public class Compatibility
    {
        public int Id { get; set; }
        public int Item1Id { get; set; }
        public int Item2Id { get; set; }
        public bool isThere { get; set; }
        public bool isMain { get; set; }

        public Compatibility(int item1, int item2)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Compatibility", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            this.isThere = false;
            while(rdr.Read())
            {
                this.Id = (int)rdr[0];
                this.Item1Id = (int)rdr[1];
                this.Item2Id = (int)rdr[2];

                if (((item1 == this.Item1Id) && (item2 == this.Item2Id)) || ((item2 == this.Item1Id) && (item1 == this.Item2Id)))
                {
                    this.isThere = true;
                }
            }

            if (item1 == item2)
            {
                this.isMain = true;
            }
            con.Close();
        }
        

        public string htmlButton()
        {
            if (this.isThere == true)
            {
                return "<a class='btn btn-success'>YES</a>";
            }
            else if (this.isMain == true)
            {
                return "<a class='btn btn-info'>MAIN</a>";
            }
            else
            {
                return "<a class='btn btn-danger'>NO</a>";
            }

        }
    }
}