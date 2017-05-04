<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WcfService4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:GridView ID="grvProduct" runat="server"></asp:GridView>
        <asp:Button ID="btnLoad" runat="server" Text="Load Data" OnClick="btnLoad_Click"/>
    </div>
    </form>
</body>
</html>
