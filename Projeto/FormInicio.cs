using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploProjeto
{
    public partial class FormInicio : Form
    {
        #region Contrutor

        public FormInicio()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void comboioButton_Click(object sender, EventArgs e)
        {
            using (FormComboio formComboio = new FormComboio())
            {
                formComboio.ShowDialog();
            }
        }

        private void lojaButton_Click(object sender, EventArgs e)
        {
            using (FormLoja formLoja = new FormLoja())
            {
                formLoja.ShowDialog();
            }
        }

        private void projetoButton_Click(object sender, EventArgs e)
        {
            using (ProjetoForm projetoForm = new ProjetoForm())
            {
                projetoForm.ShowDialog();
            }
        }

        private void livroButton_Click(object sender, EventArgs e)
        {
            //V1
            //FormLivro formLivro = new FormLivro();
            //formLivro.ShowDialog();
            //formLivro.Dispose();

            //V2
            using (FormLivro formLivro = new FormLivro())
            {
                formLivro.ShowDialog();
            }
        }

        #endregion

    }
}
