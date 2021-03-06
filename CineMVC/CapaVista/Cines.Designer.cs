
namespace CapaVista
{
	partial class Cines
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cines));
			this.txtestado = new System.Windows.Forms.TextBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
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
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtestado
			// 
			this.txtestado.Location = new System.Drawing.Point(294, 185);
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(52, 20);
			this.txtestado.TabIndex = 28;
			this.txtestado.Tag = "estado";
			this.txtestado.Visible = false;
			this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(100, 155);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(187, 20);
			this.txtdireccion.TabIndex = 24;
			this.txtdireccion.Tag = "Dirección";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(100, 129);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(187, 20);
			this.txtnombre.TabIndex = 22;
			this.txtnombre.Tag = "Nombre";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(100, 103);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(187, 20);
			this.txtid.TabIndex = 20;
			this.txtid.Tag = "idCines";
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(392, 92);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.Size = new System.Drawing.Size(775, 225);
			this.dgvVistaPrevia.TabIndex = 29;
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(-1, -1);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 27;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbninactivo);
			this.panel1.Controls.Add(this.rbnactivo);
			this.panel1.Location = new System.Drawing.Point(100, 181);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(187, 24);
			this.panel1.TabIndex = 26;
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
			this.label8.Location = new System.Drawing.Point(30, 185);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Estatus";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Direccion";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "ID";
			// 
			// Cines
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1180, 330);
			this.Controls.Add(this.txtestado);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cines";
			this.Text = "Mantenimiento Cines";
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtestado;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.TextBox txtnombre;
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
	}
}