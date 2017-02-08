﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.OrdenesTrabajo
{
    public partial class IngresarOrden : Form
    {
        public IngresarOrden()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cliente.SeleccionarCliente().Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.SeleccionarElectrodomestico().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.IngresarCompra().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
