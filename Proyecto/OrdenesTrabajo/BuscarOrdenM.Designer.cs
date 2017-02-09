namespace Proyecto.OrdenesTrabajo
{
    partial class BuscarOrdenM
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
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxCI = new System.Windows.Forms.TextBox();
            this.textBoxNumOT = new System.Windows.Forms.TextBox();
            this.radioButCI = new System.Windows.Forms.RadioButton();
            this.radioButNumOT = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.selec;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(446, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 59;
            this.button1.Text = "Seleccionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Image = global::Proyecto.Properties.Resources.cancel1;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(544, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 29);
            this.button7.TabIndex = 58;
            this.button7.Text = "Cerrar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 183);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroOrden,
            this.TipoServicio,
            this.Column2,
            this.Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // NroOrden
            // 
            this.NroOrden.HeaderText = "Nro Orden";
            this.NroOrden.Name = "NroOrden";
            // 
            // TipoServicio
            // 
            this.TipoServicio.HeaderText = "Tipo Servicio";
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 230;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBoxCI);
            this.groupBox1.Controls.Add(this.textBoxNumOT);
            this.groupBox1.Controls.Add(this.radioButCI);
            this.groupBox1.Controls.Add(this.radioButNumOT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 101);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // button4
            // 
            this.button4.Image = global::Proyecto.Properties.Resources.buscar;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(469, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 38;
            this.button4.Text = "Buscar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBoxCI
            // 
            this.textBoxCI.Location = new System.Drawing.Point(246, 58);
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.ReadOnly = true;
            this.textBoxCI.Size = new System.Drawing.Size(151, 20);
            this.textBoxCI.TabIndex = 4;
            // 
            // textBoxNumOT
            // 
            this.textBoxNumOT.Location = new System.Drawing.Point(246, 28);
            this.textBoxNumOT.Name = "textBoxNumOT";
            this.textBoxNumOT.ReadOnly = true;
            this.textBoxNumOT.Size = new System.Drawing.Size(151, 20);
            this.textBoxNumOT.TabIndex = 3;
            // 
            // radioButCI
            // 
            this.radioButCI.AutoSize = true;
            this.radioButCI.Location = new System.Drawing.Point(73, 61);
            this.radioButCI.Name = "radioButCI";
            this.radioButCI.Size = new System.Drawing.Size(70, 17);
            this.radioButCI.TabIndex = 1;
            this.radioButCI.TabStop = true;
            this.radioButCI.Text = "CI Cliente";
            this.radioButCI.UseVisualStyleBackColor = true;
            this.radioButCI.CheckedChanged += new System.EventHandler(this.radioButCI_CheckedChanged);
            // 
            // radioButNumOT
            // 
            this.radioButNumOT.AutoSize = true;
            this.radioButNumOT.Location = new System.Drawing.Point(73, 28);
            this.radioButNumOT.Name = "radioButNumOT";
            this.radioButNumOT.Size = new System.Drawing.Size(131, 17);
            this.radioButNumOT.TabIndex = 0;
            this.radioButNumOT.TabStop = true;
            this.radioButNumOT.Text = " Nro Orden de Trabajo";
            this.radioButNumOT.UseVisualStyleBackColor = true;
            this.radioButNumOT.CheckedChanged += new System.EventHandler(this.radioButNumOT_CheckedChanged);
            // 
            // BuscarOrdenM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarOrdenM";
            this.Text = "Buscar Orden";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxCI;
        private System.Windows.Forms.TextBox textBoxNumOT;
        private System.Windows.Forms.RadioButton radioButCI;
        private System.Windows.Forms.RadioButton radioButNumOT;
    }
}