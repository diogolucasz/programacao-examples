using CamadaNegocio;
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
    public partial class FormLivro : Form
    {
        #region Contrutores

        public FormLivro()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        private LivroCollection livros;

        #endregion

        #region Metodos

        private void CarregarLivros()
        {
            this.livros = new LivroCollection();

            Livro livro = new Livro();
            livro.EAN = 3510000123;
            livro.Titulo = "Estudar Programação";
            livro.DataEdicao = new DateTime(2020, 10, 3);
            livro.NumeroPaginas = 120;
            livro.GeneroLivro = GeneroLivroEnum.Drama;

            this.livros.Add(livro);

            livro = new Livro(3510000124, "Fazer o Trabalho", new DateTime(2020, 12, 3), 32, GeneroLivroEnum.Aventura);
            this.livros.Add(livro);

            livro = new Livro(3510000125, "Dormir", new DateTime(2020, 12, 26), 132, GeneroLivroEnum.Accao);
            this.livros.Add(livro);

            livro = new Livro(3510000126, "Acordar", new DateTime(2019, 1, 26), 320, GeneroLivroEnum.Aventura);
            this.livros.Add(livro);
        }

        private void Executar()
        {
            this.ContarLivros();
            this.ContarLivrosDeAventura();
            this.ContarLivrosUltimos3Meses();
            this.PreencherListaLivros();
        }

        private void PreencherListaLivros()
        {
            //Obter Lista de Livros
            IEnumerable<Livro> novaLista = this.livros.ObterListaLivros();

            //Preencher a ListBox com a lista de Livros
            this.PreencherListBox(novaLista);
        }

        private void PreencherListBox(IEnumerable<Livro> novaLista)
        {
            //Apagar todos os elementos da lista
            this.resultadoListBox.Items.Clear();

            //Percorrer todos os elementos da lista
            foreach (Livro livro in novaLista)
            {
                //Para cada Elemento, adicionar a propriedade titulo do objeto livro
                this.resultadoListBox.Items.Add(livro.Titulo);
            }
        }

        private void ContarLivrosUltimos3Meses()
        {
            //Quantos Livros foram editados nos ultimos 3 meses ?

            int count = this.livros.ContarLivrosUltimos3Meses();

            this.resultado3Label.Text = count.ToString();
        }

        private void ContarLivrosDeAventura()
        {
            //Quantos Livros de aventura existem ?
            int count = 0;

            //V1
            foreach (Livro livro in this.livros)
            {
                if (livro.GeneroLivro == GeneroLivroEnum.Aventura)
                {
                    count++;
                }
            }

            //V2
            count = this.livros.Count(k => k.GeneroLivro == GeneroLivroEnum.Aventura);

            //V3
            count = this.livros.ContarLivrosDeAventura();

            this.resultado2Label.Text = count.ToString();
        }

        private void ContarLivros()
        {
            //Quantos Livros existem ?
            int count = 0;

            //V1
            foreach (Livro livro in this.livros)
            {
                count++;
            }

            //V2
            count = this.livros.Count;

            this.resultado1Label.Text = count.ToString();
        }

        #endregion

        #region Eventos

        private void FormLivro_Load(object sender, EventArgs e)
        {
            this.CarregarLivros();
        }

        private void FormLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.livros = null;
        }

        private void executarButton_Click(object sender, EventArgs e)
        {
            this.Executar();
        }

        #endregion

        //Exemplifique a funcão ObterUltimoPrimeiroNome criada na DLL
        private void funcaoDLLButton_Click(object sender, EventArgs e)
        {
            string nome = this.nomeTextBox.Text;

            string resultado = GlobalDLL.GlobalTexto.ObterUltimoPrimeiroNome(nome);

            this.resultadoTextBox.Text = resultado;
        }
    }
}
