﻿using CapaVistaRRHH;
using CapaVistaSeguridadHSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDIRRHH : Form
    {
        public MDIRRHH()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else { this.Close(); }
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPuesto form3 = new frmPuesto();
            //form3.MdiParent = this.MdiParent;
            //form3.Show();
            //form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void tsmEmpleados_Click(object sender, EventArgs e)
        {
            frmBanco form3 = new frmBanco();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                string user = form.usuario();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void nominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentaContable form3 = new frmCuentaContable();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void perfilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmPrestacionesLaborales form3 = new frmPrestacionesLaborales();
            //form3.MdiParent = this.MdiParent;
            //form3.Show();
            //form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void desarrolloDeCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentaBancaria form3 = new frmCuentaBancaria();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void bitacoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void enlacesContabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEnlacesContable form3 = new frmEnlacesContable();
            //form3.MdiParent = this.MdiParent;
            //.Show();
        }

        private void btnGenerarNóminas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCierreDeNominas_Click(object sender, EventArgs e)
        {
            //frmVerNominas form3 = new frmVerNominas();
            //form3.MdiParent = this.MdiParent;
            //form3.Show();
        }

        private void btnVerCierresDeNomina_Click(object sender, EventArgs e)
        {
            //frmVerCierresDeNomina form3 = new frmVerCierresDeNomina();
            //form3.MdiParent = this.MdiParent;
            //form3.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientoBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanco form3 = new frmBanco();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void mantenimientoCuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentaBancaria form3 = new frmCuentaBancaria();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void mantenimientoCuentaContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentaContable form3 = new frmCuentaContable();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void mantenimientoTipoDeMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoMovimiento form3 = new frmTipoMovimiento();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientosBancarios form3 = new frmMovimientosBancarios();
            form3.MdiParent = this.MdiParent;
            form3.Show();
            form3.funActualizarUsuario(txtUsuario.Text);
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora form3 = new frmBitacora();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }
    }
}