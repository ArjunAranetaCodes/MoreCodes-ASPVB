'Variables and Input


<form id="form1" runat="server">
<div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="Button" /><br/>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br/>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br/>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br/>
</div>
</form>

Public Class index
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Label1.Text = "Hello World"
 End Sub
End Class
