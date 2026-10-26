/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 26/10/2026
 * Hora: 03:23 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleMathProgram
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double sumar;
			sumar = double.Parse(txtNumero1.Text)+double.Parse(txtNumero2.Text);
			lblResultado.Text = "El resultado de la suma es: " + sumar.ToString();
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double restar;
			restar = double.Parse(txtNumero1.Text)-double.Parse(txtNumero2.Text);
			lblResultado.Text = "El resultado de la resta es: " + restar.ToString();
		}
		
		void BtnMultClick(object sender, EventArgs e)
		{
			double mult;
			mult = double.Parse(txtNumero1.Text)*double.Parse(txtNumero2.Text);
			lblResultado.Text = "El resultado de la multiplicacion es: " + mult.ToString();
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double dividir;
			dividir = double.Parse(txtNumero1.Text)/double.Parse(txtNumero2.Text);
			lblResultado.Text = "El resultado de la division es: " + dividir.ToString();
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double modulo;
			modulo = double.Parse(txtNumero1.Text)%double.Parse(txtNumero2.Text);
			lblResultado.Text = "El resultado de la operacion en modulo es: " + modulo.ToString();
		}
	}
}
