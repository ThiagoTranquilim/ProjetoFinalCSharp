namespace Interface.Forms
{
    partial class FormUpdate
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
            this.dgMais = new System.Windows.Forms.DataGridView();
            this.btnProduto = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnVenda = new FontAwesome.Sharp.IconButton();
            this.UpdateProduto = new FontAwesome.Sharp.IconButton();
            this.UpdateCliente = new FontAwesome.Sharp.IconButton();
            this.UpdateVenda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMais
            // 
            this.dgMais.BackgroundColor = System.Drawing.Color.White;
            this.dgMais.Location = new System.Drawing.Point(71, 135);
            this.dgMais.Name = "dgMais";
            this.dgMais.Size = new System.Drawing.Size(587, 331);
            this.dgMais.TabIndex = 8;
            this.dgMais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMais_CellContentClick);
            // 
            // btnProduto
            // 
            this.btnProduto.BackgroundImage = global::Interface.Properties.Resources.soft_drink;
            this.btnProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.ForeColor = System.Drawing.Color.White;
            this.btnProduto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProduto.IconColor = System.Drawing.Color.Black;
            this.btnProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduto.Location = new System.Drawing.Point(674, 136);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(91, 41);
            this.btnProduto.TabIndex = 9;
            this.btnProduto.Text = "Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::Interface.Properties.Resources.customer;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCliente.IconColor = System.Drawing.Color.Black;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.Location = new System.Drawing.Point(674, 183);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(91, 39);
            this.btnCliente.TabIndex = 10;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackgroundImage = global::Interface.Properties.Resources.clipboard;
            this.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVenda.IconColor = System.Drawing.Color.Black;
            this.btnVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenda.Location = new System.Drawing.Point(674, 228);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(91, 40);
            this.btnVenda.TabIndex = 11;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // UpdateProduto
            // 
            this.UpdateProduto.BackgroundImage = global::Interface.Properties.Resources.exchange;
            this.UpdateProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.UpdateProduto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.UpdateProduto.IconColor = System.Drawing.Color.Black;
            this.UpdateProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateProduto.Location = new System.Drawing.Point(771, 140);
            this.UpdateProduto.Name = "UpdateProduto";
            this.UpdateProduto.Size = new System.Drawing.Size(35, 32);
            this.UpdateProduto.TabIndex = 12;
            this.UpdateProduto.UseVisualStyleBackColor = true;
            this.UpdateProduto.Click += new System.EventHandler(this.UpdateProduto_Click);
            // 
            // UpdateCliente
            // 
            this.UpdateCliente.BackgroundImage = global::Interface.Properties.Resources.exchange;
            this.UpdateCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.UpdateCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.UpdateCliente.IconColor = System.Drawing.Color.Black;
            this.UpdateCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateCliente.Location = new System.Drawing.Point(771, 183);
            this.UpdateCliente.Name = "UpdateCliente";
            this.UpdateCliente.Size = new System.Drawing.Size(35, 37);
            this.UpdateCliente.TabIndex = 13;
            this.UpdateCliente.UseVisualStyleBackColor = true;
            this.UpdateCliente.Click += new System.EventHandler(this.UpdateCliente_Click);
            // 
            // UpdateVenda
            // 
            this.UpdateVenda.BackgroundImage = global::Interface.Properties.Resources.exchange;
            this.UpdateVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.UpdateVenda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.UpdateVenda.IconColor = System.Drawing.Color.Black;
            this.UpdateVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateVenda.Location = new System.Drawing.Point(771, 226);
            this.UpdateVenda.Name = "UpdateVenda";
            this.UpdateVenda.Size = new System.Drawing.Size(38, 34);
            this.UpdateVenda.TabIndex = 14;
            this.UpdateVenda.UseVisualStyleBackColor = true;
            this.UpdateVenda.Click += new System.EventHandler(this.UpdateVenda_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1165, 500);
            this.Controls.Add(this.UpdateVenda);
            this.Controls.Add(this.UpdateCliente);
            this.Controls.Add(this.UpdateProduto);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.dgMais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdate";
            this.Text = "Marketing";
            this.Load += new System.EventHandler(this.FormMarketing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgMais;
        private FontAwesome.Sharp.IconButton btnProduto;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnVenda;
        private FontAwesome.Sharp.IconButton UpdateProduto;
        private FontAwesome.Sharp.IconButton UpdateCliente;
        private FontAwesome.Sharp.IconButton UpdateVenda;
    }
}