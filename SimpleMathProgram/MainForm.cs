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
			lblResultado.Text = Convert.ToString(sumar);
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double restar;
			restar = double.Parse(txtNumero1.Text)-double.Parse(txtNumero2.Text);
			lblResultado.Text = Convert.ToString(restar);
		}
		
		void BtnMultClick(object sender, EventArgs e)
		{
			double mult;
			mult = double.Parse(txtNumero1.Text)*double.Parse(txtNumero2.Text);
			lblResultado.Text = Convert.ToString(mult);
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double dividir;
			dividir = double.Parse(txtNumero1.Text)/double.Parse(txtNumero2.Text);
			lblResultado.Text = Convert.ToString(dividir);
		}
	}
}
