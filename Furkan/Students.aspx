<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Furkan.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 246px">
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:Label ID="Label1" runat="server" Text="Student Number :"></asp:Label>
		<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
		<br />
		<br />
		<br />
		<asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		<br />
		<br />
		<br />
		<br />
		<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" Width="227px" />
    </form>
</body>
</html>
