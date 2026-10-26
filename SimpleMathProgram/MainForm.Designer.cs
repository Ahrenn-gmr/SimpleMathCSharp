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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.btnAvanzados = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(477, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "SIMPLE-MATH V4.0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NÚMERO 1:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(267, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "NÚMERO 2:";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(130, 124);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 22);
			this.txtNumero1.TabIndex = 3;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(387, 124);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 22);
			this.txtNumero2.TabIndex = 4;
			// 
			// btnSumar
			// 
			this.btnSumar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSumar.Image = ((System.Drawing.Image)(resources.GetObject("btnSumar.Image")));
			this.btnSumar.Location = new System.Drawing.Point(54, 173);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(177, 55);
			this.btnSumar.TabIndex = 5;
			this.btnSumar.Text = "SUMAR";
			this.btnSumar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestar.Image")));
			this.btnRestar.Location = new System.Drawing.Point(54, 248);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(177, 55);
			this.btnRestar.TabIndex = 6;
			this.btnRestar.Text = "RESTAR";
			this.btnRestar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnMult
			// 
			this.btnMult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMult.Image = ((System.Drawing.Image)(resources.GetObject("btnMult.Image")));
			this.btnMult.Location = new System.Drawing.Point(279, 248);
			this.btnMult.Name = "btnMult";
			this.btnMult.Size = new System.Drawing.Size(176, 55);
			this.btnMult.TabIndex = 7;
			this.btnMult.Text = "MULTIPLICAR";
			this.btnMult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnMult.UseVisualStyleBackColor = true;
			this.btnMult.Click += new System.EventHandler(this.BtnMultClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Image = ((System.Drawing.Image)(resources.GetObject("btnDividir.Image")));
			this.btnDividir.Location = new System.Drawing.Point(279, 173);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(177, 55);
			this.btnDividir.TabIndex = 8;
			this.btnDividir.Text = "DIVIDIR";
			this.btnDividir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(129, 385);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(252, 76);
			this.lblResultado.TabIndex = 9;
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnModulo
			// 
			this.btnModulo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModulo.Image = ((System.Drawing.Image)(resources.GetObject("btnModulo.Image")));
			this.btnModulo.Location = new System.Drawing.Point(194, 309);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(124, 57);
			this.btnModulo.TabIndex = 10;
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// btnAvanzados
			// 
			this.btnAvanzados.Location = new System.Drawing.Point(12, 487);
			this.btnAvanzados.Name = "btnAvanzados";
			this.btnAvanzados.Size = new System.Drawing.Size(124, 32);
			this.btnAvanzados.TabIndex = 11;
			this.btnAvanzados.Text = "Avanzados";
			this.btnAvanzados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnAvanzados.UseVisualStyleBackColor = true;
			this.btnAvanzados.Click += new System.EventHandler(this.BtnAvanzadosClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(477, 43);
			this.label4.TabIndex = 12;
			this.label4.Text = "Bienvenid@ a SIMPLE-MATH 4.0. Haz operaciones basicas de dos numeros y da click a" +
			" cualquier boton para ver el resultado.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(502, 528);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnAvanzados);
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
			this.Text = "SIMPLE-MATH V4.0";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAvanzados;
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
