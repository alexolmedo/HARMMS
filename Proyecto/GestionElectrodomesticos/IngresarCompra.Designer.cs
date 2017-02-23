namespace Proyecto.GestionElectrodomesticos
{
    partial class IngresarCompra
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
            this.Agregar = new System.Windows.Forms.Button();
            this.butCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConacto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.cbAños = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDueñoAnt = new System.Windows.Forms.TextBox();
            this.txtPrCompra = new System.Windows.Forms.TextBox();
            this.txtNumSer = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Image = global::Proyecto.Properties.Resources.new2;
            this.Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar.Location = new System.Drawing.Point(400, 199);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(68, 29);
            this.Agregar.TabIndex = 51;
            this.Agregar.Text = "Agregar";
            this.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // butCerrar
            // 
            this.butCerrar.Image = global::Proyecto.Properties.Resources.cancel1;
            this.butCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCerrar.Location = new System.Drawing.Point(555, 199);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(67, 29);
            this.butCerrar.TabIndex = 53;
            this.butCerrar.Text = "Cerrar";
            this.butCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConacto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrVenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMeses);
            this.groupBox1.Controls.Add(this.cbAños);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDueñoAnt);
            this.groupBox1.Controls.Add(this.txtPrCompra);
            this.groupBox1.Controls.Add(this.txtNumSer);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 175);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Electrodoméstico Usado";
            // 
            // txtConacto
            // 
            this.txtConacto.Location = new System.Drawing.Point(453, 97);
            this.txtConacto.MaxLength = 10;
            this.txtConacto.Name = "txtConacto";
            this.txtConacto.Size = new System.Drawing.Size(140, 20);
            this.txtConacto.TabIndex = 49;
            this.txtConacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConacto_KeyPress);
            this.txtConacto.Leave += new System.EventHandler(this.txtConacto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Contacto:";
            // 
            // txtPrVenta
            // 
            this.txtPrVenta.Location = new System.Drawing.Point(453, 137);
            this.txtPrVenta.MaxLength = 7;
            this.txtPrVenta.Name = "txtPrVenta";
            this.txtPrVenta.Size = new System.Drawing.Size(140, 20);
            this.txtPrVenta.TabIndex = 50;
            this.txtPrVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrVenta_KeyPress);
            this.txtPrVenta.Leave += new System.EventHandler(this.txtPrVenta_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Precio de Venta";
            // 
            // cbMeses
            // 
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.Items.AddRange(new object[] {
            "-",
            "1 mes",
            "2 meses",
            "3 meses",
            "4 meses",
            "5 meses",
            "6 meses",
            "7 meses",
            "8 meses",
            "9 meses",
            "10 meses",
            "11 meses"});
            this.cbMeses.Location = new System.Drawing.Point(518, 23);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(75, 21);
            this.cbMeses.TabIndex = 47;
            // 
            // cbAños
            // 
            this.cbAños.FormattingEnabled = true;
            this.cbAños.Items.AddRange(new object[] {
            "-",
            "1 Año",
            "2 Años",
            "3 Años",
            "4 Años",
            "5 Años",
            "6 Años",
            "7 Años",
            "9 Años",
            "10 Años"});
            this.cbAños.Location = new System.Drawing.Point(453, 23);
            this.cbAños.Name = "cbAños";
            this.cbAños.Size = new System.Drawing.Size(59, 21);
            this.cbAños.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tiempo de uso";
            // 
            // txtDueñoAnt
            // 
            this.txtDueñoAnt.Location = new System.Drawing.Point(453, 63);
            this.txtDueñoAnt.MaxLength = 60;
            this.txtDueñoAnt.Name = "txtDueñoAnt";
            this.txtDueñoAnt.Size = new System.Drawing.Size(140, 20);
            this.txtDueñoAnt.TabIndex = 48;
            this.txtDueñoAnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDueñoAnt_KeyPress);
            this.txtDueñoAnt.Leave += new System.EventHandler(this.txtDueñoAnt_Leave);
            // 
            // txtPrCompra
            // 
            this.txtPrCompra.Location = new System.Drawing.Point(140, 137);
            this.txtPrCompra.MaxLength = 7;
            this.txtPrCompra.Name = "txtPrCompra";
            this.txtPrCompra.Size = new System.Drawing.Size(140, 20);
            this.txtPrCompra.TabIndex = 45;
            this.txtPrCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrCompra_KeyPress);
            this.txtPrCompra.Leave += new System.EventHandler(this.txtPrCompra_Leave);
            // 
            // txtNumSer
            // 
            this.txtNumSer.Location = new System.Drawing.Point(140, 26);
            this.txtNumSer.MaxLength = 15;
            this.txtNumSer.Name = "txtNumSer";
            this.txtNumSer.Size = new System.Drawing.Size(140, 20);
            this.txtNumSer.TabIndex = 42;
            this.txtNumSer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumSer_KeyPress);
            this.txtNumSer.Leave += new System.EventHandler(this.txtNumSer_Leave);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(140, 60);
            this.txtModelo.MaxLength = 30;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(140, 20);
            this.txtModelo.TabIndex = 43;
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 97);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 44;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Propietario Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Número de Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tipo";
            // 
            // butNuevo
            // 
            this.butNuevo.Image = global::Proyecto.Properties.Resources.blanco3;
            this.butNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butNuevo.Location = new System.Drawing.Point(474, 199);
            this.butNuevo.Name = "butNuevo";
            this.butNuevo.Size = new System.Drawing.Size(75, 29);
            this.butNuevo.TabIndex = 52;
            this.butNuevo.Text = "Nuevo";
            this.butNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butNuevo.UseVisualStyleBackColor = true;
            this.butNuevo.Click += new System.EventHandler(this.butNuevo_Click);
            // 
            // IngresarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 235);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butNuevo);
            this.Name = "IngresarCompra";
            this.Text = "Ingresar Electrodoméstico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.ComboBox cbAños;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDueñoAnt;
        private System.Windows.Forms.TextBox txtPrCompra;
        private System.Windows.Forms.TextBox txtNumSer;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butNuevo;





    }
}