<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="Ulatina.PrograAvanzada.AplicacionWeb.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			height: 155px;
		}
		.auto-style2 {
			height: 901px;
		}

table.MsoTableGrid
	{border:solid windowtext 1.0pt;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
 p.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:0in;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
		</style>
</head>
<body>
    <form id="frmCalentamiento" runat="server" title="Forma de prueba temporal" class="auto-style2">
        <div title="Hello world" class="auto-style1">
            <br />
            Parámetros de entrada:<br />
            <br />
            <br />
            Radio<asp:TextBox ID="txtRadioCilindro" runat="server"></asp:TextBox>
			Altura<asp:TextBox ID="txtAlturaCilindro" runat="server"></asp:TextBox>
			<asp:Button ID="btnCalcularCilindro" runat="server" Text="Calcular" />
			Resultado<asp:TextBox ID="txtResultadoCilindro" runat="server" Width="128px"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
        <asp:TextBox ID="Operando1" runat="server"></asp:TextBox>
        <asp:TextBox ID="Operando2" runat="server"></asp:TextBox>
        <asp:Button ID="btnSumar" runat="server" OnClick="btnSumar_Click" Text="Sume" />
        <asp:Label ID="Resultado" runat="server"></asp:Label>
    	<br />
		<br />
		<br />
		<br />
    </form>
</body>
</html>
