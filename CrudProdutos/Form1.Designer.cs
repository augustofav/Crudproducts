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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar_Click = new System.Windows.Forms.Button();
            this.btnLimpar_Click = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPreco = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
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
            this.btnAdicionar_Click.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar_Click.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionar_Click.Location = new System.Drawing.Point(18, 383);
            this.btnAdicionar_Click.Name = "btnAdicionar_Click";
            this.btnAdicionar_Click.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar_Click.TabIndex = 6;
            this.btnAdicionar_Click.Text = "adicionar";
            this.btnAdicionar_Click.UseVisualStyleBackColor = false;
            this.btnAdicionar_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar_Click
            // 
            this.btnLimpar_Click.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar_Click.Location = new System.Drawing.Point(263, 383);
            this.btnLimpar_Click.Name = "btnLimpar_Click";
            this.btnLimpar_Click.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar_Click.TabIndex = 9;
            this.btnLimpar_Click.Text = "limpar";
            this.btnLimpar_Click.UseVisualStyleBackColor = false;
            this.btnLimpar_Click.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(18, 186);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(454, 154);
            this.dgvProdutos.TabIndex = 11;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(182, 383);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(101, 383);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(18, 139);
            this.numericUpDownQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantidade.TabIndex = 14;
            this.numericUpDownQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantidade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // numericUpDownPreco
            // 
            this.numericUpDownPreco.DecimalPlaces = 2;
            this.numericUpDownPreco.Location = new System.Drawing.Point(18, 90);
            this.numericUpDownPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPreco.Name = "numericUpDownPreco";
            this.numericUpDownPreco.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPreco.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Comandos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(541, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownPreco);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnLimpar_Click);
            this.Controls.Add(this.btnAdicionar_Click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar_Click;
        private System.Windows.Forms.Button btnLimpar_Click;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.NumericUpDown numericUpDownPreco;
        private System.Windows.Forms.Label label5;
    }
}

