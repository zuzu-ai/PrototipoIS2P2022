
namespace CapaVista
{
	partial class Peliculas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
			this.label1 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtclasificacion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtgenero = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtsubtitulado = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtidioma = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtprecio = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbninactivo = new System.Windows.Forms.RadioButton();
			this.rbnactivo = new System.Windows.Forms.RadioButton();
			this.navegador1 = new DLL.nav.navegador();
			this.txtestado = new System.Windows.Forms.TextBox();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbnNo = new System.Windows.Forms.RadioButton();
			this.rbnSi = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(100, 97);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(187, 20);
			this.txtid.TabIndex = 1;
			this.txtid.Tag = "idPeliculas";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(100, 123);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(187, 20);
			this.txtnombre.TabIndex = 3;
			this.txtnombre.Tag = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// txtclasificacion
			// 
			this.txtclasificacion.Location = new System.Drawing.Point(100, 149);
			this.txtclasificacion.Name = "txtclasificacion";
			this.txtclasificacion.Size = new System.Drawing.Size(187, 20);
			this.txtclasificacion.TabIndex = 5;
			this.txtclasificacion.Tag = "Clasificación";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Clasificación";
			// 
			// txtgenero
			// 
			this.txtgenero.Location = new System.Drawing.Point(100, 175);
			this.txtgenero.Name = "txtgenero";
			this.txtgenero.Size = new System.Drawing.Size(187, 20);
			this.txtgenero.TabIndex = 7;
			this.txtgenero.Tag = "Genero";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Genero";
			// 
			// txtsubtitulado
			// 
			this.txtsubtitulado.Location = new System.Drawing.Point(294, 201);
			this.txtsubtitulado.Name = "txtsubtitulado";
			this.txtsubtitulado.Size = new System.Drawing.Size(52, 20);
			this.txtsubtitulado.TabIndex = 9;
			this.txtsubtitulado.Tag = "Subtitulado";
			this.txtsubtitulado.Visible = false;
			this.txtsubtitulado.TextChanged += new System.EventHandler(this.txtsubtitulado_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Subtitulado";
			// 
			// txtidioma
			// 
			this.txtidioma.Location = new System.Drawing.Point(100, 227);
			this.txtidioma.Name = "txtidioma";
			this.txtidioma.Size = new System.Drawing.Size(187, 20);
			this.txtidioma.TabIndex = 11;
			this.txtidioma.Tag = "Idioma";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 230);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Idioma";
			// 
			// txtprecio
			// 
			this.txtprecio.Location = new System.Drawing.Point(100, 253);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.Size = new System.Drawing.Size(187, 20);
			this.txtprecio.TabIndex = 13;
			this.txtprecio.Tag = "Precio";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(29, 256);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Precio";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 283);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Estatus";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbninactivo);
			this.panel1.Controls.Add(this.rbnactivo);
			this.panel1.Location = new System.Drawing.Point(100, 279);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(187, 24);
			this.panel1.TabIndex = 15;
			// 
			// rbninactivo
			// 
			this.rbninactivo.AutoSize = true;
			this.rbninactivo.Location = new System.Drawing.Point(96, 4);
			this.rbninactivo.Name = "rbninactivo";
			this.rbninactivo.Size = new System.Drawing.Size(63, 17);
			this.rbninactivo.TabIndex = 1;
			this.rbninactivo.TabStop = true;
			this.rbninactivo.Text = "Inactivo";
			this.rbninactivo.UseVisualStyleBackColor = true;
			this.rbninactivo.CheckedChanged += new System.EventHandler(this.rbninactivo_CheckedChanged);
			// 
			// rbnactivo
			// 
			this.rbnactivo.AutoSize = true;
			this.rbnactivo.Location = new System.Drawing.Point(4, 4);
			this.rbnactivo.Name = "rbnactivo";
			this.rbnactivo.Size = new System.Drawing.Size(55, 17);
			this.rbnactivo.TabIndex = 0;
			this.rbnactivo.TabStop = true;
			this.rbnactivo.Text = "Activo";
			this.rbnactivo.UseVisualStyleBackColor = true;
			this.rbnactivo.CheckedChanged += new System.EventHandler(this.rbnactivo_CheckedChanged);
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(-1, -7);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 16;
			// 
			// txtestado
			// 
			this.txtestado.Location = new System.Drawing.Point(294, 283);
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(52, 20);
			this.txtestado.TabIndex = 17;
			this.txtestado.Tag = "estado";
			this.txtestado.Visible = false;
			this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(392, 86);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.Size = new System.Drawing.Size(775, 225);
			this.dgvVistaPrevia.TabIndex = 18;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbnNo);
			this.panel2.Controls.Add(this.rbnSi);
			this.panel2.Location = new System.Drawing.Point(100, 197);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(187, 24);
			this.panel2.TabIndex = 16;
			// 
			// rbnNo
			// 
			this.rbnNo.AutoSize = true;
			this.rbnNo.Location = new System.Drawing.Point(96, 4);
			this.rbnNo.Name = "rbnNo";
			this.rbnNo.Size = new System.Drawing.Size(39, 17);
			this.rbnNo.TabIndex = 1;
			this.rbnNo.TabStop = true;
			this.rbnNo.Text = "No";
			this.rbnNo.UseVisualStyleBackColor = true;
			this.rbnNo.CheckedChanged += new System.EventHandler(this.rbnNo_CheckedChanged);
			// 
			// rbnSi
			// 
			this.rbnSi.AutoSize = true;
			this.rbnSi.Location = new System.Drawing.Point(4, 4);
			this.rbnSi.Name = "rbnSi";
			this.rbnSi.Size = new System.Drawing.Size(34, 17);
			this.rbnSi.TabIndex = 0;
			this.rbnSi.TabStop = true;
			this.rbnSi.Text = "Si";
			this.rbnSi.UseVisualStyleBackColor = true;
			this.rbnSi.CheckedChanged += new System.EventHandler(this.rbnSi_CheckedChanged);
			// 
			// Peliculas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1179, 323);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtestado);
			this.Controls.Add(this.txtprecio);
			this.Controls.Add(this.txtidioma);
			this.Controls.Add(this.txtsubtitulado);
			this.Controls.Add(this.txtgenero);
			this.Controls.Add(this.txtclasificacion);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Peliculas";
			this.Text = "Mantenimiento Peliculas";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtclasificacion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtgenero;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtsubtitulado;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtidioma;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtprecio;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbninactivo;
		private System.Windows.Forms.RadioButton rbnactivo;
		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.TextBox txtestado;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbnNo;
		private System.Windows.Forms.RadioButton rbnSi;
	}
}