using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class Livro
    {
        #region Construtores

        public Livro()
        {
            this.ean = 0;
            this.titulo = string.Empty;
            this.dataEdicao = DateTime.Today;
            this.numeroPaginas = 0;
            this.generoLivro = GeneroLivroEnum.NaoDefinido;
        }

        public Livro(long ean, string titulo, DateTime dataEdicao, int numeroPaginas, GeneroLivroEnum generoLivro)
            : this()
        {
            this.ean = ean;
            this.titulo = titulo;
            this.dataEdicao = dataEdicao;
            this.numeroPaginas = numeroPaginas;
            this.generoLivro = generoLivro;
        }

        #endregion

        #region Propriedades

        private long ean;
        public long EAN
        {
            get { return ean; }
            set { ean = value; }
        }

        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private DateTime dataEdicao;
        public DateTime DataEdicao
        {
            get { return dataEdicao; }
            set { dataEdicao = value; }
        }

        private int numeroPaginas;
        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        private GeneroLivroEnum generoLivro;
        public GeneroLivroEnum GeneroLivro
        {
            get { return generoLivro; }
            set { generoLivro = value; }
        }

        #endregion

        #region Metodos

        //V1
        internal bool LivroGrande()
        {
            bool ok = false;
            DateTime data = new DateTime(DateTime.Today.Year, 1, 1);

            if (this.NumeroPaginas >= 100 &&
                this.DataEdicao >= data &&
                this.GeneroLivro != GeneroLivroEnum.NaoDefinido)
            { 
                ok = true;                
            }

            return ok;
        }

        //V2
        internal bool LivroGrandeV2()
        {
            bool ok = false;

            if (this.NumeroPaginasGrande() &&
                this.DataDoAnoCorrente() &&
                this.GeneroLivroDefinido())
            {
                ok = true;
            }

            return ok;
        }

        private bool GeneroLivroDefinido()
        {
            bool ok = (this.GeneroLivro != GeneroLivroEnum.NaoDefinido);
            return ok;
        }

        private bool DataDoAnoCorrente()
        {
            DateTime data = this.InicioDoAnoCorrente();
            bool ok = (this.DataEdicao >= data);
            return ok;
        }

        private DateTime InicioDoAnoCorrente()
        {
            DateTime data = new DateTime(DateTime.Today.Year, 1, 1);
            return data;
        }

        private bool NumeroPaginasGrande()
        {
            bool ok = (this.NumeroPaginas >= 100);
            return ok;
        }

        internal bool MesCorrente()
        {
            bool ok = false;

            int ano = DateTime.Today.Year;
            int mes = DateTime.Today.Month;

            if (this.DataEdicao.Year == ano &&
                this.dataEdicao.Month == mes)
            {
                ok = true;
            }

            return ok;
        }

        #endregion


    }
}
