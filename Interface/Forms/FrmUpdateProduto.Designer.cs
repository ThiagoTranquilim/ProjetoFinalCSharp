namespace Interface.Forms
{
    partial class FrmUpdateProduto
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
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgMais = new System.Windows.Forms.DataGridView();
            this.cbAlteraCategoria = new System.Windows.Forms.ComboBox();
            this.cbAlteraMarca = new System.Windows.Forms.ComboBox();
            this.txtAlteraPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtAlteraPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblprecoVenda = new System.Windows.Forms.Label();
            this.lblprecoCusto = new System.Windows.Forms.Label();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.lblnomeProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtAlteracodProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).BeginInit();
            this.SuspendLayout();
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
            this.iconButton7.Location = new System.Drawing.Point(618, 2);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(32, 32);
            this.iconButton7.TabIndex = 4;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dgMais);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 5;
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
            this.dgMais.Location = new System.Drawing.Point(0, 65);
            this.dgMais.Name = "dgMais";
            this.dgMais.Size = new System.Drawing.Size(200, 247);
            this.dgMais.TabIndex = 9;
            this.dgMais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMais_CellContentClick);
            // 
            // cbAlteraCategoria
            // 
            this.cbAlteraCategoria.FormattingEnabled = true;
            this.cbAlteraCategoria.Location = new System.Drawing.Point(321, 195);
            this.cbAlteraCategoria.Name = "cbAlteraCategoria";
            this.cbAlteraCategoria.Size = new System.Drawing.Size(239, 23);
            this.cbAlteraCategoria.TabIndex = 30;
            // 
            // cbAlteraMarca
            // 
            this.cbAlteraMarca.FormattingEnabled = true;
            this.cbAlteraMarca.Location = new System.Drawing.Point(321, 166);
            this.cbAlteraMarca.Name = "cbAlteraMarca";
            this.cbAlteraMarca.Size = new System.Drawing.Size(239, 23);
            this.cbAlteraMarca.TabIndex = 29;
            // 
            // txtAlteraPrecoVenda
            // 
            this.txtAlteraPrecoVenda.Location = new System.Drawing.Point(321, 137);
            this.txtAlteraPrecoVenda.Name = "txtAlteraPrecoVenda";
            this.txtAlteraPrecoVenda.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraPrecoVenda.TabIndex = 28;
            // 
            // txtAlteraPrecoCusto
            // 
            this.txtAlteraPrecoCusto.Location = new System.Drawing.Point(321, 108);
            this.txtAlteraPrecoCusto.Name = "txtAlteraPrecoCusto";
            this.txtAlteraPrecoCusto.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraPrecoCusto.TabIndex = 27;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(255, 198);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 15);
            this.lblCategoria.TabIndex = 26;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(273, 169);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 15);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca:";
            // 
            // lblprecoVenda
            // 
            this.lblprecoVenda.AutoSize = true;
            this.lblprecoVenda.ForeColor = System.Drawing.Color.White;
            this.lblprecoVenda.Location = new System.Drawing.Point(241, 140);
            this.lblprecoVenda.Name = "lblprecoVenda";
            this.lblprecoVenda.Size = new System.Drawing.Size(75, 15);
            this.lblprecoVenda.TabIndex = 24;
            this.lblprecoVenda.Text = "Preço Venda:";
            // 
            // lblprecoCusto
            // 
            this.lblprecoCusto.AutoSize = true;
            this.lblprecoCusto.ForeColor = System.Drawing.Color.White;
            this.lblprecoCusto.Location = new System.Drawing.Point(241, 111);
            this.lblprecoCusto.Name = "lblprecoCusto";
            this.lblprecoCusto.Size = new System.Drawing.Size(74, 15);
            this.lblprecoCusto.TabIndex = 23;
            this.lblprecoCusto.Text = "Preço Custo:";
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(321, 79);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(239, 23);
            this.txtAlteraNome.TabIndex = 22;
            // 
            // lblnomeProduto
            // 
            this.lblnomeProduto.AutoSize = true;
            this.lblnomeProduto.ForeColor = System.Drawing.Color.White;
            this.lblnomeProduto.Location = new System.Drawing.Point(262, 82);
            this.lblnomeProduto.Name = "lblnomeProduto";
            this.lblnomeProduto.Size = new System.Drawing.Size(53, 15);
            this.lblnomeProduto.TabIndex = 21;
            this.lblnomeProduto.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Update Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(392, 252);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(95, 28);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.Text = "Alterar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtAlteracodProduto
            // 
            this.txtAlteracodProduto.Location = new System.Drawing.Point(321, 224);
            this.txtAlteracodProduto.Name = "txtAlteracodProduto";
            this.txtAlteracodProduto.Size = new System.Drawing.Size(239, 23);
            this.txtAlteracodProduto.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(221, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Codigo Produto:";
            // 
            // FrmUpdateProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(653, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlteracodProduto);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAlteraCategoria);
            this.Controls.Add(this.cbAlteraMarca);
            this.Controls.Add(this.txtAlteraPrecoVenda);
            this.Controls.Add(this.txtAlteraPrecoCusto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblprecoVenda);
            this.Controls.Add(this.lblprecoCusto);
            this.Controls.Add(this.txtAlteraNome);
            this.Controls.Add(this.lblnomeProduto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateProduto";
            this.Load += new System.EventHandler(this.FrmUpdateProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton7;
        private Panel panel1;
        private ComboBox cbAlteraCategoria;
        private ComboBox cbAlteraMarca;
        private TextBox txtAlteraPrecoVenda;
        private TextBox txtAlteraPrecoCusto;
        private Label lblCategoria;
        private Label lblMarca;
        private Label lblprecoVenda;
        private Label lblprecoCusto;
        private TextBox txtAlteraNome;
        private Label lblnomeProduto;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtAlteracodProduto;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dgMais;
    }
}