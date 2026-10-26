/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 26/10/2026
 * Hora: 03:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleMathProgram
{
	/// <summary>
	/// Description of frmAvanzados.
	/// </summary>
	public partial class frmAvanzados : Form
	{
		public frmAvanzados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(txtA.Text);
			double b = Convert.ToDouble(txtB.Text);
			double c = Convert.ToDouble(txtC.Text);
			double discriminante = Math.Pow(b, 2) - (4 * a * c);

	        if (discriminante >= 0)
	        {
	            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
	            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
	
	            lblRest.Text = "X1 = " + x1.ToString() + "  |  X2 = " + x2.ToString();
	
	        }
	        else
	        {
	        	MessageBox.Show("No hay solucion");
	        	txtA.Text = "";
	        	txtB.Text = "";
	        	txtC.Text = "";
	        }
		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			txtA.Text = "";
	        txtB.Text = "";
	        txtC.Text = "";
	        lblRest.Text = "";
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Close();
		}
	}
}
