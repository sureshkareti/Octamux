using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Rams
{
    public partial class Rams : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlParameter pr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            TextBox1.Focus();
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            string q = "insert into Rams values(@p1,@p2)";
            cmd = new SqlCommand(q, con);
            pr = new SqlParameter();
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            con.Open();
            int i= cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("Inserted");
        }
    }
}