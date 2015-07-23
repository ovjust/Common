<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFile1.aspx.cs" Inherits="Ovjust.WebTest.AddFile1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    newFileName<asp:TextBox ID="TextBox1" runat="server" Rows="7" TextMode="MultiLine"></asp:TextBox>

         readFile<asp:TextBox ID="TextBox2" runat="server" Rows="7" TextMode="MultiLine"></asp:TextBox><br />

           DataFolder<asp:TextBox ID="TextBox3" runat="server" Rows="7" TextMode="MultiLine"></asp:TextBox>
    </div>
    </form>
</body>
</html>
