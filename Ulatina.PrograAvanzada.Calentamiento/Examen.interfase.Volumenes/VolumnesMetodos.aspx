<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VolumnesMetodos.aspx.cs" Inherits="Examen.interfase.Volumenes.VolumnesMetodos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<p>
		&nbsp;</p>
<p>
	Pruebas de Volumenes Ingreso de Valores</p>
<p style="font-size: large">
            Parámetros de entrada:&nbsp;&nbsp;&nbsp;&nbsp; Volumen del Cilindro</p>
<p>
            <br />
            Radio<asp:TextBox ID="txtRadioCilindro" runat="server"></asp:TextBox>
			Altura<asp:TextBox ID="txtAlturaCilindro" runat="server"></asp:TextBox>
			<asp:Button ID="btnCalcularCilindro" runat="server" Text="Calcular" OnClick="btnCalcularCilindro_Click" />
			Resultado<asp:TextBox ID="txtResultadoCilindro" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	Volumen de la Esfera<br />
            Radio<asp:TextBox ID="txtRadioEsfera" runat="server"></asp:TextBox>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:Button ID="ButtonEsfera" runat="server" OnClick="Button1_Click1" Text="Calcular" />
&nbsp;Resultado<asp:TextBox ID="txtResultadoEsfera" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	Volumen del Cono<br />
            Radio<asp:TextBox ID="txtRadioCono" runat="server"></asp:TextBox>
			Altura<asp:TextBox ID="txtAlturaCono" runat="server"></asp:TextBox>
			<asp:Button ID="btnConoCalcular" runat="server" OnClick="btnConoCalcular_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtResultadoCono" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	Volumen del Cubo<br />
            Arista<asp:TextBox ID="txtAristaCubo" runat="server" Width="140px"></asp:TextBox>
			<asp:Button ID="BtnCuboCalcular" runat="server" OnClick="BtnCuboCalcular_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtResultadoCubo" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	Volumen del Prisma<br />
            Largo<asp:TextBox ID="txtLargoPrisma" runat="server"></asp:TextBox>
			Ancho<asp:TextBox ID="txtAnchoPrima" runat="server"></asp:TextBox>
			Altura<asp:TextBox ID="txtAlturaPrisma" runat="server"></asp:TextBox>
			<asp:Button ID="BtnPrismaCalcular" runat="server" OnClick="BtnPrismaCalcular_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtResultadoPrisma" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	Volumen de la Piramide Cuadrada<br />
            LadoBase<asp:TextBox ID="txtLadoBasePiramideCuadrada" runat="server"></asp:TextBox>
			Altura<asp:TextBox ID="txtAlturaPiramideCuadrada" runat="server"></asp:TextBox>
			<asp:Button ID="BtnPiramideCuadradaCalcular" runat="server" OnClick="BtnPiramideCuadradaCalcular_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtResultadoPiramideCuadrada" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	Volumen de la Piramide Poligonial<br />
            Apotema<asp:TextBox ID="txtApotemaPiramidePoligonial" runat="server"></asp:TextBox>
			Altura<asp:TextBox ID="txtAlturaPiramidePoligonial" runat="server"></asp:TextBox>
			CantidadLados<asp:TextBox ID="txtCantidadLadosPiramidePoligonial" runat="server"></asp:TextBox>
			<asp:Button ID="BtnApotemaPoligonialCalcular" runat="server" OnClick="BtnApotemaPoligonialCalcular_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtResultadoPiramidePoligonial" runat="server" Width="128px"></asp:TextBox>
            </p>
	<p>
		&nbsp;</p>
