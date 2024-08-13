using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContact_Click(object sender, EventArgs e)
        {

        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {

        }

        protected void btnFeedback_Click(object sender, EventArgs e)
        {

        }

        protected void btnExample_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.indiacustomercare.com/pune-mahanaga-parivahan-mahamandal-pmpml-no-020-24-54-54-54");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //string fromLocation = txtFromLocation.Text;
            //string toLocation = txtToLocation.Text;
            //string aadharNumber = txtAadharNumber.Text;
            //int noOfTraveler = int.Parse(txtNoOfTraveler.Text);

            //string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    string query = @"
            //    SELECT 
            //        b.BusNumber,
            //        b.FromLocation,
            //        b.ToLocation,
            //        b.TravelTime,
            //        b.TicketPrice,
            //        @NoOfTraveler * b.TicketPrice AS TotalPrice
            //    FROM 
            //        Busses b
            //    WHERE 
            //        b.FromLocation = @FromLocation
            //        AND b.ToLocation = @ToLocation
            //        AND EXISTS (
            //            SELECT 1
            //            FROM aadharRegister ar
            //            WHERE ar.AadharNumber = @AadharNumber
            //        );";

            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@FromLocation", fromLocation);
            //    cmd.Parameters.AddWithValue("@ToLocation", toLocation);
            //    cmd.Parameters.AddWithValue("@AadharNumber", aadharNumber);
            //    cmd.Parameters.AddWithValue("@NoOfTraveler", noOfTraveler);

            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    gvResults.DataSource = dt;
            //    gvResults.DataBind();
            //}

        }
    }
}