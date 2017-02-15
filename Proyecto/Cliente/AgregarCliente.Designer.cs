namespace Proyecto.Cliente
{
    partial class AgregarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCorreoAgrCliente = new System.Windows.Forms.TextBox();
            this.txtRUCAgrCliente = new System.Windows.Forms.TextBox();
            this.txtDirecAgrCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelAgrCliente = new System.Windows.Forms.TextBox();
            this.txtCedAgrCliente = new System.Windows.Forms.TextBox();
            this.txtNomAgrCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarAgrCliente = new System.Windows.Forms.Button();
            this.btnNuevoAgrCliente = new System.Windows.Forms.Button();
            this.btnAgregarAgrCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCorreoAgrCliente);
            this.groupBox1.Controls.Add(this.txtRUCAgrCliente);
            this.groupBox1.Controls.Add(this.txtDirecAgrCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelAgrCliente);
            this.groupBox1.Controls.Add(this.txtCedAgrCliente);
            this.groupBox1.Controls.Add(this.txtNomAgrCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 243);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtCorreoAgrCliente
            // 
            this.txtCorreoAgrCliente.Location = new System.Drawing.Point(168, 213);
            this.txtCorreoAgrCliente.Name = "txtCorreoAgrCliente";
            this.txtCorreoAgrCliente.Size = new System.Drawing.Size(187, 20);
            this.txtCorreoAgrCliente.TabIndex = 36;
            this.txtCorreoAgrCliente.Leave += new System.EventHandler(this.txtCorreoAgrCliente_Leave);
            // 
            // txtRUCAgrCliente
            // 
            this.txtRUCAgrCliente.Location = new System.Drawing.Point(168, 175);
            this.txtRUCAgrCliente.MaxLength = 13;
            this.txtRUCAgrCliente.Name = "txtRUCAgrCliente";
            this.txtRUCAgrCliente.Size = new System.Drawing.Size(187, 20);
            this.txtRUCAgrCliente.TabIndex = 35;
            this.txtRUCAgrCliente.TextChanged += new System.EventHandler(this.txtRUCAgrCliente_TextChanged);
            this.txtRUCAgrCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUCAgrCliente_KeyPress);
            this.txtRUCAgrCliente.Leave += new System.EventHandler(this.txtRUCAgrCliente_Leave);
            // 
            // txtDirecAgrCliente
            // 
            this.txtDirecAgrCliente.Location = new System.Drawing.Point(168, 135);
            this.txtDirecAgrCliente.MaxLength = 150;
            this.txtDirecAgrCliente.Name = "txtDirecAgrCliente";
            this.txtDirecAgrCliente.Size = new System.Drawing.Size(187, 20);
            this.txtDirecAgrCliente.TabIndex = 34;
            this.txtDirecAgrCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirecAgrCliente_KeyPress);
            this.txtDirecAgrCliente.Leave += new System.EventHandler(this.txtDirecAgrCliente_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Correo *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "RUC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Dirección *";
            // 
            // txtTelAgrCliente
            // 
            this.txtTelAgrCliente.Location = new System.Drawing.Point(168, 95);
            this.txtTelAgrCliente.MaxLength = 10;
            this.txtTelAgrCliente.Name = "txtTelAgrCliente";
            this.txtTelAgrCliente.Size = new System.Drawing.Size(187, 20);
            this.txtTelAgrCliente.TabIndex = 30;
            this.txtTelAgrCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelAgrCliente_KeyPress);
            this.txtTelAgrCliente.Leave += new System.EventHandler(this.txtTelAgrCliente_Leave);
            // 
            // txtCedAgrCliente
            // 
            this.txtCedAgrCliente.Location = new System.Drawing.Point(168, 58);
            this.txtCedAgrCliente.MaxLength = 10;
            this.txtCedAgrCliente.Name = "txtCedAgrCliente";
            this.txtCedAgrCliente.Size = new System.Drawing.Size(187, 20);
            this.txtCedAgrCliente.TabIndex = 29;
            this.txtCedAgrCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedAgrCliente_KeyPress);
            this.txtCedAgrCliente.Leave += new System.EventHandler(this.txtCedAgrCliente_Leave);
            // 
            // txtNomAgrCliente
            // 
            this.txtNomAgrCliente.Location = new System.Drawing.Point(168, 22);
            this.txtNomAgrCliente.Name = "txtNomAgrCliente";
            this.txtNomAgrCliente.Size = new System.Drawing.Size(187, 20);
            this.txtNomAgrCliente.TabIndex = 28;
            this.txtNomAgrCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomAgrCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Teléfono *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cédula *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre *";
            // 
            // btnCerrarAgrCliente
            // 
            this.btnCerrarAgrCliente.Image = global::Proyecto.Properties.Resources.cancel1;
            this.btnCerrarAgrCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarAgrCliente.Location = new System.Drawing.Point(344, 291);
            this.btnCerrarAgrCliente.Name = "btnCerrarAgrCliente";
            this.btnCerrarAgrCliente.Size = new System.Drawing.Size(67, 29);
            this.btnCerrarAgrCliente.TabIndex = 40;
            this.btnCerrarAgrCliente.Text = "Cerrar";
            this.btnCerrarAgrCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarAgrCliente.UseVisualStyleBackColor = true;
            this.btnCerrarAgrCliente.Click += new System.EventHandler(this.btnCerrarAgrCliente_Click);
            // 
            // btnNuevoAgrCliente
            // 
            this.btnNuevoAgrCliente.Image = global::Proyecto.Properties.Resources.blanco3;
            this.btnNuevoAgrCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAgrCliente.Location = new System.Drawing.Point(263, 291);
            this.btnNuevoAgrCliente.Name = "btnNuevoAgrCliente";
            this.btnNuevoAgrCliente.Size = new System.Drawing.Size(75, 29);
            this.btnNuevoAgrCliente.TabIndex = 39;
            this.btnNuevoAgrCliente.Text = "Nuevo";
            this.btnNuevoAgrCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoAgrCliente.UseVisualStyleBackColor = true;
            this.btnNuevoAgrCliente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAgregarAgrCliente
            // 
            this.btnAgregarAgrCliente.Image = global::Proyecto.Properties.Resources.new2;
            this.btnAgregarAgrCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAgrCliente.Location = new System.Drawing.Point(188, 291);
            this.btnAgregarAgrCliente.Name = "btnAgregarAgrCliente";
            this.btnAgregarAgrCliente.Size = new System.Drawing.Size(68, 29);
            this.btnAgregarAgrCliente.TabIndex = 38;
            this.btnAgregarAgrCliente.Text = "Agregar";
            this.btnAgregarAgrCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarAgrCliente.UseVisualStyleBackColor = true;
            this.btnAgregarAgrCliente.Click += new System.EventHandler(this.btnAgregarAgrCliente_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 331);
            this.Controls.Add(this.btnCerrarAgrCliente);
            this.Controls.Add(this.btnNuevoAgrCliente);
            this.Controls.Add(this.btnAgregarAgrCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarCliente";
            this.Text = "Ingresar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCorreoAgrCliente;
        private System.Windows.Forms.TextBox txtRUCAgrCliente;
        private System.Windows.Forms.TextBox txtDirecAgrCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelAgrCliente;
        private System.Windows.Forms.TextBox txtCedAgrCliente;
        private System.Windows.Forms.TextBox txtNomAgrCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarAgrCliente;
        private System.Windows.Forms.Button btnNuevoAgrCliente;
        private System.Windows.Forms.Button btnCerrarAgrCliente;
    }
}