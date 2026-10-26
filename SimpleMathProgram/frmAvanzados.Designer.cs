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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvanzados));
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
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "AdvancedMath V4.0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor de \"a\":";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Valor de \"b\":";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Valor de \"c\":";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(141, 133);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 22);
			this.txtA.TabIndex = 4;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(141, 172);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 22);
			this.txtB.TabIndex = 5;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(141, 211);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 22);
			this.txtC.TabIndex = 6;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
			this.btnCalcular.Location = new System.Drawing.Point(298, 120);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(135, 101);
			this.btnCalcular.TabIndex = 7;
			this.btnCalcular.Text = "CALCULAR";
			this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(13, 319);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(196, 38);
			this.btnRegresar.TabIndex = 8;
			this.btnRegresar.Text = "Regresar al Inicio";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblRest
			// 
			this.lblRest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRest.Location = new System.Drawing.Point(16, 250);
			this.lblRest.Name = "lblRest";
			this.lblRest.Size = new System.Drawing.Size(276, 53);
			this.lblRest.TabIndex = 9;
			this.lblRest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.Location = new System.Drawing.Point(298, 227);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(135, 48);
			this.btnBorrar.TabIndex = 10;
			this.btnBorrar.Text = "BORRAR";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(464, 41);
			this.label5.TabIndex = 11;
			this.label5.Text = "Bienvenid@ a AdvancedMath, lugar donde puedes hacer calculos para encontrar X1 y " +
			"X2 con la formula general.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmAvanzados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(489, 369);
			this.Controls.Add(this.label5);
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
		private System.Windows.Forms.Label label5;
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
