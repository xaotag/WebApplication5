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
            string UserMobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
            if (!string.IsNullOrEmpty(UserMobile))
            {
                if (UserMobile=="18438570098")
                {
                    Response.Redirect("UserListInfo.aspx");
                }
                else
                {
                    Response.Redirect("OrderList.aspx");
                }
                Response.Write("<script>alert('账号或密码错误')<script>");
            }
            
            /*
             后面有用
            List<UserModel> userModel = new List<UserModel>();
            string Sql = "SELECT StaffID,Mobile,pwd FROM Info_Staff WHERE IsDelete =0;";
            DataSet ds = SqlTools.SqlDataSet(Sql);
            foreach (DataRow DataRow in ds.Tables[0].Rows)
            {
                UserModel m
                    odel = new UserModel();
                foreach (DataColumn column in ds.Tables[0].Columns)
               ，8  {
                    switch (column.ColumnName)
                    {
                        case "StaffID":
                            model.Guid1 = DataRow["Guid"].ToString(); break;
                        case "Mobile":
                            model.Mobile = DataRow["Mobile"].ToString(); break;
                        case "Pwd":
                            model.Pwd = DataRow["Pwd"].ToString(); break;
                    }
                    userModel.Add(model);
                }
            }
            */


        }
    }
}