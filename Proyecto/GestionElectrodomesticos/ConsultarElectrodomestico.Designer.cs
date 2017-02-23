namespace Proyecto.GestionElectrodomesticos
{
    partial class ConsultarElectrodomestico
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPorNumSer = new System.Windows.Forms.TextBox();
            this.butBuscar = new System.Windows.Forms.Button();
            this.txtPorModelo = new System.Windows.Forms.TextBox();
            this.radioButNumSerie = new System.Windows.Forms.RadioButton();
            this.radioButModelo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTiempoUso = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textContacto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPrVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPropAnterior = new System.Windows.Forms.TextBox();
            this.txtPrCompra = new System.Windows.Forms.TextBox();
            this.txtNumSer = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Proyecto.Properties.Resources.cancel1;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(519, 293);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(67, 32);
            this.btnCerrar.TabIndex = 47;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrarAgrCliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPorNumSer);
            this.groupBox3.Controls.Add(this.butBuscar);
            this.groupBox3.Controls.Add(this.txtPorModelo);
            this.groupBox3.Controls.Add(this.radioButNumSerie);
            this.groupBox3.Controls.Add(this.radioButModelo);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 95);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // txtPorNumSer
            // 
            this.txtPorNumSer.Location = new System.Drawing.Point(228, 60);
            this.txtPorNumSer.Name = "txtPorNumSer";
            this.txtPorNumSer.ReadOnly = true;
            this.txtPorNumSer.Size = new System.Drawing.Size(184, 20);
            this.txtPorNumSer.TabIndex = 3;
            this.txtPorNumSer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorNumSer_KeyPress);
            // 
            // butBuscar
            // 
            this.butBuscar.Image = global::Proyecto.Properties.Resources.buscar;
            this.butBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBuscar.Location = new System.Drawing.Point(459, 38);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(75, 32);
            this.butBuscar.TabIndex = 30;
            this.butBuscar.Text = "Buscar";
            this.butBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPorModelo
            // 
            this.txtPorModelo.Location = new System.Drawing.Point(228, 28);
            this.txtPorModelo.Name = "txtPorModelo";
            this.txtPorModelo.ReadOnly = true;
            this.txtPorModelo.Size = new System.Drawing.Size(184, 20);
            this.txtPorModelo.TabIndex = 2;
            // 
            // radioButNumSerie
            // 
            this.radioButNumSerie.AutoSize = true;
            this.radioButNumSerie.Location = new System.Drawing.Point(51, 60);
            this.radioButNumSerie.Name = "radioButNumSerie";
            this.radioButNumSerie.Size = new System.Drawing.Size(104, 17);
            this.radioButNumSerie.TabIndex = 1;
            this.radioButNumSerie.TabStop = true;
            this.radioButNumSerie.Text = "Número de Serie";
            this.radioButNumSerie.UseVisualStyleBackColor = true;
            this.radioButNumSerie.CheckedChanged += new System.EventHandler(this.radioButNumSerie_CheckedChanged);
            // 
            // radioButModelo
            // 
            this.radioButModelo.AutoSize = true;
            this.radioButModelo.Location = new System.Drawing.Point(51, 28);
            this.radioButModelo.Name = "radioButModelo";
            this.radioButModelo.Size = new System.Drawing.Size(60, 17);
            this.radioButModelo.TabIndex = 0;
            this.radioButModelo.TabStop = true;
            this.radioButModelo.Text = "Modelo";
            this.radioButModelo.UseVisualStyleBackColor = true;
            this.radioButModelo.CheckedChanged += new System.EventHandler(this.radioButModelo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTiempoUso);
            this.groupBox1.Controls.Add(this.textEstado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textContacto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textPrVenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPropAnterior);
            this.groupBox1.Controls.Add(this.txtPrCompra);
            this.groupBox1.Controls.Add(this.txtNumSer);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 173);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Electrodoméstico Usado";
            // 
            // textTiempoUso
            // 
            this.textTiempoUso.Location = new System.Drawing.Point(415, 33);
            this.textTiempoUso.Name = "textTiempoUso";
            this.textTiempoUso.ReadOnly = true;
            this.textTiempoUso.Size = new System.Drawing.Size(140, 20);
            this.textTiempoUso.TabIndex = 73;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(415, 143);
            this.textEstado.Name = "textEstado";
            this.textEstado.ReadOnly = true;
            this.textEstado.Size = new System.Drawing.Size(140, 20);
            this.textEstado.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Estado";
            // 
            // textContacto
            // 
            this.textContacto.Location = new System.Drawing.Point(415, 116);
            this.textContacto.Name = "textContacto";
            this.textContacto.ReadOnly = true;
            this.textContacto.Size = new System.Drawing.Size(140, 20);
            this.textContacto.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Contacto:";
            // 
            // textPrVenta
            // 
            this.textPrVenta.Location = new System.Drawing.Point(121, 143);
            this.textPrVenta.Name = "textPrVenta";
            this.textPrVenta.ReadOnly = true;
            this.textPrVenta.Size = new System.Drawing.Size(140, 20);
            this.textPrVenta.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Precio de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tiempo de uso";
            // 
            // txtPropAnterior
            // 
            this.txtPropAnterior.Location = new System.Drawing.Point(415, 88);
            this.txtPropAnterior.Name = "txtPropAnterior";
            this.txtPropAnterior.ReadOnly = true;
            this.txtPropAnterior.Size = new System.Drawing.Size(140, 20);
            this.txtPropAnterior.TabIndex = 63;
            // 
            // txtPrCompra
            // 
            this.txtPrCompra.Location = new System.Drawing.Point(121, 116);
            this.txtPrCompra.Name = "txtPrCompra";
            this.txtPrCompra.ReadOnly = true;
            this.txtPrCompra.Size = new System.Drawing.Size(140, 20);
            this.txtPrCompra.TabIndex = 62;
            // 
            // txtNumSer
            // 
            this.txtNumSer.Location = new System.Drawing.Point(121, 88);
            this.txtNumSer.Name = "txtNumSer";
            this.txtNumSer.ReadOnly = true;
            this.txtNumSer.Size = new System.Drawing.Size(140, 20);
            this.txtNumSer.TabIndex = 61;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(121, 62);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(434, 20);
            this.txtModelo.TabIndex = 60;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Propietario Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Número de Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Nombre";
            // 
            // ConsultarElectrodomestico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 332);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarElectrodomestico";
            this.Text = "Consultar Electrodoméstico";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPorNumSer;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.TextBox txtPorModelo;
        private System.Windows.Forms.RadioButton radioButNumSerie;
        private System.Windows.Forms.RadioButton radioButModelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textTiempoUso;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textContacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPrVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPropAnterior;
        private System.Windows.Forms.TextBox txtPrCompra;
        private System.Windows.Forms.TextBox txtNumSer;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;

    }
}