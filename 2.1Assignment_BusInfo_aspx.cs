using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Assignment_2webform
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //Connection establishment;

            SqlConnection con = new SqlConnection("data source =DESKTOP-CRP7TDE ; database =Assignment_ADO; integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select BoardingPoint,TravelDate from BusInfo where Amount > 450.00;select BusId,BoardingPoint from BusInfo where TravelDate ='2017-12-10'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            // Executing the SQL query  
            GridView1.DataSource = rdr;
            GridView1.DataBind();

            while (rdr.NextResult())
            {
                GridView2.DataSource = rdr;
                GridView2.DataBind();
            }
            //Closing connection;
            con.Close();

        }
    }
}
       
