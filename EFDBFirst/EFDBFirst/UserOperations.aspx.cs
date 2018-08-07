using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFDBFirst
{
    public partial class UserOperations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassigooEntities1 db = new ClassigooEntities1();
            User user1 = new User();
            user1.MobleNumber = TextBox1.Text;
            user1.Name = TextBox2.Text;
            db.Users.Add(user1);
            db.SaveChanges();

            User user2 = new User();
            user2.MobleNumber = TextBox1.Text;
            user2.Name = TextBox2.Text;
            db.Users.Add(user2);
            db.SaveChanges();

            User user = db.Users.First(u => u.UserId == 1);
            db.Users.Remove(user);
        }
    }
}