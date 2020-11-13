<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserListInfo.aspx.cs" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        tr,td {
            border: 1px red dashed;
            text-align: center;
            
        }
        table {
            border-collapse: collapse;
            border: 1px red solid;
        }
        img {
            width: 50px;
            margin: 3px;
            
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
            <HeaderTemplate>
                <table>
                <tr>
                    <td>头像</td>
                    <td>工号</td>
                    <td>名字</td>
                    <td>性别</td>
                    <td>年龄</td>
                    <td>手机号</td>
                    <td>密码</td>
                    <td>省</td>
                    <td>市</td>
                    <td>区</td>
                    <td>详细地址</td>
                    <td></td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <img src="<%#Eval("StaffAvatar") %>"/>
                    </td>
                    <td><%#Eval("JobNum") %></td>
                    <td><%#Eval("StaffName") %></td>
                    <td><%#Eval("Sex") %></td>
                    <td><%#Eval("Age") %></td>
                    <td><%#Eval("Mobile") %></td>
                    <td><%#Eval("Pwd") %></td>
                    <td><%#Eval("Province") %></td>
                    <td><%#Eval("City") %></td>
                    <td><%#Eval("District") %></td>
                    <td><%#Eval("Address") %></td>
                    <asp:HiddenField runat="server" ID="HiddenField1" Value='<%#Eval("StaffID") %>'/>
                    <td>
                        <asp:LinkButton ID="change" CommandName="change" runat="server">修改</asp:LinkButton>
                    </td>

                </tr>

            </ItemTemplate>


            <FooterTemplate>
            </table>
            </FooterTemplate>
        </asp:Repeater>

    </div>
</form>
</body>
</html>