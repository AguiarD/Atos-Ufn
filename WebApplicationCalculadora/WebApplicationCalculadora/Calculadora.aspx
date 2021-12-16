<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WebApplicationCalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblVl1" runat="server" Text="Valor 1"></asp:Label>
            <asp:TextBox ID="txbVl1" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="lblVl2" runat="server" Text="Valor 2"></asp:Label>
            <asp:TextBox ID="txbVl2" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:RadioButton ID="rdoSomar" runat="server" Text="Somar" GroupName="rdoOperacao" checked="true"/> <br />
            <asp:RadioButton ID="rdoSubtrair" runat="server" Text="Subtrair" GroupName="rdoOperacao" />
            <br />
            <br />

            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="Button1_Click" />
            <br />
            <br />

            <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
