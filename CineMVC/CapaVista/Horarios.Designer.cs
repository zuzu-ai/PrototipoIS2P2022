
namespace CapaVista
{
	partial class Horarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios));
			this.txtestado = new System.Windows.Forms.TextBox();
			this.txtsala = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.navegador1 = new DLL.nav.navegador();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbninactivo = new System.Windows.Forms.RadioButton();
			this.rbnactivo = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtfecha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtpelicula = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cbxPelicula = new System.Windows.Forms.ComboBox();
			this.cbxSala = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtestado
			// 
			this.txtestado.Location = new System.Drawing.Point(295, 210);
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(52, 20);
			this.txtestado.TabIndex = 39;
			this.txtestado.Tag = "estado";
			this.txtestado.Visible = false;
			this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
			// 
			// txtsala
			// 
			this.txtsala.Location = new System.Drawing.Point(295, 154);
			this.txtsala.Name = "txtsala";
			this.txtsala.Size = new System.Drawing.Size(52, 20);
			this.txtsala.TabIndex = 35;
			this.txtsala.Tag = "fkSala";
			this.txtsala.Visible = false;
			this.txtsala.TextChanged += new System.EventHandler(this.txtsala_TextChanged);
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(101, 102);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(187, 20);
			this.txtid.TabIndex = 31;
			this.txtid.Tag = "idhorarioCine";
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(393, 91);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.Size = new System.Drawing.Size(775, 225);
			this.dgvVistaPrevia.TabIndex = 40;
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(0, -2);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 38;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbninactivo);
			this.panel1.Controls.Add(this.rbnactivo);
			this.panel1.Location = new System.Drawing.Point(101, 206);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(187, 24);
			this.panel1.TabIndex = 37;
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
			this.label8.Location = new System.Drawing.Point(31, 210);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 13);
			this.label8.TabIndex = 36;
			this.label8.Text = "Estatus";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "Sala";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 32;
			this.label2.Text = "Pelicula";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 30;
			this.label1.Text = "ID";
			// 
			// txtfecha
			// 
			this.txtfecha.Location = new System.Drawing.Point(295, 180);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.Size = new System.Drawing.Size(52, 20);
			this.txtfecha.TabIndex = 42;
			this.txtfecha.Tag = "fechaHorario";
			this.txtfecha.Visible = false;
			this.txtfecha.TextChanged += new System.EventHandler(this.txtfecha_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 41;
			this.label4.Text = "Fecha";
			// 
			// txtpelicula
			// 
			this.txtpelicula.Location = new System.Drawing.Point(295, 128);
			this.txtpelicula.Name = "txtpelicula";
			this.txtpelicula.Size = new System.Drawing.Size(52, 20);
			this.txtpelicula.TabIndex = 33;
			this.txtpelicula.Tag = "fkPelicula";
			this.txtpelicula.Visible = false;
			this.txtpelicula.TextChanged += new System.EventHandler(this.txtpelicula_TextChanged);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(101, 183);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(187, 20);
			this.dtpFecha.TabIndex = 43;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
			// 
			// cbxPelicula
			// 
			this.cbxPelicula.FormattingEnabled = true;
			this.cbxPelicula.Location = new System.Drawing.Point(101, 129);
			this.cbxPelicula.Name = "cbxPelicula";
			this.cbxPelicula.Size = new System.Drawing.Size(187, 21);
			this.cbxPelicula.TabIndex = 44;
			this.cbxPelicula.SelectedIndexChanged += new System.EventHandler(this.cbxPelicula_SelectedIndexChanged);
			// 
			// cbxSala
			// 
			this.cbxSala.FormattingEnabled = true;
			this.cbxSala.Location = new System.Drawing.Point(101, 154);
			this.cbxSala.Name = "cbxSala";
			this.cbxSala.Size = new System.Drawing.Size(187, 21);
			this.cbxSala.TabIndex = 45;
			this.cbxSala.SelectedIndexChanged += new System.EventHandler(this.cbxSala_SelectedIndexChanged);
			// 
			// Horarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 325);
			this.Controls.Add(this.txtestado);
			this.Controls.Add(this.txtfecha);
			this.Controls.Add(this.txtsala);
			this.Controls.Add(this.txtpelicula);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.cbxSala);
			this.Controls.Add(this.cbxPelicula);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Horarios";
			this.Text = "Mantenimiento Horarios";
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtestado;
		private System.Windows.Forms.TextBox txtsala;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbninactivo;
		private System.Windows.Forms.RadioButton rbnactivo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtfecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtpelicula;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cbxPelicula;
		private System.Windows.Forms.ComboBox cbxSala;
	}
}