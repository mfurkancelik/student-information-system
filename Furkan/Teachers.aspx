<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teachers.aspx.cs" Inherits="Furkan.Teachers1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Student&nbsp; Number :<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
			<br />
			<br />
			Midterm :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
			<br />
			<br />
			Final :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
			<br />
			<br />
			Course Number :&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
			<br />
			<br />
			Status :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<br />
			<br />
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="267px" />
        </div>
    </form>
</body>
</html>
