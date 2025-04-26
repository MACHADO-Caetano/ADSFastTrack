using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace cadastroUsuario
{
    public partial class Form1 : Form
    {
        private DataTable db;
        public Form1()
        {
            InitializeComponent();

            db = new DataTable("Cadastros");
            db.Columns.Add("Nome", typeof(string));
            db.Columns.Add("Email", typeof(string));
            db.Columns.Add("Telefone", typeof(double));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddRegister_Click(object sender, EventArgs e)
        {
            double telefone;
            if (!string.IsNullOrEmpty(name.Text) &&
                !string.IsNullOrEmpty(email.Text) &&
                double.TryParse(phone.Text, out telefone))
            {
                DataRow row = db.NewRow();
                row["Nome"] = name.Text;
                row["Email"] = email.Text;
                row["Telefone"] = telefone;
                db.Rows.Add(row);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewCadastrosRealizados.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewCadastrosRealizados.SelectedRows)
                {
                    dataGridViewCadastrosRealizados.Rows.RemoveAt(row.Index);
                }
            }
            else if (dataGridViewCadastrosRealizados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
            else if (dataGridViewCadastrosRealizados.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas uma linha para excluir.");
            }
            else
            {
                MessageBox.Show("Não há linhas para excluir");
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name.Text) || !string.IsNullOrWhiteSpace(email.Text) || !string.IsNullOrWhiteSpace(phone.Text))
            {
                name.Clear();
                email.Clear();
                phone.Clear();
            }
            else
            {
                MessageBox.Show("Não há campos para limpar.");
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            if (dataGridViewCadastrosRealizados.Visible == false)
            {
                dataGridViewCadastrosRealizados.DataSource = db;
                dataGridViewCadastrosRealizados.Visible = true;
            }
            else
            {
                dataGridViewCadastrosRealizados.Visible = false;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCadastrosRealizados.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dataGridViewCadastrosRealizados.SelectedRows)
                {
                    
                    double telefone;
                    if (double.TryParse(phone.Text, out telefone))
                    {

                        selectedRow.Cells["Nome"].Value = name.Text;
                        selectedRow.Cells["Email"].Value = email.Text;
                        selectedRow.Cells["Telefone"].Value = telefone;

                        MessageBox.Show("Dados atualizados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("O telefone deve ser um número válido.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para atualizar.");
            }
        }

        private void dataGridViewCadastrosRealizados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCadastrosRealizados.Rows[e.RowIndex];
                name.Text = row.Cells["Nome"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
                phone.Text = row.Cells["Telefone"].Value.ToString();
            }
        }
    }
}
