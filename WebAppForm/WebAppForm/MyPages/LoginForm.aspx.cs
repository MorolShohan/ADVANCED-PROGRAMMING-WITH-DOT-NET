using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppForm.MyPages
{
    public partial class LoginForm : System.Web.UI.Page
    {
        private DataAccess da = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where Id = '"+this.txtID.Text+"' and Password = '"+this.txtPassword.Text+"';";
            var ds = da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                if (ds.Tables[0].Rows[0][3].ToString() == "admin")
                { 
                }

                //Response.Redirect("CrudForm.aspx");
            }
            else
            {

            }
        }
    }
}