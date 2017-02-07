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
            this.Venta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumSerIngElectR = new System.Windows.Forms.TextBox();
            this.txtModeloIngElectR = new System.Windows.Forms.TextBox();
            this.txtNombreIngElectR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Venta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Venta
            // 
            this.Venta.Controls.Add(this.tabPage1);
            this.Venta.Controls.Add(this.tabPage2);
            this.Venta.Location = new System.Drawing.Point(3, 1);
            this.Venta.Name = "Venta";
            this.Venta.SelectedIndex = 0;
            this.Venta.Size = new System.Drawing.Size(462, 380);
            this.Venta.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.Agregar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            // 
            // Agregar
            // 
            this.Agregar.Image = global::Proyecto.Properties.Resources.new2;
            this.Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar.Location = new System.Drawing.Point(197, 312);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(68, 29);
            this.Agregar.TabIndex = 53;
            this.Agregar.Text = "Agregar";
            this.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto.Properties.Resources.cancel1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(352, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 29);
            this.button2.TabIndex = 52;
            this.button2.Text = "Cerrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 274);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Electrodoméstico Usado";
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
            this.cbMesesIngElectV.Location = new System.Drawing.Point(262, 237);
            this.cbMesesIngElectV.Name = "cbMesesIngElectV";
            this.cbMesesIngElectV.Size = new System.Drawing.Size(75, 21);
            this.cbMesesIngElectV.TabIndex = 49;
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
            this.cbAñosIngElectV.Location = new System.Drawing.Point(197, 237);
            this.cbAñosIngElectV.Name = "cbAñosIngElectV";
            this.cbAñosIngElectV.Size = new System.Drawing.Size(59, 21);
            this.cbAñosIngElectV.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tiempo de uso";
            // 
            // txtDueñoAntIngElectV
            // 
            this.txtDueñoAntIngElectV.Location = new System.Drawing.Point(197, 195);
            this.txtDueñoAntIngElectV.Name = "txtDueñoAntIngElectV";
            this.txtDueñoAntIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtDueñoAntIngElectV.TabIndex = 46;
            // 
            // txtPrecioIngElectV
            // 
            this.txtPrecioIngElectV.Location = new System.Drawing.Point(197, 155);
            this.txtPrecioIngElectV.Name = "txtPrecioIngElectV";
            this.txtPrecioIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtPrecioIngElectV.TabIndex = 45;
            // 
            // txtNumSerIngElectV
            // 
            this.txtNumSerIngElectV.Location = new System.Drawing.Point(197, 115);
            this.txtNumSerIngElectV.Name = "txtNumSerIngElectV";
            this.txtNumSerIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtNumSerIngElectV.TabIndex = 44;
            // 
            // txtModeloIngElectV
            // 
            this.txtModeloIngElectV.Location = new System.Drawing.Point(197, 78);
            this.txtModeloIngElectV.Name = "txtModeloIngElectV";
            this.txtModeloIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtModeloIngElectV.TabIndex = 43;
            // 
            // txtNombreIngElectV
            // 
            this.txtNombreIngElectV.Location = new System.Drawing.Point(197, 37);
            this.txtNombreIngElectV.Name = "txtNombreIngElectV";
            this.txtNombreIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtNombreIngElectV.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dueño Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Número de Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.blanco3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(271, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 51;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reparación";
            // 
            // button6
            // 
            this.button6.Image = global::Proyecto.Properties.Resources.new2;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(199, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 29);
            this.button6.TabIndex = 44;
            this.button6.Text = "Agregar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Proyecto.Properties.Resources.cancel1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(354, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 29);
            this.button3.TabIndex = 43;
            this.button3.Text = "Cerrar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Proyecto.Properties.Resources.blanco3;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(273, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 42;
            this.button4.Text = "Nuevo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumSerIngElectR);
            this.groupBox2.Controls.Add(this.txtModeloIngElectR);
            this.groupBox2.Controls.Add(this.txtNombreIngElectR);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(29, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 160);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Electrodoméstico";
            // 
            // txtNumSerIngElectR
            // 
            this.txtNumSerIngElectR.Location = new System.Drawing.Point(197, 115);
            this.txtNumSerIngElectR.Name = "txtNumSerIngElectR";
            this.txtNumSerIngElectR.Size = new System.Drawing.Size(140, 20);
            this.txtNumSerIngElectR.TabIndex = 44;
            // 
            // txtModeloIngElectR
            // 
            this.txtModeloIngElectR.Location = new System.Drawing.Point(196, 78);
            this.txtModeloIngElectR.Name = "txtModeloIngElectR";
            this.txtModeloIngElectR.Size = new System.Drawing.Size(140, 20);
            this.txtModeloIngElectR.TabIndex = 43;
            // 
            // txtNombreIngElectR
            // 
            this.txtNombreIngElectR.Location = new System.Drawing.Point(197, 37);
            this.txtNombreIngElectR.Name = "txtNombreIngElectR";
            this.txtNombreIngElectR.Size = new System.Drawing.Size(140, 20);
            this.txtNombreIngElectR.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Número de Serie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Modelo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Nombre";
            // 
            // IngresarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(460, 376);
            this.Controls.Add(this.Venta);
            this.Name = "IngresarCompra";
            this.Text = "Ingresar Electrodoméstico";
            this.Venta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Venta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumSerIngElectR;
        private System.Windows.Forms.TextBox txtModeloIngElectR;
        private System.Windows.Forms.TextBox txtNombreIngElectR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button button6;




    }
}