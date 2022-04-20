
namespace CapaVista
{
	partial class Salas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salas));
			this.txtestado = new System.Windows.Forms.TextBox();
			this.txtprecio = new System.Windows.Forms.TextBox();
			this.txtpuntos = new System.Windows.Forms.TextBox();
			this.txtformato = new System.Windows.Forms.TextBox();
			this.txtdescripcion = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.navegador1 = new DLL.nav.navegador();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbninactivo = new System.Windows.Forms.RadioButton();
			this.rbnactivo = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxCine = new System.Windows.Forms.ComboBox();
			this.txtcine = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtestado
			// 
			this.txtestado.Location = new System.Drawing.Point(292, 266);
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(52, 20);
			this.txtestado.TabIndex = 36;
			this.txtestado.Tag = "estado";
			this.txtestado.Visible = false;
			this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
			// 
			// txtprecio
			// 
			this.txtprecio.Location = new System.Drawing.Point(98, 236);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.Size = new System.Drawing.Size(187, 20);
			this.txtprecio.TabIndex = 32;
			this.txtprecio.Tag = "precioSala";
			// 
			// txtpuntos
			// 
			this.txtpuntos.Location = new System.Drawing.Point(98, 208);
			this.txtpuntos.Name = "txtpuntos";
			this.txtpuntos.Size = new System.Drawing.Size(187, 20);
			this.txtpuntos.TabIndex = 28;
			this.txtpuntos.Tag = "puntos";
			// 
			// txtformato
			// 
			this.txtformato.Location = new System.Drawing.Point(98, 182);
			this.txtformato.Name = "txtformato";
			this.txtformato.Size = new System.Drawing.Size(187, 20);
			this.txtformato.TabIndex = 26;
			this.txtformato.Tag = "formatoPeli";
			// 
			// txtdescripcion
			// 
			this.txtdescripcion.Location = new System.Drawing.Point(98, 156);
			this.txtdescripcion.Name = "txtdescripcion";
			this.txtdescripcion.Size = new System.Drawing.Size(187, 20);
			this.txtdescripcion.TabIndex = 24;
			this.txtdescripcion.Tag = "Descripción";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(98, 104);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(187, 20);
			this.txtid.TabIndex = 20;
			this.txtid.Tag = "idSalas";
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(390, 93);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.Size = new System.Drawing.Size(775, 225);
			this.dgvVistaPrevia.TabIndex = 37;
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(-3, 0);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 35;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbninactivo);
			this.panel1.Controls.Add(this.rbnactivo);
			this.panel1.Location = new System.Drawing.Point(98, 262);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(187, 24);
			this.panel1.TabIndex = 34;
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
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(28, 266);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 13);
			this.label8.TabIndex = 33;
			this.label8.Text = "Estatus";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(27, 239);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 31;
			this.label7.Text = "Precio";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 211);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "Puntos";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Formato";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Descripción";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Cine";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "ID";
			// 
			// cbxCine
			// 
			this.cbxCine.FormattingEnabled = true;
			this.cbxCine.Location = new System.Drawing.Point(98, 131);
			this.cbxCine.Name = "cbxCine";
			this.cbxCine.Size = new System.Drawing.Size(187, 21);
			this.cbxCine.TabIndex = 38;
			this.cbxCine.Tag = "";
			this.cbxCine.SelectedIndexChanged += new System.EventHandler(this.cbxCine_SelectedIndexChanged);
			// 
			// txtcine
			// 
			this.txtcine.Location = new System.Drawing.Point(291, 130);
			this.txtcine.Name = "txtcine";
			this.txtcine.Size = new System.Drawing.Size(53, 20);
			this.txtcine.TabIndex = 39;
			this.txtcine.Tag = "fkCine";
			this.txtcine.Visible = false;
			this.txtcine.TextChanged += new System.EventHandler(this.txtcine_TextChanged);
			// 
			// Salas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1181, 450);
			this.Controls.Add(this.txtestado);
			this.Controls.Add(this.txtprecio);
			this.Controls.Add(this.txtpuntos);
			this.Controls.Add(this.txtformato);
			this.Controls.Add(this.txtdescripcion);
			this.Controls.Add(this.txtcine);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.cbxCine);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Salas";
			this.Text = "Mantenimiento Salas";
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtestado;
		private System.Windows.Forms.TextBox txtprecio;
		private System.Windows.Forms.TextBox txtpuntos;
		private System.Windows.Forms.TextBox txtformato;
		private System.Windows.Forms.TextBox txtdescripcion;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbninactivo;
		private System.Windows.Forms.RadioButton rbnactivo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxCine;
		private System.Windows.Forms.TextBox txtcine;
	}
}