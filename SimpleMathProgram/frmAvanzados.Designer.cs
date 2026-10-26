/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 26/10/2026
 * Hora: 03:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SimpleMathProgram
{
	partial class frmAvanzados
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
			this.label4 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.lblRest = new System.Windows.Forms.Label();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "AdvancedMath V3.0";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor de \"a\":";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Valor de \"b\":";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Valor de \"c\":";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(120, 54);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 22);
			this.txtA.TabIndex = 4;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(120, 90);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 22);
			this.txtB.TabIndex = 5;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(120, 125);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 22);
			this.txtC.TabIndex = 6;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(246, 90);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(84, 23);
			this.btnCalcular.TabIndex = 7;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(12, 184);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(84, 23);
			this.btnRegresar.TabIndex = 8;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblRest
			// 
			this.lblRest.Location = new System.Drawing.Point(105, 169);
			this.lblRest.Name = "lblRest";
			this.lblRest.Size = new System.Drawing.Size(225, 23);
			this.lblRest.TabIndex = 9;
			this.lblRest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(246, 61);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(84, 23);
			this.btnBorrar.TabIndex = 10;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// frmAvanzados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 219);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.lblRest);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmAvanzados";
			this.Text = "AdvancedMathMode";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Label lblRest;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
