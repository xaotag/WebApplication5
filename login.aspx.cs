using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.Command;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long mobile = Convert.ToInt64(TextBox1.Text.Trim());
            string pwd = TextBox2.Text.Trim();
            string Sql = "SELECT StaffID,Mobile,pwd FROM Info_Staff WHERE Mobile =  N'" + mobile+ "' and Pwd = N'" + pwd + "' and IsDelete =0;";
            DataSet ds = SqlTools.SqlDataSet(Sql);
            if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["Mobile"].ToString().ToString()))
            {
                
            }

        }
    }
}