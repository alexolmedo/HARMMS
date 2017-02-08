namespace Proyecto.GestionElectrodomesticos
{
    partial class ModificarCompra
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPorNumSer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPorModelo = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMesesIngElectV = new System.Windows.Forms.ComboBox();
            this.cbAñosIngElectV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDueñoAntIngElectV = new System.Windows.Forms.TextBox();
            this.txtPrecioIngElectV = new System.Windows.Forms.TextBox();
            this.txtNumSerIngElectV = new System.Windows.Forms.TextBox();
            this.txtModeloIngElectV = new System.Windows.Forms.TextBox();
            this.txtNombreIngElectV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.actualizar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(415, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPorNumSer);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtPorModelo);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 95);
            this.groupBox3.TabIndex = 33;
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
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto.Properties.Resources.buscar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(459, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 30;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPorModelo
            // 
            this.txtPorModelo.Location = new System.Drawing.Point(228, 28);
            this.txtPorModelo.Name = "txtPorModelo";
            this.txtPorModelo.ReadOnly = true;
            this.txtPorModelo.Size = new System.Drawing.Size(184, 20);
            this.txtPorModelo.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(51, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Por Número de Serie";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por Modelo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMesesIngElectV);
            this.groupBox1.Controls.Add(this.cbAñosIngElectV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDueñoAntIngElectV);
            this.groupBox1.Controls.Add(this.txtPrecioIngElectV);
            this.groupBox1.Controls.Add(this.txtNumSerIngElectV);
            this.groupBox1.Controls.Add(this.txtModeloIngElectV);
            this.groupBox1.Controls.Add(this.txtNombreIngElectV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 192);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Electrodoméstico Usado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Contacto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Precio de Venta";
            // 
            // cbMesesIngElectV
            // 
            this.cbMesesIngElectV.FormattingEnabled = true;
            this.cbMesesIngElectV.Items.AddRange(new object[] {
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
            "11 meses",
            "12 meses"});
            this.cbMesesIngElectV.Location = new System.Drawing.Point(480, 32);
            this.cbMesesIngElectV.Name = "cbMesesIngElectV";
            this.cbMesesIngElectV.Size = new System.Drawing.Size(75, 21);
            this.cbMesesIngElectV.TabIndex = 66;
            // 
            // cbAñosIngElectV
            // 
            this.cbAñosIngElectV.FormattingEnabled = true;
            this.cbAñosIngElectV.Items.AddRange(new object[] {
            "1 Año",
            "2 Años",
            "3 Años",
            "4 Años",
            "5 Años"});
            this.cbAñosIngElectV.Location = new System.Drawing.Point(415, 32);
            this.cbAñosIngElectV.Name = "cbAñosIngElectV";
            this.cbAñosIngElectV.Size = new System.Drawing.Size(59, 21);
            this.cbAñosIngElectV.TabIndex = 65;
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
            // txtDueñoAntIngElectV
            // 
            this.txtDueñoAntIngElectV.Location = new System.Drawing.Point(415, 69);
            this.txtDueñoAntIngElectV.Name = "txtDueñoAntIngElectV";
            this.txtDueñoAntIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtDueñoAntIngElectV.TabIndex = 63;
            // 
            // txtPrecioIngElectV
            // 
            this.txtPrecioIngElectV.Location = new System.Drawing.Point(121, 143);
            this.txtPrecioIngElectV.Name = "txtPrecioIngElectV";
            this.txtPrecioIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtPrecioIngElectV.TabIndex = 62;
            // 
            // txtNumSerIngElectV
            // 
            this.txtNumSerIngElectV.Location = new System.Drawing.Point(121, 103);
            this.txtNumSerIngElectV.Name = "txtNumSerIngElectV";
            this.txtNumSerIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtNumSerIngElectV.TabIndex = 61;
            // 
            // txtModeloIngElectV
            // 
            this.txtModeloIngElectV.Location = new System.Drawing.Point(121, 69);
            this.txtModeloIngElectV.Name = "txtModeloIngElectV";
            this.txtModeloIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtModeloIngElectV.TabIndex = 60;
            // 
            // txtNombreIngElectV
            // 
            this.txtNombreIngElectV.Location = new System.Drawing.Point(121, 33);
            this.txtNombreIngElectV.Name = "txtNombreIngElectV";
            this.txtNombreIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtNombreIngElectV.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Propietario Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Número de Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 73);
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
            // ModificarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarCompra";
            this.Text = "Actualizar Electrodoméstico";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPorNumSer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPorModelo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMesesIngElectV;
        private System.Windows.Forms.ComboBox cbAñosIngElectV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDueñoAntIngElectV;
        private System.Windows.Forms.TextBox txtPrecioIngElectV;
        private System.Windows.Forms.TextBox txtNumSerIngElectV;
        private System.Windows.Forms.TextBox txtModeloIngElectV;
        private System.Windows.Forms.TextBox txtNombreIngElectV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;


    }
}