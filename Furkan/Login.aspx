<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Furkan.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<style type="text/css">
		#form1 {
			height: 280px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label2" runat="server" Text="For Students"></asp:Label>
&nbsp;
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" Width="211px" />
			<br />
			<br />
			<br />
			<br />
			<br />
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
			<br />
			<br />
			<br />
			<br />
			<asp:Label ID="Label1" runat="server" Text="For Teachers"></asp:Label>
&nbsp;
			<asp:Button ID="Button2" runat="server" Text="Click" Width="211px" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
