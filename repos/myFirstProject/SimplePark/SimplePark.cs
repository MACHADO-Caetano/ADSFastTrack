namespace SimplePark
{
    partial class SimpleParkForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelValorArrecadado = new Label();
            DataGridViewCarrosEstacionados = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelValorHora = new Label();
            botaoCadastro = new Button();
            botaoConfigurar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCarrosEstacionados).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1319885F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.86801F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(7, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1091, 511);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelValorArrecadado, 0, 1);
            tableLayoutPanel2.Controls.Add(DataGridViewCarrosEstacionados, 0, 0);
            tableLayoutPanel2.Location = new Point(179, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.72277F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2772274F));
            tableLayoutPanel2.Size = new Size(909, 505);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelValorArrecadado
            // 
            labelValorArrecadado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelValorArrecadado.AutoSize = true;
            labelValorArrecadado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorArrecadado.Location = new Point(658, 481);
            labelValorArrecadado.Name = "labelValorArrecadado";
            labelValorArrecadado.Size = new Size(248, 24);
            labelValorArrecadado.TabIndex = 0;
            labelValorArrecadado.Text = "Valor Arrecadado R$ 0,00";
            labelValorArrecadado.Click += label1_Click;
            // 
            // DataGridViewCarrosEstacionados
            // 
            DataGridViewCarrosEstacionados.AllowUserToAddRows = false;
            DataGridViewCarrosEstacionados.AllowUserToDeleteRows = false;
            DataGridViewCarrosEstacionados.AllowUserToResizeColumns = false;
            DataGridViewCarrosEstacionados.AllowUserToResizeRows = false;
            DataGridViewCarrosEstacionados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewCarrosEstacionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCarrosEstacionados.BackgroundColor = Color.LightGray;
            DataGridViewCarrosEstacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCarrosEstacionados.Location = new Point(3, 3);
            DataGridViewCarrosEstacionados.Name = "DataGridViewCarrosEstacionados";
            DataGridViewCarrosEstacionados.ReadOnly = true;
            DataGridViewCarrosEstacionados.RowHeadersVisible = false;
            DataGridViewCarrosEstacionados.RowHeadersWidth = 51;
            DataGridViewCarrosEstacionados.Size = new Size(903, 437);
            DataGridViewCarrosEstacionados.TabIndex = 1;
            DataGridViewCarrosEstacionados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelValorHora, 0, 1);
            tableLayoutPanel3.Controls.Add(botaoCadastro, 0, 0);
            tableLayoutPanel3.Controls.Add(botaoConfigurar, 0, 2);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6831684F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75.24753F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8712873F));
            tableLayoutPanel3.Size = new Size(170, 505);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // labelValorHora
            // 
            labelValorHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelValorHora.AutoSize = true;
            labelValorHora.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorHora.Location = new Point(3, 391);
            labelValorHora.Name = "labelValorHora";
            labelValorHora.Size = new Size(146, 48);
            labelValorHora.TabIndex = 2;
            labelValorHora.Text = "Valor Hora R$ 0,00";
            // 
            // botaoCadastro
            // 
            botaoCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botaoCadastro.BackColor = Color.Silver;
            botaoCadastro.Location = new Point(3, 3);
            botaoCadastro.Name = "botaoCadastro";
            botaoCadastro.Size = new Size(164, 53);
            botaoCadastro.TabIndex = 0;
            botaoCadastro.Text = "Cadastrar";
            botaoCadastro.UseVisualStyleBackColor = false;
            botaoCadastro.Click += botaoCadastro_Click;
            // 
            // botaoConfigurar
            // 
            botaoConfigurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botaoConfigurar.BackColor = Color.Silver;
            botaoConfigurar.Location = new Point(3, 442);
            botaoConfigurar.Name = "botaoConfigurar";
            botaoConfigurar.Size = new Size(164, 60);
            botaoConfigurar.TabIndex = 1;
            botaoConfigurar.Text = "Configurar";
            botaoConfigurar.UseVisualStyleBackColor = false;
            // 
            // SimpleParkForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1100, 518);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "SimpleParkForm";
            ShowIcon = false;
            Text = "Simple To Park";
            Load += SimpleParkForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCarrosEstacionados).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelValorArrecadado;
        private DataGridView DataGridViewCarrosEstacionados;
        private TableLayoutPanel tableLayoutPanel3;
        private Button botaoCadastro;
        private Button botaoConfigurar;
        private Label labelValorHora;
    }
}
