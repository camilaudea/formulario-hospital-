namespace trabajo_cami
{
    partial class formulario_31_mayo
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
            this.Lblprimernombre = new System.Windows.Forms.Label();
            this.txtprimernombre = new System.Windows.Forms.TextBox();
            this.lblsegundonombre = new System.Windows.Forms.Label();
            this.lblprimerapellido = new System.Windows.Forms.Label();
            this.lblsegundoapellido = new System.Windows.Forms.Label();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.txtsegundoapellido = new System.Windows.Forms.TextBox();
            this.txtsegundonombre = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblprimernombre
            // 
            this.Lblprimernombre.AutoSize = true;
            this.Lblprimernombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lblprimernombre.Location = new System.Drawing.Point(212, 152);
            this.Lblprimernombre.Name = "Lblprimernombre";
            this.Lblprimernombre.Size = new System.Drawing.Size(87, 15);
            this.Lblprimernombre.TabIndex = 0;
            this.Lblprimernombre.Text = "Primer nombre";
            this.Lblprimernombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtprimernombre
            // 
            this.txtprimernombre.Location = new System.Drawing.Point(362, 149);
            this.txtprimernombre.Name = "txtprimernombre";
            this.txtprimernombre.Size = new System.Drawing.Size(226, 23);
            this.txtprimernombre.TabIndex = 1;
            this.txtprimernombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblsegundonombre
            // 
            this.lblsegundonombre.AutoSize = true;
            this.lblsegundonombre.Location = new System.Drawing.Point(212, 191);
            this.lblsegundonombre.Name = "lblsegundonombre";
            this.lblsegundonombre.Size = new System.Drawing.Size(99, 15);
            this.lblsegundonombre.TabIndex = 2;
            this.lblsegundonombre.Text = "Segundo nombre";
            this.lblsegundonombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblprimerapellido
            // 
            this.lblprimerapellido.AutoSize = true;
            this.lblprimerapellido.Location = new System.Drawing.Point(212, 230);
            this.lblprimerapellido.Name = "lblprimerapellido";
            this.lblprimerapellido.Size = new System.Drawing.Size(87, 15);
            this.lblprimerapellido.TabIndex = 3;
            this.lblprimerapellido.Text = "Primer apellido";
            // 
            // lblsegundoapellido
            // 
            this.lblsegundoapellido.AutoSize = true;
            this.lblsegundoapellido.Location = new System.Drawing.Point(212, 269);
            this.lblsegundoapellido.Name = "lblsegundoapellido";
            this.lblsegundoapellido.Size = new System.Drawing.Size(99, 15);
            this.lblsegundoapellido.TabIndex = 4;
            this.lblsegundoapellido.Text = "Segundo apellido";
            this.lblsegundoapellido.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(362, 222);
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(226, 23);
            this.txtprimerapellido.TabIndex = 5;
            // 
            // txtsegundoapellido
            // 
            this.txtsegundoapellido.Location = new System.Drawing.Point(362, 266);
            this.txtsegundoapellido.Name = "txtsegundoapellido";
            this.txtsegundoapellido.Size = new System.Drawing.Size(226, 23);
            this.txtsegundoapellido.TabIndex = 6;
            // 
            // txtsegundonombre
            // 
            this.txtsegundonombre.Location = new System.Drawing.Point(362, 183);
            this.txtsegundonombre.Name = "txtsegundonombre";
            this.txtsegundonombre.Size = new System.Drawing.Size(226, 23);
            this.txtsegundonombre.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(99, 321);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(607, 28);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(99, 364);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(607, 28);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // formulario_31_mayo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtsegundonombre);
            this.Controls.Add(this.txtsegundoapellido);
            this.Controls.Add(this.txtprimerapellido);
            this.Controls.Add(this.lblsegundoapellido);
            this.Controls.Add(this.lblprimerapellido);
            this.Controls.Add(this.lblsegundonombre);
            this.Controls.Add(this.txtprimernombre);
            this.Controls.Add(this.Lblprimernombre);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.Name = "formulario_31_mayo";
            this.Text = "formulario_31_mayo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lblprimernombre;
        private TextBox txtprimernombre;
        private Label lblsegundonombre;
        private Label lblprimerapellido;
        private Label lblsegundoapellido;
        private TextBox txtprimerapellido;
        private TextBox txtsegundoapellido;
        private TextBox txtsegundonombre;
        private Button btnguardar;
        private Button btncancelar;
    }
}