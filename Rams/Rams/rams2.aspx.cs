using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Linq;

namespace Rams
{
    public partial class rams2 : System.Web.UI.Page
    {
     
        RamsDataContext cls = new RamsDataContext();
        Ram db = new Ram();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            db.id = int.Parse(TextBox1.Text);
            db.Name = TextBox2.Text;
            cls.Rams.InsertOnSubmit(db);
            cls.SubmitChanges();
            Response.Write("inserted");
            
        }
    }
}