﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaVistaSeguridadHSC;

namespace CapaVista
{
	public partial class MDICine : Form
	{
		CapaControlador.Controlador controlador = new CapaControlador.Controlador();
		public MDICine()
		{
			InitializeComponent();
		}

		private void MDICine_Load(object sender, EventArgs e)
		{
			frmLoginHSC form = new frmLoginHSC();
			if (form.ShowDialog() == DialogResult.OK)
			{
				txtUsuario.Text = form.usuario();
			}
			else
			{
				this.Close();
			}
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLoginHSC form = new frmLoginHSC();
			if (form.ShowDialog() == DialogResult.OK)
			{
				txtUsuario.Text = form.usuario();
			}
			else
			{ this.Close(); }
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
