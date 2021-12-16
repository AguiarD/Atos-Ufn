<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="CalculadoraAjax.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora Ajax</title>
    <script src="https://code.jquery.com/jquery-1.11.3.js"></script>
    <script  type="text/javascript">
        function ajax() {
            var vl1 = txbVl1.value;
            var vl2 = txbVl2.value;
            //var vl1 = txbVl1.value;
            //alert(txbVl1.value + " " + txbVl2.value);

            $.ajax({
                type: "POST",
                url: "Calculadora.aspx/operacao",
                data: "{ vl1:" + vl1 + ", vl2:" + vl2 + "}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    document.getElementById("lblResultado").innerHTML = data.d;
                    //alert(data.d);
                },
                error: function () {
                    document.getElementById("lblResultado").innerHTML = "Erro!";
                    //alert(data.d);
                }
            })
            //alert(vl1 + " : " + vl2);
        }
    </script>
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

            <%--<asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="Button1_Click" />
            <br />
            <br />--%>

            <input id="btnCalcularAjax" type="button" value="CalcularAjax" onclick="ajax();" />
            <br />
            <br />

            <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
