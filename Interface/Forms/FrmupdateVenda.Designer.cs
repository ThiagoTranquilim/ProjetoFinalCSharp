namespace Interface.Forms
{
    partial class FrmupdateVenda
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlteraCliente = new System.Windows.Forms.TextBox();
            this.txtAlteraDataHora = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.txtAlteraMesa = new System.Windows.Forms.TextBox();
            this.lblMesaVenda = new System.Windows.Forms.Label();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgMais = new System.Windows.Forms.DataGridView();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.lblCodVenda = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(390, 202);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(95, 28);
            this.iconButton1.TabIndex = 61;
            this.iconButton1.Text = "Alterar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Update Vendas";
            // 
            // txtAlteraCliente
            // 
            this.txtAlteraCliente.Location = new System.Drawing.Point(315, 146);
            this.txtAlteraCliente.Name = "txtAlteraCliente";
            this.txtAlteraCliente.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraCliente.TabIndex = 59;
            // 
            // txtAlteraDataHora
            // 
            this.txtAlteraDataHora.Location = new System.Drawing.Point(315, 117);
            this.txtAlteraDataHora.Name = "txtAlteraDataHora";
            this.txtAlteraDataHora.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraDataHora.TabIndex = 58;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(263, 149);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 55;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.ForeColor = System.Drawing.Color.White;
            this.lblDataHora.Location = new System.Drawing.Point(238, 120);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(72, 15);
            this.lblDataHora.TabIndex = 54;
            this.lblDataHora.Text = "Data e Hora:";
            // 
            // txtAlteraMesa
            // 
            this.txtAlteraMesa.Location = new System.Drawing.Point(315, 88);
            this.txtAlteraMesa.Name = "txtAlteraMesa";
            this.txtAlteraMesa.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraMesa.TabIndex = 53;
            // 
            // lblMesaVenda
            // 
            this.lblMesaVenda.AutoSize = true;
            this.lblMesaVenda.ForeColor = System.Drawing.Color.White;
            this.lblMesaVenda.Location = new System.Drawing.Point(272, 91);
            this.lblMesaVenda.Name = "lblMesaVenda";
            this.lblMesaVenda.Size = new System.Drawing.Size(38, 15);
            this.lblMesaVenda.TabIndex = 52;
            this.lblMesaVenda.Text = "Mesa:";
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconButton7.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 32;
            this.iconButton7.Location = new System.Drawing.Point(604, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(32, 32);
            this.iconButton7.TabIndex = 51;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dgMais);
            this.panel1.Location = new System.Drawing.Point(-6, -110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 35;
            // 
            // dgMais
            // 
            this.dgMais.BackgroundColor = System.Drawing.Color.White;
            this.dgMais.Location = new System.Drawing.Point(-3, 160);
            this.dgMais.Name = "dgMais";
            this.dgMais.Size = new System.Drawing.Size(200, 247);
            this.dgMais.TabIndex = 9;
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Location = new System.Drawing.Point(315, 175);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(239, 23);
            this.txtCodVenda.TabIndex = 62;
            // 
            // lblCodVenda
            // 
            this.lblCodVenda.AutoSize = true;
            this.lblCodVenda.ForeColor = System.Drawing.Color.White;
            this.lblCodVenda.Location = new System.Drawing.Point(263, 175);
            this.lblCodVenda.Name = "lblCodVenda";
            this.lblCodVenda.Size = new System.Drawing.Size(49, 15);
            this.lblCodVenda.TabIndex = 63;
            this.lblCodVenda.Text = "Codigo:";
            // 
            // FrmupdateVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(637, 274);
            this.Controls.Add(this.lblCodVenda);
            this.Controls.Add(this.txtCodVenda);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlteraCliente);
            this.Controls.Add(this.txtAlteraDataHora);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.txtAlteraMesa);
            this.Controls.Add(this.lblMesaVenda);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmupdateVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmupdateVenda";
            this.Load += new System.EventHandler(this.FrmupdateVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private TextBox txtAlteraCliente;
        private TextBox txtAlteraDataHora;
        private Label lblCliente;
        private Label lblDataHora;
        private TextBox txtAlteraMesa;
        private Label lblMesaVenda;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dgMais;
        private TextBox txtCodVenda;
        private Label lblCodVenda;
    }
}