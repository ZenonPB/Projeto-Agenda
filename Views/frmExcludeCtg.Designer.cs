namespace ProjetoAgenda.Views
{
    partial class frmExcludeCtg
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
            btnExclude = new Button();
            tbxExclude = new TextBox();
            SuspendLayout();
            // 
            // btnExclude
            // 
            btnExclude.Location = new Point(36, 63);
            btnExclude.Name = "btnExclude";
            btnExclude.Size = new Size(178, 32);
            btnExclude.TabIndex = 0;
            btnExclude.Text = "Excluir";
            btnExclude.UseVisualStyleBackColor = true;
            btnExclude.Click += btnExclude_Click;
            // 
            // tbxExclude
            // 
            tbxExclude.Location = new Point(12, 25);
            tbxExclude.Name = "tbxExclude";
            tbxExclude.PlaceholderText = "Digite o ID da categoria";
            tbxExclude.Size = new Size(229, 23);
            tbxExclude.TabIndex = 1;
            // 
            // frmExcludeCtg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 107);
            Controls.Add(tbxExclude);
            Controls.Add(btnExclude);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmExcludeCtg";
            Text = "Excluir Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExclude;
        private TextBox tbxExclude;
    }
}