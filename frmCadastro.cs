﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void habilitarCadastrar()
        {
            if (tbxNome.Text != "" && tbxUsuario.Text != "" && tbxSenha.Text.Length > 8 && tbxSenha == tbxConfirm)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }
        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }
        private void tbxTelefone_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void tbxConfirm_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