<p style="font-size: large">
            Parámetros de entrada:&nbsp;&nbsp;&nbsp;&nbsp; Areas </p>
	<p style="font-size: large">
            &nbsp;</p>
	<p style="font-size: large">
            <span lang="ES-CR">Area</span> <span lang="ES-CR">De</span> <span lang="ES-CR">Rombo</span><br />
            DiagonalMenor<asp:TextBox ID="txtLadoMenorRombo" runat="server"></asp:TextBox>
			DiagonalMayor<asp:TextBox ID="txtladoMayorRombo" runat="server"></asp:TextBox>
			<asp:Button ID="btnRomboCalcular" runat="server" OnClick="btnRomboCalcular_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtResiltadoRombo" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	<span lang="ES-CR">Area</span> <span lang="ES-CR">De</span> <span lang="ES-CR">Cuadrado</span><br />
            Lado<asp:TextBox ID="txtladoCuadrado" runat="server"></asp:TextBox>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCalcularCuadrado" runat="server" OnClick="btnCalcularCuadrado_Click" Text="Calcular" />
	&nbsp;
&nbsp;Resultado<asp:TextBox ID="txtResultadoAREACuadrado" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	<span lang="ES-CR">Area</span> <span lang="ES-CR">De</span>l <span lang="ES-CR">Rectangulo</span><br />
            ANCHO<asp:TextBox ID="txthancho" runat="server"></asp:TextBox>
			LARGO<asp:TextBox ID="txtlargo" runat="server"></asp:TextBox>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="calcular" />
			Resultado<asp:TextBox ID="txtResultadoRectangulo" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	AREA DEL POLIGONO REGULAR<br />
            LADO<asp:TextBox ID="txtAreaPoligonoRegularLado" runat="server" Width="119px"></asp:TextBox>
			CANTIDA DE LADOS<asp:TextBox ID="txtAreaPoligonoRegularCantLados" runat="server" Width="123px"></asp:TextBox>
			APOTEMA<asp:TextBox ID="txtAreaPoligonoRegularApotema" runat="server" Width="122px"></asp:TextBox>
			<asp:Button ID="btnCalcularAreaPoligonoRegular" runat="server" OnClick="btnCalcularAreaPoligonoRegular_Click" Text="Calcular" />
	<asp:TextBox ID="txtAreaPoligonoRegularResultado" runat="server" Width="140px"></asp:TextBox>
            </p>
<p>
	AREA DEL TRIANGULO<br />
            LADO1<asp:TextBox ID="txtAreaTrianfuloLado1" runat="server"></asp:TextBox>
			LADO2<asp:TextBox ID="txtAreaTrianfuloLado2" runat="server"></asp:TextBox>
			LADO3<asp:TextBox ID="txtAreaTrianfuloLado3" runat="server"></asp:TextBox>
			<asp:Button ID="btnCalcularAreaTringulo" runat="server" OnClick="btnCalcularAreaTringulo_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtAreaTrianfuloResultado" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	AREA DEL TRAPECEO<br />
            BASE MAYOR<asp:TextBox ID="txtAreaTrianguloTrapeceoBMayor" runat="server"></asp:TextBox>
			BASE MENOR <asp:TextBox ID="txtAreaTrianguloTrapeceoBMenor" runat="server"></asp:TextBox>
			&nbsp;Altura<asp:TextBox ID="txtAreaTrianguloTrapeceoAltura" runat="server"></asp:TextBox>
			<asp:Button ID="btnAreaTrapeceoCalculo" runat="server" OnClick="btnAreaTrapeceoCalculo_Click" Text="Calculo" />
			Resultado<asp:TextBox ID="txtAreaTrianguloTrapeceoResultado" runat="server" Width="128px"></asp:TextBox>
            </p>
<p>
	AREA DEL ROMBOIDE<br />
            BASE ROMBOIDE<asp:TextBox ID="txtAreaRomboideBaseR" runat="server"></asp:TextBox>
			Altura<asp:TextBox ID="txtAreaRomboideAltura" runat="server"></asp:TextBox>
			<asp:Button ID="btnCalcularAreaRomboide" runat="server" OnClick="btnCalcularAreaRomboide_Click" Text="Calcular" />
			Resultado<asp:TextBox ID="txtAreaRomboideResultado" runat="server" Width="128px"></asp:TextBox>
            </p>
	<p>
		&nbsp;</p>
	<p>
		&nbsp;</p>
	<p>
		&nbsp;</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
