<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegistroClientes.aspx.vb" Inherits="WebAppYTCRUD.RegistroClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 65%;
            height: 422px;
        }
        .auto-style2 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            height: 21px;
            text-align: center;
            background-color: #66CCFF;
        }
        .auto-style3 {
            height: 23px;
            width: 248px;
            background-color: #66CCFF;
        }
        .auto-style4 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            height: 23px;
            width: 513px;
            text-align: center;
            background-color: #66CCFF;
        }
        .auto-style5 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            width: 513px;
            text-align: center;
            background-color: #66CCFF;
        }
        .auto-style6 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            width: 513px;
            height: 158px;
            text-align: center;
            background-color: #66CCFF;
        }
        .auto-style7 {
            height: 158px;
            width: 248px;
            background-color: #66CCFF;
        }
        .auto-style8 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            width: 513px;
            height: 40px;
            text-align: center;
            background-color: #66CCFF;
        }
        .auto-style9 {
            height: 40px;
            width: 248px;
            background-color: #66CCFF;
        }
        .auto-style10 {
            width: 248px;
            background-color: #66CCFF;
        }
        .auto-style11 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            height: 158px;
            background-color: #66CCFF;
        }
        .auto-style12 {
            width: 248px;
            background-color: #66CCFF;
            text-align: center;
        }

        body {

            background-color:azure;


        }


    </style>


 

</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>REGISTRO DE CLIENTES</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">ID CLIENTE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXT_IDCLIENTE" runat="server" Width="163px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">NOMBRE COMPLETO</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TXT_NOMBRE" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">SEXO</td>
                <td class="auto-style12">
                    <strong>
                    <asp:ListBox ID="LIST_SEXO" runat="server" Height="24px" Width="275px">
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Femenino</asp:ListItem>
                        <asp:ListItem>Otro</asp:ListItem>
                    </asp:ListBox>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">EDAD</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TXT_EDAD" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">OBSERVACIONES</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TXT_OBSERVACIONES" runat="server" Height="123px" Width="268px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" colspan="2">
                    <asp:Button ID="BTN_GUARDAR" runat="server" Height="66px" Text="GUARDAR" Width="129px" />
                    <asp:Button ID="BTN_MODIFICAR" runat="server" Height="65px" Text="MODIFICAR" Width="127px" />
                    <asp:Button ID="BTN_ELIMINAR" runat="server" Height="65px" Text="ELIMINAR" Width="155px" />
                    <asp:Button ID="BTN_BUSCAR" runat="server" Height="64px" Text="BUSCAR" Width="155px" />
                    <asp:Button ID="BTN_LIMPIAR" runat="server" Height="64px" Text="LIMPIAR" Width="155px" />
                    <asp:Label ID="BLL_RESPUESTA" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
