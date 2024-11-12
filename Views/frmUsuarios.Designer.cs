namespace ProjetoAgenda.Views
{
    partial class frmUsuarios
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
            dataGridView1 = new DataGridView();
            gbxGerenciar = new GroupBox();
            lblNomeUsuario = new Label();
            textBox1 = new TextBox();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            lblAlterarSenha = new Label();
            tbxNovaSenha = new TextBox();
            btnExcludeUser = new Button();
            btnAlterarSenha = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbxGerenciar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(293, 299);
            dataGridView1.TabIndex = 0;
            // 
            // gbxGerenciar
            // 
            gbxGerenciar.Controls.Add(btnAtualizar);
            gbxGerenciar.Controls.Add(btnAlterarSenha);
            gbxGerenciar.Controls.Add(btnExcludeUser);
            gbxGerenciar.Controls.Add(tbxNovaSenha);
            gbxGerenciar.Controls.Add(lblAlterarSenha);
            gbxGerenciar.Controls.Add(tbxEmail);
            gbxGerenciar.Controls.Add(lblEmail);
            gbxGerenciar.Controls.Add(textBox1);
            gbxGerenciar.Controls.Add(lblNomeUsuario);
            gbxGerenciar.Location = new Point(330, 12);
            gbxGerenciar.Name = "gbxGerenciar";
            gbxGerenciar.Size = new Size(217, 299);
            gbxGerenciar.TabIndex = 1;
            gbxGerenciar.TabStop = false;
            gbxGerenciar.Text = "Gerenciar";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(13, 27);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(52, 15);
            lblNomeUsuario.TabIndex = 0;
            lblNomeUsuario.Text = "Usuário:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 45);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(13, 81);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(6, 99);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.ReadOnly = true;
            tbxEmail.Size = new Size(205, 23);
            tbxEmail.TabIndex = 3;
            // 
            // lblAlterarSenha
            // 
            lblAlterarSenha.AutoSize = true;
            lblAlterarSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlterarSenha.Location = new Point(13, 171);
            lblAlterarSenha.Name = "lblAlterarSenha";
            lblAlterarSenha.Size = new Size(84, 15);
            lblAlterarSenha.TabIndex = 4;
            lblAlterarSenha.Text = "Alterar senha:";
            // 
            // tbxNovaSenha
            // 
            tbxNovaSenha.Location = new Point(6, 189);
            tbxNovaSenha.Name = "tbxNovaSenha";
            tbxNovaSenha.ReadOnly = true;
            tbxNovaSenha.Size = new Size(205, 23);
            tbxNovaSenha.TabIndex = 5;
            // 
            // btnExcludeUser
            // 
            btnExcludeUser.Location = new Point(6, 133);
            btnExcludeUser.Name = "btnExcludeUser";
            btnExcludeUser.Size = new Size(205, 32);
            btnExcludeUser.TabIndex = 6;
            btnExcludeUser.Text = "Excluir usuário";
            btnExcludeUser.UseVisualStyleBackColor = true;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Location = new Point(6, 223);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(205, 32);
            btnAlterarSenha.TabIndex = 7;
            btnAlterarSenha.Text = "Alterar senha";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(52, 261);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(117, 32);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar tabela";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 331);
            Controls.Add(gbxGerenciar);
            Controls.Add(dataGridView1);
            Name = "frmUsuarios";
            Text = "Gerenciador de Usuários";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbxGerenciar.ResumeLayout(false);
            gbxGerenciar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox gbxGerenciar;
        private Label lblNomeUsuario;
        private TextBox tbxNovaSenha;
        private Label lblAlterarSenha;
        private TextBox tbxEmail;
        private Label lblEmail;
        private TextBox textBox1;
        private Button btnExcludeUser;
        private Button btnAtualizar;
        private Button btnAlterarSenha;
    }
}