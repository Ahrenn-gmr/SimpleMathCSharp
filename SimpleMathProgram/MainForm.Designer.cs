/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 26/10/2026
 * Hora: 03:23 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SimpleMathProgram
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnMult = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnModulo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "SimpleMath V2.0.1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Numero 2:";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(101, 47);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 22);
			this.txtNumero1.TabIndex = 3;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(101, 86);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 22);
			this.txtNumero2.TabIndex = 4;
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(224, 30);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 5;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(224, 72);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(75, 23);
			this.btnRestar.TabIndex = 6;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnMult
			// 
			this.btnMult.Location = new System.Drawing.Point(215, 113);
			this.btnMult.Name = "btnMult";
			this.btnMult.Size = new System.Drawing.Size(84, 23);
			this.btnMult.TabIndex = 7;
			this.btnMult.Text = "Multiplicar";
			this.btnMult.UseVisualStyleBackColor = true;
			this.btnMult.Click += new System.EventHandler(this.BtnMultClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(224, 153);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 23);
			this.btnDividir.TabIndex = 8;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(13, 140);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(188, 66);
			this.lblResultado.TabIndex = 9;
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(224, 196);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(75, 23);
			this.btnModulo.TabIndex = 10;
			this.btnModulo.Text = "%";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 231);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMult);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "SimpleMath V2.0.1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMult;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
