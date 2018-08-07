using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entity1
{
    public partial class UserOperations : System.Web.UI.Page
    {
        MclassigoEntities db = new MclassigoEntities();
        UserTb user1 = new UserTb();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            user1.Name = txtname.Text;
            user1.Mobile = txtmobile.Text;
            db.UserTbs.Add(user1);
            db.SaveChanges();

        }

        protected void btnUdate_Click(object sender, EventArgs e)
        {
            UserTb user = db.UserTbs.First(s => s.Userid == 4);
            // db.UserTbs.Find(user[0]);

            user.Name = txtname.Text;
            user.Mobile = txtmobile.Text;
           // db.UserTbs.Add(user1);
            db.SaveChanges();

            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var id =ID;
            var user = db.UserTbs.Where(s => s.Userid == 4).ToList();
            db.UserTbs.Remove(user[0]);
            db.SaveChanges();
          //  var id = ID;
            //UserTb post = (from p in db.UserTbs
            //                 where p.Userid == id
            //                 select p).Single();
        }
    }
}