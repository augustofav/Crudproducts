using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;


namespace CrudProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string strConexao = $@"Data Source={Application.StartupPath}\cnxSQLite.db;";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CriarBancoDeDados();
                using (SQLiteConnection conexao = new SQLiteConnection(strConexao))
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.Open();
                      
                    }
                }
                AtualizarGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CriarBancoDeDados()
        {
         
            string caminhoBanco = Application.StartupPath + @"\cnxSQLite.db";
            MessageBox.Show($"Caminho do banco de dados: {caminhoBanco}", "Caminho do Banco de Dados");

            SQLiteConnection.CreateFile(caminhoBanco);

            if (!File.Exists(caminhoBanco))
            {
                Console.WriteLine("entrou no criar banco"); 
                SQLiteConnection.CreateFile(caminhoBanco);

                using (SQLiteConnection conexao = new SQLiteConnection(strConexao))
                {
                    conexao.Open();

                    string query = @"
                    CREATE TABLE IF NOT EXISTS Produtos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Preco REAL NOT NULL,
                        Quantidade INTEGER NOT NULL
                    );";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    } 
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos(string nome, decimal preco, int quantidade)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Nome não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal preco = numericUpDownPreco.Value;
            int quantidade = (int)numericUpDownQuantidade.Value;

            if (ValidarCampos(nome, preco, quantidade))
            {
                Products.InsertProduct(strConexao, nome, (double)preco, quantidade);
                AtualizarGrid();
                LimparCampos();
                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            numericUpDownPreco.Value = 1;
            numericUpDownQuantidade.Value = 1;
        }

        private void AtualizarGrid()
        {
            using (SQLiteConnection conexao = new SQLiteConnection(strConexao))
            {
                conexao.Open();

                string query = "SELECT * FROM Produtos";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conexao);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProdutos.DataSource = dt;
               
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Id"].Value);

                if (MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Products.DeleteProduct(strConexao, id);
                    AtualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Id"].Value);
                string nome = txtNome.Text;
                decimal preco = numericUpDownPreco.Value;
                int quantidade = (int)numericUpDownQuantidade.Value;

                if (ValidarCampos(nome, preco, quantidade))
                {
                    Products.UpdateProduct(id, strConexao, nome, (double)preco, quantidade);
                    AtualizarGrid();
                    LimparCampos();
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    


        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}





