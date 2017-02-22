namespace Proyecto.Administración
{
    partial class ParametrosOrden
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
            this.textNumInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarAgrCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNumInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textNumInicio
            // 
            this.textNumInicio.Location = new System.Drawing.Point(114, 19);
            this.textNumInicio.Name = "textNumInicio";
            this.textNumInicio.Size = new System.Drawing.Size(100, 20);
            this.textNumInicio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número inicio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCerrarAgrCliente
            // 
            this.btnCerrarAgrCliente.Image = global::Proyecto.Properties.Resources.cancel1;
            this.btnCerrarAgrCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarAgrCliente.Location = new System.Drawing.Point(173, 68);
            this.btnCerrarAgrCliente.Name = "btnCerrarAgrCliente";
            this.btnCerrarAgrCliente.Size = new System.Drawing.Size(67, 29);
            this.btnCerrarAgrCliente.TabIndex = 41;
            this.btnCerrarAgrCliente.Text = "Cerrar";
            this.btnCerrarAgrCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarAgrCliente.UseVisualStyleBackColor = true;
            this.btnCerrarAgrCliente.Click += new System.EventHandler(this.btnCerrarAgrCliente_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.Notepad;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(92, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Modificar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParametrosOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 105);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrarAgrCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParametrosOrden";
            this.Text = "Parámetros Orden de Trabajo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNumInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrarAgrCliente;
        private System.Windows.Forms.Button button1;
    }
}