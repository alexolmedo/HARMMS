namespace Proyecto.OrdenesTrabajo
{
    partial class ModificarOrdenD
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
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDD = new System.Windows.Forms.GroupBox();
            this.horaDomicilio = new System.Windows.Forms.DateTimePicker();
            this.fechaDomicilio = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoDomicilio = new System.Windows.Forms.ComboBox();
            this.txtDescripcionDomicilio = new System.Windows.Forms.TextBox();
            this.txtCostoDomicilio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txtOrdenDomicilio = new System.Windows.Forms.TextBox();
            this.cbHabilitadaDomicilio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxDD.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = global::Proyecto.Properties.Resources.actualizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(690, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 32);
            this.button3.TabIndex = 32;
            this.button3.Text = "Actualizar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::Proyecto.Properties.Resources.cancel1;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(496, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 32);
            this.button7.TabIndex = 64;
            this.button7.Text = "Cerrar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Habilitada";
            // 
            // groupBoxDD
            // 
            this.groupBoxDD.Controls.Add(this.horaDomicilio);
            this.groupBoxDD.Controls.Add(this.fechaDomicilio);
            this.groupBoxDD.Controls.Add(this.cbEstadoDomicilio);
            this.groupBoxDD.Controls.Add(this.txtDescripcionDomicilio);
            this.groupBoxDD.Controls.Add(this.txtCostoDomicilio);
            this.groupBoxDD.Controls.Add(this.label13);
            this.groupBoxDD.Controls.Add(this.comboBox5);
            this.groupBoxDD.Controls.Add(this.label14);
            this.groupBoxDD.Controls.Add(this.label15);
            this.groupBoxDD.Controls.Add(this.label16);
            this.groupBoxDD.Controls.Add(this.label17);
            this.groupBoxDD.Controls.Add(this.label18);
            this.groupBoxDD.Location = new System.Drawing.Point(10, 159);
            this.groupBoxDD.Name = "groupBoxDD";
            this.groupBoxDD.Size = new System.Drawing.Size(553, 142);
            this.groupBoxDD.TabIndex = 61;
            this.groupBoxDD.TabStop = false;
            this.groupBoxDD.Text = "Detalle Orden de Trabajo";
            // 
            // horaDomicilio
            // 
            this.horaDomicilio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaDomicilio.Location = new System.Drawing.Point(459, 29);
            this.horaDomicilio.Name = "horaDomicilio";
            this.horaDomicilio.Size = new System.Drawing.Size(80, 20);
            this.horaDomicilio.TabIndex = 68;
            // 
            // fechaDomicilio
            // 
            this.fechaDomicilio.Location = new System.Drawing.Point(117, 29);
            this.fechaDomicilio.Name = "fechaDomicilio";
            this.fechaDomicilio.Size = new System.Drawing.Size(199, 20);
            this.fechaDomicilio.TabIndex = 67;
            // 
            // cbEstadoDomicilio
            // 
            this.cbEstadoDomicilio.FormattingEnabled = true;
            this.cbEstadoDomicilio.Items.AddRange(new object[] {
            "Entregada",
            "Sin Entregar"});
            this.cbEstadoDomicilio.Location = new System.Drawing.Point(117, 112);
            this.cbEstadoDomicilio.Name = "cbEstadoDomicilio";
            this.cbEstadoDomicilio.Size = new System.Drawing.Size(199, 21);
            this.cbEstadoDomicilio.TabIndex = 66;
            // 
            // txtDescripcionDomicilio
            // 
            this.txtDescripcionDomicilio.Location = new System.Drawing.Point(117, 61);
            this.txtDescripcionDomicilio.Multiline = true;
            this.txtDescripcionDomicilio.Name = "txtDescripcionDomicilio";
            this.txtDescripcionDomicilio.Size = new System.Drawing.Size(423, 40);
            this.txtDescripcionDomicilio.TabIndex = 19;
            // 
            // txtCostoDomicilio
            // 
            this.txtCostoDomicilio.Location = new System.Drawing.Point(459, 109);
            this.txtCostoDomicilio.Name = "txtCostoDomicilio";
            this.txtCostoDomicilio.Size = new System.Drawing.Size(81, 20);
            this.txtCostoDomicilio.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Estado";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(145, 208);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 21);
            this.comboBox5.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(96, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Costo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Descripción";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(368, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Hora Cita";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Fecha de Cita";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "Número";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Location = new System.Drawing.Point(10, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 99);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 73);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "Dirección";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Teléfono";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(85, 70);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(454, 20);
            this.textBox11.TabIndex = 8;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(85, 44);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(153, 20);
            this.textBox12.TabIndex = 7;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(308, 17);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(231, 20);
            this.textBox13.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(258, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Nombre";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Cédula";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(85, 18);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(153, 20);
            this.textBox14.TabIndex = 0;
            // 
            // txtOrdenDomicilio
            // 
            this.txtOrdenDomicilio.Location = new System.Drawing.Point(109, 22);
            this.txtOrdenDomicilio.Name = "txtOrdenDomicilio";
            this.txtOrdenDomicilio.Size = new System.Drawing.Size(101, 20);
            this.txtOrdenDomicilio.TabIndex = 58;
            // 
            // cbHabilitadaDomicilio
            // 
            this.cbHabilitadaDomicilio.FormattingEnabled = true;
            this.cbHabilitadaDomicilio.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbHabilitadaDomicilio.Location = new System.Drawing.Point(429, 22);
            this.cbHabilitadaDomicilio.Name = "cbHabilitadaDomicilio";
            this.cbHabilitadaDomicilio.Size = new System.Drawing.Size(121, 21);
            this.cbHabilitadaDomicilio.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.Notepad;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(415, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 66;
            this.button1.Text = "Modificar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ModificarOrdenD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbHabilitadaDomicilio);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDD);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtOrdenDomicilio);
            this.Controls.Add(this.button3);
            this.Name = "ModificarOrdenD";
            this.Text = "Modificar Orden a Domicilio";
            this.groupBoxDD.ResumeLayout(false);
            this.groupBoxDD.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDD;
        private System.Windows.Forms.TextBox txtDescripcionDomicilio;
        private System.Windows.Forms.TextBox txtCostoDomicilio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox txtOrdenDomicilio;
        private System.Windows.Forms.ComboBox cbHabilitadaDomicilio;
        private System.Windows.Forms.ComboBox cbEstadoDomicilio;
        private System.Windows.Forms.DateTimePicker horaDomicilio;
        private System.Windows.Forms.DateTimePicker fechaDomicilio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}