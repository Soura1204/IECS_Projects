using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;


namespace Registration_Form
{
    public partial class Candidate_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }

            /*if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("First Name");
                dt.Columns.Add("Last Name");
                dt.Columns.Add("Address");
                dt.Columns.Add("DOB");
                dt.Columns.Add("Mobile Number");
                dt.Columns.Add("Email");

                ViewState["RegistrationData"] = dt;
            }*/
        }
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS02;Initial Catalog=registration;User ID=sa;Password=123456;Encrypt=False");

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO candidate_registration values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtAddress.Text + "','" + txtDOB.Text + "','" + txtEmail.Text + "','" + txtMobile.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            LoadRecord();


            /* DataTable dt = ViewState["RegistrationData"] as DataTable;

             // Add new row
             dt.Rows.Add(
                 txtFirstName.Text,
                 txtLastName.Text,
                 txtAddress.Text,
                 txtDOB.Text,
                 txtMobile.Text,
                 txtEmail.Text
             );

             // Update ViewState and GridView
             ViewState["RegistrationData"] = dt;
             GridView1.DataSource = dt;
             GridView1.DataBind();

             // Optional: Clear fields
             txtFirstName.Text = txtLastName.Text = txtAddress.Text = txtDOB.Text = txtMobile.Text = txtEmail.Text = "";*/
        }


            void LoadRecord()
            {
                SqlCommand cd = new SqlCommand("Select * from candidate_registration", con);
                SqlDataAdapter d = new SqlDataAdapter(cd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }

        protected void btnsubmit1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update candidate_registration set fname = '"+txtFirstName.Text+"',lname = '"+txtLastName.Text+ "',address = '"+txtAddress.Text+"',dob = '"+txtDOB.Text+"',mobnum = '"+txtMobile.Text+"' where email = '"+txtEmail.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();
        }

        protected void btnsubmit2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete candidate_registration where email = '" + txtEmail.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            LoadRecord();
        }

        protected void btnsubmit3_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("Select * from candidate_registration where email = '" + txtEmail.Text + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(cd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnsubmit4_Click(object sender, EventArgs e)
        {
            string dob = Request.QueryString["dob"];


            con.Open();
            SqlCommand cd = new SqlCommand("Select * from candidate_registration where email = '" + txtEmail.Text + "'", con);
            SqlDataReader r = cd.ExecuteReader();
            while (r.Read())
            {
                txtFirstName.Text=r.GetValue(0).ToString();
                txtLastName.Text = r.GetValue(1).ToString();
                txtAddress.Text = r.GetValue(2).ToString();
                txtDOB.Text = Convert.ToDateTime(r.GetValue(3)).ToString("dd/MM/yyyy");
                txtMobile.Text = r.GetValue(5).ToString();
            }
        }
    }
}