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
                url: "Default.aspx/alerta1",
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    //faz algo, caso tudo tenha dado certo
                },
                error: function () {
                    //faz algo, porque deu erro
                }
            })
        }

    </script>
</head>
<body style="background-color:lightgreen">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txbNome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Clique aqui" OnClick="Button1_Click" />
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
