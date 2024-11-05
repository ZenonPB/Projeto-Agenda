namespace ProjetoAgenda.Views
{
    partial class frmAddCtg
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
            txtNomeCtg = new Label();
            tbxNomeCtg = new TextBox();
            btnCadastro = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtNomeCtg
            // 
            txtNomeCtg.AutoSize = true;
            txtNomeCtg.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNomeCtg.ForeColor = SystemColors.ButtonFace;
            txtNomeCtg.Location = new Point(6, 9);
            txtNomeCtg.Name = "txtNomeCtg";
            txtNomeCtg.Size = new Size(237, 35);
            txtNomeCtg.TabIndex = 0;
            txtNomeCtg.Text = "Nome da Categoria";
            // 
            // tbxNomeCtg
            // 
            tbxNomeCtg.Location = new Point(14, 55);
            tbxNomeCtg.Name = "tbxNomeCtg";
            tbxNomeCtg.Size = new Size(219, 23);
            tbxNomeCtg.TabIndex = 1;
            tbxNomeCtg.TextChanged += tbxNomeCtg_TextChanged;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(14, 93);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(95, 42);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(138, 93);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(95, 42);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmAddCtg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(250, 152);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastro);
            Controls.Add(tbxNomeCtg);
            Controls.Add(txtNomeCtg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddCtg";
            Text = "Adicionar Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNomeCtg;
        private TextBox tbxNomeCtg;
        private Button btnCadastro;
        private Button btnLimpar;
    }
}