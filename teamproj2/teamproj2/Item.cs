using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace teamproj2
{
    public class Item
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Quant { get; set; }

        public Item()
        {
         
        }
        public Item(int id2)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Items where ID="+id2, con);

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            
            this.Id=(int)rdr[0];
            this.Name = (string)rdr[1];
            this.Desc = (string)rdr[2];
            this.Price = (decimal)rdr[3];
            con.Close();
        }
    }
}