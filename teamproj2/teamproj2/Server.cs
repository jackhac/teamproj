using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public class Server
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Quant { get; set; }
        public decimal Total { get; set; }
        public string Picture { get; set; }
        public int MCategory { get; set; }
        public string MCategory2 { get; set; }
        public int SCategory { get; set; }
        public string SCategory2 { get; set; }

        public Server(int id2)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Items where [Main Category]=1 and [Sub Category]=3" , con);

            SqlDataReader rdr = cmd.ExecuteReader();
            for (int i = 0; i < id2; i++)
            {
                rdr.Read();
            }
            
            this.Id=(int)rdr[0];
            this.Name = (string)rdr[1];
            this.Desc = (string)rdr[2];
            this.Price = (decimal)rdr[3];
            this.Total = (decimal)rdr[3];
            this.Picture = (string)rdr[4];
            this.MCategory = (int)rdr[5];
            this.SCategory = (int)rdr[6];
            this.Quant = 1;
            con.Close();

            MCategory mc = new MCategory(this.MCategory);
            this.MCategory2 = mc.Name;

            SCategory sc = new SCategory(this.MCategory, this.SCategory);
            this.SCategory2 = sc.Name;
        }
    }
}