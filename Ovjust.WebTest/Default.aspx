<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ovjust.WebTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  mysql  host    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
  mysql port      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
   connStr     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
   insert Result     <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Rows="6"></asp:TextBox><br />
     get first   <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
    </div>
    </form>
</body>
</html>
