using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
          string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf";
        SqlConnection con = new SqlConnection(conn );
        con.Open();

        SqlCommand cmd = new SqlCommand("select * from Customers", con);

        //
        // 4. Use the connection
        //

        // get query results
        SqlDataReader rdr = cmd.ExecuteReader();

        // print the CustomerID of each record
        while (rdr.Read())
        {
            Console.WriteLine(rdr[0]);
        }

           con.Close();

            
        }

    }
}
