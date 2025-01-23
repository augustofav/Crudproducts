namespace CrudProdutos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar_Click = new System.Windows.Forms.Button();
            this.btnLimpar_Click = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(15, 95);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(144, 20);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAdicionar_Click
            // 
            this.btnAdicionar_Click.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdicionar_Click.Location = new System.Drawing.Point(18, 190);
            this.btnAdicionar_Click.Name = "btnAdicionar_Click";
            this.btnAdicionar_Click.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar_Click.TabIndex = 6;
            this.btnAdicionar_Click.Text = "adicionar";
            this.btnAdicionar_Click.UseVisualStyleBackColor = false;
            this.btnAdicionar_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar_Click
            // 
            this.btnLimpar_Click.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar_Click.Location = new System.Drawing.Point(275, 190);
            this.btnLimpar_Click.Name = "btnLimpar_Click";
            this.btnLimpar_Click.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar_Click.TabIndex = 9;
            this.btnLimpar_Click.Text = "limpar";
            this.btnLimpar_Click.UseVisualStyleBackColor = false;
            this.btnLimpar_Click.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(18, 139);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(141, 20);
            this.txtQuantidade.TabIndex = 10;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(204, 9);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(541, 150);
            this.dgvProdutos.TabIndex = 11;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(194, 189);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(99, 190);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(741, 301);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnLimpar_Click);
            this.Controls.Add(this.btnAdicionar_Click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar_Click;
        private System.Windows.Forms.Button btnLimpar_Click;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}

