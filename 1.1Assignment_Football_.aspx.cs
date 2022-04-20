using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //Connection establishment;
        
            SqlConnection con = new SqlConnection("data source =DESKTOP-CRP7TDE ; database =Assignment_ADO; integrated Security = SSPI");
            SqlCommand cmd = new SqlCommand("select WinningTeam  from FootBall WHERE Status_ ='WIN';SELECT * FROM Football WHERE TeamName1 ='JAPAN' OR TeamName2 ='JAPAN';  ", con);
         
         //Reading and binding data;
           con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            
         //First Gridview of the table's content;
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            
         //Second Gridview of the table's content;
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
