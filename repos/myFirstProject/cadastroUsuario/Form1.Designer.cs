namespace cadastroUsuario
{
    partial class Form1
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
            label1 = new Label();
            name = new TextBox();
            email = new TextBox();
            label2 = new Label();
            phone = new TextBox();
            label3 = new Label();
            buttonAddRegister = new Button();
            dataGridViewCadastrosRealizados = new DataGridView();
            buttonDelete = new Button();
            buttonList = new Button();
            buttonClean = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastrosRealizados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // name
            // 
            name.Location = new Point(69, 14);
            name.Name = "name";
            name.Size = new Size(316, 27);
            name.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(69, 47);
            email.Name = "email";
            email.Size = new Size(316, 27);
            email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 54);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "E-mail:";
            // 
            // phone
            // 
            phone.Location = new Point(88, 80);
            phone.Name = "phone";
            phone.Size = new Size(297, 27);
            phone.TabIndex = 5;
            phone.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 87);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // buttonAddRegister
            // 
            buttonAddRegister.BackColor = Color.LimeGreen;
            buttonAddRegister.Location = new Point(13, 125);
            buttonAddRegister.Name = "buttonAddRegister";
            buttonAddRegister.Size = new Size(200, 35);
            buttonAddRegister.TabIndex = 6;
            buttonAddRegister.Text = "Salvar";
            buttonAddRegister.UseVisualStyleBackColor = false;
            buttonAddRegister.Click += buttonAddRegister_Click;
            // 
            // dataGridViewCadastrosRealizados
            // 
            dataGridViewCadastrosRealizados.ColumnHeadersHeight = 29;
            dataGridViewCadastrosRealizados.Location = new Point(12, 250);
            dataGridViewCadastrosRealizados.Name = "dataGridViewCadastrosRealizados";
            dataGridViewCadastrosRealizados.RowHeadersWidth = 51;
            dataGridViewCadastrosRealizados.Size = new Size(417, 188);
            dataGridViewCadastrosRealizados.TabIndex = 7;
            dataGridViewCadastrosRealizados.Visible = false;
            dataGridViewCadastrosRealizados.CellContentClick += dataGridViewCadastrosRealizados_CellContentClick;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Firebrick;
            buttonDelete.Location = new Point(229, 125);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 35);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Excluir";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += button1_Click;
            // 
            // buttonList
            // 
            buttonList.BackColor = Color.Yellow;
            buttonList.Location = new Point(12, 166);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(200, 35);
            buttonList.TabIndex = 9;
            buttonList.Text = "Listar";
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // buttonClean
            // 
            buttonClean.BackColor = Color.LightGray;
            buttonClean.Location = new Point(425, 54);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(200, 35);
            buttonClean.TabIndex = 10;
            buttonClean.Text = "Limpar Campos";
            buttonClean.UseVisualStyleBackColor = false;
            buttonClean.Click += buttonClean_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.RoyalBlue;
            buttonUpdate.Location = new Point(229, 166);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(200, 35);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Editar";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonClean);
            Controls.Add(buttonList);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridViewCadastrosRealizados);
            Controls.Add(buttonAddRegister);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cadastro Usuários";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastrosRealizados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox email;
        private Label label2;
        private TextBox phone;
        private Label label3;
        private Button buttonAddRegister;
        private DataGridView dataGridViewCadastrosRealizados;
        private Button buttonDelete;
        private Button buttonList;
        private Button buttonClean;
        private Button buttonUpdate;
    }
}
