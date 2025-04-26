using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace SimplePark
{
    public partial class SimpleParkForm : Form
    {
        private DataTable db; //declarar um armazenador de dados em coluna x linha
        public SimpleParkForm()
        {
            InitializeComponent();

            db = new DataTable("Estacionamento");

            db.Columns.Add("Placa", typeof(string)); //adicionando uma coluna
            db.Columns.Add("Entrada", typeof(string));

            DataGridViewCarrosEstacionados.DataSource = db; //ligando o DataGridView ao DataTable
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SimpleParkForm_Load(object sender, EventArgs e)
        {

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            var placa = Interaction.InputBox("Digite a placa do carro:", "Entrada do Veículo");
            if(!string.IsNullOrEmpty(placa))
            {
                db.Rows.Add(new string[] { placa, DateTime.Now.ToString() });
            }
        }
    }
}
