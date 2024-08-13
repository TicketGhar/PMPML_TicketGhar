using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            // Retrieve form values
            string name = txtName.Text;
            string mobile = txtMobile.Text;
            string aadhar = txtAadhar.Text;
            string email = txtEmail.Text;
            string gender = ddlGender.SelectedValue;
            string verificationCode = txtVerificationCode.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(mobile) ||
                string.IsNullOrWhiteSpace(aadhar) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(verificationCode))
            {
                Response.Write("<script>alert('All fields are required.');</script>");
                return;
            }

            // Validate email format
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    Response.Write("<script>alert('Invalid email format.');</script>");
                    return;
                }
            }
            catch
            {
                Response.Write("<script>alert('Invalid email format.');</script>");
                return;
            }

            // Connection string from Web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;

            // Insert data into database
            string query = "INSERT INTO Users (Name, Mobile, Aadhar, Email, Gender, VerificationCode) VALUES (@Name, @Mobile, @Aadhar, @Email, @Gender, @VerificationCode)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Mobile", mobile);
                        command.Parameters.AddWithValue("@Aadhar", aadhar);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@VerificationCode", verificationCode);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                Response.Write("<script>alert('Registration successful.');</script>");
            }
            catch (Exception ex)
            {
                // Log the exception and show an error message
                Response.Write("<script>alert('An error occurred: " + ex.Message + "');</script>");
            }
        }
    }
}