<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationAulaWebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AspNet</title>
    <script src="https://code.jquery.com/jquery-1.11.3.js"></script>
    <script type="text/javascript">

        function ajax1()
        {
            $.ajax({
                type: "POST",
                url: "Default.aspx/alerta1", //rota, dizendo onde está o recurso que queremos utilizar
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data)/*data = palavra reservada, para receber o retorno da classe*/ {
                    //faz algo, caso tudo tenha dado certo
                    alert(data.d);
                },
                error: function () {
                    //faz algo, porque deu erro
                    alert("Falha ao acessar o webservice!"); ss
                }
            });
        }

        function ajax2() {
            //var x = document.getElementById('textBox').value;

            $.ajax({
                type: "POST",
                url: "Default.aspx/alerta2",
                data: "{ valor: " + document.getElementById('textBox').value + "}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    document.getElementById("label").innerHTML = data.d;
                    //alert(data.d);
                },
                error: function () {
                    document.getElementById("label").innerHTML = "Erro!";
                    //alert("Erro!");
                }
            });
        }

    </script>
</head>
<body style="background-color:lightgreen">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="textBox" runat="server"></asp:TextBox>
            <br />
            <br />

            <input id="btnAjax1" type="button" value="Ajax 1" onclick="ajax1();" />
            <br />
            <br />

            <input id="btnAjax2" type="button" value="Ajax 2 - Dobro do valor" onclick="ajax2();" />
            <br />
            <br />

            
            <asp:Panel ID="Panel1" runat="server">
                <asp:Button ID="Button1" runat="server" Text="Clique aqui" OnClick="Button1_Click" />
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </asp:Panel>
            <br />
            <br />

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />

            <div id="minhaDIV" runat="server">

            </div>
            <br />
            <br />
            <asp:Button ID="btnAlert" runat="server" Text="Alerta1" OnClick="btnAlert_Click" />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>

        </div>
    </form>
</body>
</html>
