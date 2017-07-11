using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen.interfase.Volumenes
{
	public partial class VolumnesMetodos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

		}

		protected void btnCalcularCilindro_Click(object sender, EventArgs e)
		{
			double altura = Convert.ToDouble(txtAlturaCilindro.Text);
			double Radio = Convert.ToDouble(txtRadioCilindro.Text);


			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference1.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.VolumenCilindro(Radio, altura);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtResultadoCilindro.Text = elResultado;
		}

		protected void Button1_Click1(object sender, EventArgs e)
		{

			double Radio = Convert.ToDouble(txtRadioEsfera.Text);
			// llama el metodo de Calculo esfera
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.VolumenEsfera(Radio);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		
			txtResultadoEsfera.Text = elResultado;

		}

		protected void btnConoCalcular_Click(object sender, EventArgs e)
		{
			double Radio = Convert.ToDouble(txtRadioCono.Text);
			double Altura = Convert.ToDouble(txtAlturaCono.Text);
			// llama el metodo de Calculo esfera
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.VolumenCono(Radio, Altura);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		
			txtResultadoCono.Text = elResultado;

		}

		protected void BtnApotemaPoligonialCalcular_Click(object sender, EventArgs e)
		{
			double Apotema = Convert.ToDouble(txtApotemaPiramidePoligonial.Text);
			double Altura = Convert.ToDouble(txtAlturaPiramidePoligonial.Text);
			double CanLados = Convert.ToDouble(txtCantidadLadosPiramidePoligonial.Text);

			// llama el metodo de Calculo esfera
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.VolumenPiramidePoligonal(Apotema, Altura, CanLados);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		
			txtResultadoPiramidePoligonial.Text = elResultado;

		}

		protected void BtnPiramideCuadradaCalcular_Click(object sender, EventArgs e)
		{
			double LadoBase = Convert.ToDouble(txtLadoBasePiramideCuadrada.Text);
			double Altura = Convert.ToDouble(txtAlturaPiramideCuadrada.Text);

			// llama el metodo de Calculo esfera
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.VolumenPiramideCuadrada(Altura, LadoBase);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		
			txtResultadoPiramideCuadrada.Text = elResultado;
		}

		protected void BtnPrismaCalcular_Click(object sender, EventArgs e)
		{
			double Largo = Convert.ToDouble(txtLargoPrisma.Text);
			double Altura = Convert.ToDouble(txtAlturaPrisma.Text);
			double Hancho = Convert.ToDouble(txtAnchoPrima.Text);

			// llama el metodo de Calculo esfera
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.VolumenPrisma(Largo, Altura, Hancho);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		
			txtResultadoPrisma.Text = elResultado;
		}

		protected void BtnCuboCalcular_Click(object sender, EventArgs e)
		{
			double Arista = Convert.ToDouble(txtAristaCubo.Text);
			// llama el metodo de Calculo esfera
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.VolumenCubo(Arista);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		
			txtResultadoCubo.Text = elResultado;


		}

		protected void btnRomboCalcular_Click(object sender, EventArgs e)
		{
			double Mayor = Convert.ToDouble(txtladoMayorRombo.Text);
			double Menor = Convert.ToDouble(txtLadoMenorRombo.Text);


			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.AreaRombo(Mayor, Menor);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtResiltadoRombo.Text = elResultado;
		}

		protected void btnCalcularCuadrado_Click(object sender, EventArgs e)
		{

			double lado = Convert.ToDouble(txtladoCuadrado.Text);
			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.AreaCuadrado(lado);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtResultadoAREACuadrado.Text = elResultado;

		}

		protected void Button1_Click2(object sender, EventArgs e)
		{
			double Largo = Convert.ToDouble(txtlargo.Text);
			double ancho = Convert.ToDouble(txthancho.Text);

			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.AreaRectangulo(Largo, ancho);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtResultadoRectangulo.Text = elResultado;
		}

		protected void btnCalcularAreaRomboide_Click(object sender, EventArgs e)
		{

			double baseRomboide = Convert.ToDouble(txtAreaRomboideBaseR.Text);
			double Altura = Convert.ToDouble(txtAreaRomboideAltura.Text);

			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.AreaRomboide(baseRomboide,Altura);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtAreaRomboideResultado.Text = elResultado;

		}

		protected void btnAreaTrapeceoCalculo_Click(object sender, EventArgs e)
		{
			double baseMayor = Convert.ToDouble(txtAreaTrianguloTrapeceoBMayor.Text);
			double Altura = Convert.ToDouble(txtAreaTrianguloTrapeceoAltura.Text);
			double baseMenor = Convert.ToDouble(txtAreaTrianguloTrapeceoBMenor.Text);

			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.AreaTrapecio(baseMayor,baseMenor,Altura);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtAreaTrianguloTrapeceoResultado.Text = elResultado;
		}

		protected void btnCalcularAreaTringulo_Click(object sender, EventArgs e)
		{
			double Lado1 = Convert.ToDouble(txtAreaTrianfuloLado1.Text);
			double Lado2 = Convert.ToDouble(txtAreaTrianfuloLado2.Text);
			double Lado3 = Convert.ToDouble(txtAreaTrianfuloLado3.Text);

			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.AreaTriangulo(Lado1, Lado2, Lado3);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtAreaTrianfuloResultado.Text = elResultado;
		}

		protected void btnCalcularAreaPoligonoRegular_Click(object sender, EventArgs e)
		{
			double Lado = Convert.ToDouble(txtAreaPoligonoRegularLado.Text);
			double apotema = Convert.ToDouble(txtAreaPoligonoRegularApotema.Text);
			int CantLados = Convert.ToInt32(txtAreaPoligonoRegularCantLados.Text);

			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;
			// instanciar el wcf
			var elCliente = new ServiceReference2.Service1Client();
			// invocar al mètodo del wcf
			var elResultadoNumerico = elCliente.AreaPoligonoRegular(Lado,apotema,CantLados);
			// convertir el resultado a string
			elResultado = elResultadoNumerico.ToString();
			// retornar		

			txtAreaPoligonoRegularResultado.Text = elResultado;
		}
	}
}