﻿namespace ProjetoAgenda
{
    partial class frmCadastro
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
            lblNome = new Label();
            tbxNome = new TextBox();
            tbxUsuario = new TextBox();
            lblUsuario = new Label();
            tbxTelefone = new TextBox();
            lblTelefone = new Label();
            tbxConfirm = new TextBox();
            lblConfirm = new Label();
            tbxSenha = new TextBox();
            lblSenha = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(40, 35);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(77, 25);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(40, 63);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(365, 27);
            tbxNome.TabIndex = 2;
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(40, 137);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(365, 27);
            tbxUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(40, 109);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(98, 25);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário";
            // 
            // tbxTelefone
            // 
            tbxTelefone.Location = new Point(40, 214);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.Size = new Size(365, 27);
            tbxTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(40, 186);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(108, 25);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone";
            // 
            // tbxConfirm
            // 
            tbxConfirm.Location = new Point(40, 363);
            tbxConfirm.Name = "tbxConfirm";
            tbxConfirm.Size = new Size(365, 27);
            tbxConfirm.TabIndex = 8;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirm.Location = new Point(40, 335);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(206, 25);
            lblConfirm.TabIndex = 7;
            lblConfirm.Text = "Confirme a senha";
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(40, 287);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(365, 27);
            tbxSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(40, 259);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(80, 25);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(40, 429);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(168, 59);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(237, 429);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 59);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(480, 550);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(tbxSenha);
            Controls.Add(lblSenha);
            Controls.Add(tbxConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(tbxTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(tbxUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(tbxNome);
            Controls.Add(lblNome);
            Name = "frmCadastro";
            Text = "frmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox tbxNome;
        private TextBox tbxUsuario;
        private Label lblUsuario;
        private TextBox tbxTelefone;
        private Label lblTelefone;
        private TextBox tbxConfirm;
        private Label lblConfirm;
        private TextBox tbxSenha;
        private Label lblSenha;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}