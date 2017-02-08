namespace Proyecto.Cliente
{
    partial class ActualizarCliente
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.correoActCliente = new System.Windows.Forms.TextBox();
            this.RUCActCliente = new System.Windows.Forms.TextBox();
            this.dirActCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telActCliente = new System.Windows.Forms.TextBox();
            this.cedActCliente = new System.Windows.Forms.TextBox();
            this.nomActCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.radioButCed = new System.Windows.Forms.RadioButton();
            this.radioButNombre = new System.Windows.Forms.RadioButton();
            this.btnCerrarAgrCliente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.correoActCliente);
            this.groupBox2.Controls.Add(this.RUCActCliente);
            this.groupBox2.Controls.Add(this.dirActCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.telActCliente);
            this.groupBox2.Controls.Add(this.cedActCliente);
            this.groupBox2.Controls.Add(this.nomActCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 163);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // correoActCliente
            // 
            this.correoActCliente.Location = new System.Drawing.Point(330, 109);
            this.correoActCliente.Name = "correoActCliente";
            this.correoActCliente.Size = new System.Drawing.Size(121, 20);
            this.correoActCliente.TabIndex = 60;
            // 
            // RUCActCliente
            // 
            this.RUCActCliente.Location = new System.Drawing.Point(330, 71);
            this.RUCActCliente.Name = "RUCActCliente";
            this.RUCActCliente.Size = new System.Drawing.Size(121, 20);
            this.RUCActCliente.TabIndex = 59;
            this.RUCActCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RUCAgrCliente_KeyPress);
            // 
            // dirActCliente
            // 
            this.dirActCliente.Location = new System.Drawing.Point(330, 31);
            this.dirActCliente.Name = "dirActCliente";
            this.dirActCliente.Size = new System.Drawing.Size(121, 20);
            this.dirActCliente.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "RUC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Dirección";
            // 
            // telActCliente
            // 
            this.telActCliente.Location = new System.Drawing.Point(85, 107);
            this.telActCliente.Name = "telActCliente";
            this.telActCliente.Size = new System.Drawing.Size(126, 20);
            this.telActCliente.TabIndex = 42;
            this.telActCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telAgrCliente_KeyPress);
            // 
            // cedActCliente
            // 
            this.cedActCliente.Location = new System.Drawing.Point(85, 70);
            this.cedActCliente.Name = "cedActCliente";
            this.cedActCliente.ReadOnly = true;
            this.cedActCliente.Size = new System.Drawing.Size(126, 20);
            this.cedActCliente.TabIndex = 41;
            this.cedActCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedAgrCliente_KeyPress);
            // 
            // nomActCliente
            // 
            this.nomActCliente.Location = new System.Drawing.Point(85, 34);
            this.nomActCliente.Name = "nomActCliente";
            this.nomActCliente.Size = new System.Drawing.Size(126, 20);
            this.nomActCliente.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cédula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto.Properties.Resources.buscar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(222, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.actualizar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(339, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.radioButCed);
            this.groupBox1.Controls.Add(this.radioButNombre);
            this.groupBox1.Location = new System.Drawing.Point(34, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 123);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(202, 80);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(167, 20);
            this.txtCedula.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // radioButCed
            // 
            this.radioButCed.AutoSize = true;
            this.radioButCed.Location = new System.Drawing.Point(70, 80);
            this.radioButCed.Name = "radioButCed";
            this.radioButCed.Size = new System.Drawing.Size(58, 17);
            this.radioButCed.TabIndex = 19;
            this.radioButCed.TabStop = true;
            this.radioButCed.Text = "Cédula";
            this.radioButCed.UseVisualStyleBackColor = true;
            this.radioButCed.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButNombre
            // 
            this.radioButNombre.AutoSize = true;
            this.radioButNombre.Location = new System.Drawing.Point(70, 33);
            this.radioButNombre.Name = "radioButNombre";
            this.radioButNombre.Size = new System.Drawing.Size(62, 17);
            this.radioButNombre.TabIndex = 18;
            this.radioButNombre.TabStop = true;
            this.radioButNombre.Text = "Nombre";
            this.radioButNombre.UseVisualStyleBackColor = true;
            this.radioButNombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnCerrarAgrCliente
            // 
            this.btnCerrarAgrCliente.Image = global::Proyecto.Properties.Resources.cancel1;
            this.btnCerrarAgrCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarAgrCliente.Location = new System.Drawing.Point(434, 378);
            this.btnCerrarAgrCliente.Name = "btnCerrarAgrCliente";
            this.btnCerrarAgrCliente.Size = new System.Drawing.Size(67, 32);
            this.btnCerrarAgrCliente.TabIndex = 41;
            this.btnCerrarAgrCliente.Text = "Cerrar";
            this.btnCerrarAgrCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarAgrCliente.UseVisualStyleBackColor = true;
            this.btnCerrarAgrCliente.Click += new System.EventHandler(this.btnCerrarAgrCliente_Click);
            // 
            // ActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 419);
            this.Controls.Add(this.btnCerrarAgrCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Name = "ActualizarCliente";
            this.Text = "Actualizar Cliente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox telActCliente;
        private System.Windows.Forms.TextBox cedActCliente;
        private System.Windows.Forms.TextBox nomActCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox correoActCliente;
        private System.Windows.Forms.TextBox RUCActCliente;
        private System.Windows.Forms.TextBox dirActCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton radioButCed;
        private System.Windows.Forms.RadioButton radioButNombre;
        private System.Windows.Forms.Button btnCerrarAgrCliente;
    }
}