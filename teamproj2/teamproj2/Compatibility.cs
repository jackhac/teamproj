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

        public Compatibility(int item1, int item2)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Compatibility where Item1ID="+item1+" and Item2ID"+item2, con);
            SqlDataReader rdr = cmd.ExecuteReader();
           
            rdr.Read();
            
            this.Id = (int)rdr[0];
            this.Item1Id = (int)rdr[1];
            this.Item2Id = (int)rdr[2];

            if ((item1 == this.Item1Id) && (item2 == this.Item2Id))
            {
                this.isThere = true;
            }
            else
            {
                this.isThere = false;
            }

            con.Close();
        }

        public string htmlButton()
        {
            if (this.isThere == true)
            {
                return "<a class='btn btn-success'>YES</a>";
            }
            else
            {
                return "<a class='btn btn-danger'>NO</a>";
            }
        }
    }
}