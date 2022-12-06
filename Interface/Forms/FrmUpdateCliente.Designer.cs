namespace Interface.Forms
{
    partial class FrmUpdateCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgMais = new System.Windows.Forms.DataGridView();
            this.txtAlteraCodCliente = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlteraTelefone = new System.Windows.Forms.TextBox();
            this.txtAlteraEndereco = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblEnderecoCliente = new System.Windows.Forms.Label();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.lblnomeCliente = new System.Windows.Forms.Label();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.txtAlteraCpf = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dgMais);
            this.panel1.Location = new System.Drawing.Point(2, -91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 6;
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
            // txtAlteraCodCliente
            // 
            this.txtAlteraCodCliente.Location = new System.Drawing.Point(322, 194);
            this.txtAlteraCodCliente.Name = "txtAlteraCodCliente";
            this.txtAlteraCodCliente.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraCodCliente.TabIndex = 48;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(396, 223);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(95, 28);
            this.iconButton1.TabIndex = 47;
            this.iconButton1.Text = "Alterar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Update Cliente";
            // 
            // txtAlteraTelefone
            // 
            this.txtAlteraTelefone.Location = new System.Drawing.Point(322, 136);
            this.txtAlteraTelefone.Name = "txtAlteraTelefone";
            this.txtAlteraTelefone.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraTelefone.TabIndex = 43;
            // 
            // txtAlteraEndereco
            // 
            this.txtAlteraEndereco.Location = new System.Drawing.Point(322, 107);
            this.txtAlteraEndereco.Name = "txtAlteraEndereco";
            this.txtAlteraEndereco.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraEndereco.TabIndex = 42;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.ForeColor = System.Drawing.Color.White;
            this.lblCodCliente.Location = new System.Drawing.Point(268, 194);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(49, 15);
            this.lblCodCliente.TabIndex = 41;
            this.lblCodCliente.Text = "Codigo:";
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.ForeColor = System.Drawing.Color.White;
            this.lblCpfCliente.Location = new System.Drawing.Point(286, 168);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(31, 15);
            this.lblCpfCliente.TabIndex = 40;
            this.lblCpfCliente.Text = "CPF:";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.ForeColor = System.Drawing.Color.White;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(263, 139);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(54, 15);
            this.lblTelefoneCliente.TabIndex = 39;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // lblEnderecoCliente
            // 
            this.lblEnderecoCliente.AutoSize = true;
            this.lblEnderecoCliente.ForeColor = System.Drawing.Color.White;
            this.lblEnderecoCliente.Location = new System.Drawing.Point(258, 110);
            this.lblEnderecoCliente.Name = "lblEnderecoCliente";
            this.lblEnderecoCliente.Size = new System.Drawing.Size(59, 15);
            this.lblEnderecoCliente.TabIndex = 38;
            this.lblEnderecoCliente.Text = "Endereço:";
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(322, 78);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraNome.TabIndex = 37;
            // 
            // lblnomeCliente
            // 
            this.lblnomeCliente.AutoSize = true;
            this.lblnomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblnomeCliente.Location = new System.Drawing.Point(274, 81);
            this.lblnomeCliente.Name = "lblnomeCliente";
            this.lblnomeCliente.Size = new System.Drawing.Size(43, 15);
            this.lblnomeCliente.TabIndex = 36;
            this.lblnomeCliente.Text = "Nome:";
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
            this.iconButton7.Location = new System.Drawing.Point(619, 1);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(32, 32);
            this.iconButton7.TabIndex = 35;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // txtAlteraCpf
            // 
            this.txtAlteraCpf.Location = new System.Drawing.Point(322, 165);
            this.txtAlteraCpf.Name = "txtAlteraCpf";
            this.txtAlteraCpf.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraCpf.TabIndex = 49;
            // 
            // FrmUpdateCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(653, 313);
            this.Controls.Add(this.txtAlteraCpf);
            this.Controls.Add(this.txtAlteraCodCliente);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlteraTelefone);
            this.Controls.Add(this.txtAlteraEndereco);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.lblCpfCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblEnderecoCliente);
            this.Controls.Add(this.txtAlteraNome);
            this.Controls.Add(this.lblnomeCliente);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateCliente";
            this.Load += new System.EventHandler(this.FrmUpdateCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dgMais;
        private TextBox txtAlteraCodCliente;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private TextBox txtAlteraTelefone;
        private TextBox txtAlteraEndereco;
        private Label lblCodCliente;
        private Label lblCpfCliente;
        private Label lblTelefoneCliente;
        private Label lblEnderecoCliente;
        private TextBox txtAlteraNome;
        private Label lblnomeCliente;
        private FontAwesome.Sharp.IconButton iconButton7;
        private TextBox txtAlteraCpf;
        private TextBox textBox2;
    }
}