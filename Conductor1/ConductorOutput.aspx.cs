using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.Conductor
{
    public partial class ConductorOutput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fromloc = Session["FromLocation"].ToString();
            string toLoc = Session["ToLocation"].ToString();
            string pstatus = Session["PaymentStatus"].ToString();

            lblFrom.Text = fromloc;
            lblTo.Text = toLoc;
            lblPaymentStatus.Text = pstatus;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}