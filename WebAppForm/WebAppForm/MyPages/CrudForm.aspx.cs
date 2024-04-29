using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppForm.MyPages
{
    public partial class CrudForm : System.Web.UI.Page
    {
        private DataAccess da = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            var dt = da.ExecuteQueryTable(sql);
            grid.DataSource = dt;
            grid.DataBind();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var sql = "insert into UserInfo values('" + txtID.Text + "','" + this.txtName.Text + "','" + this.txtPassword.Text + "','" + this.txtRole.Text + "');";
            var c = da.ExecuteDMLQuery(sql);

            this.PopulateGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var query = "select * from UserInfo where Name like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(query);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var i = grid.SelectedRow.Cells[1].Text;
            //Response.Write("this" + i);
            
            var query = "delete from UserInfo where Id = '" + i + "';";
            this.da.ExecuteDMLQuery(query);

            this.PopulateGridView();
        }
    }
}

//up to delete is completed here, try update by yourself.