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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = userDataSet();
            Repeater1.DataBind();
        }

        private DataSet userDataSet()
        {
            string sql = @"SELECT StaffAvatar,
            StaffID,
            JobNum,
            StaffName,
            Sex,
            Age,
            Mobile,    
            Pwd,
            Province,
            City,
            District,
            Address
                FROM Info_Staff
            WHERE IsDelete = 0";
            return SqlTools.SqlDataSet(sql);
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string UserID = ((HiddenField)e.Item.FindControl("HiddenField1")).Value;
            if (e.CommandName =="change")
            {
                Response.Redirect("User.aspx?userID="+UserID);
            }
        }
    }
}