using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class LivroCollection : Collection<Livro>
    {
        public int ContarLivrosDeAventura()
        {
            //V1
            //int count = this.Count(k => k.GeneroLivro == GeneroLivroEnum.Aventura);

            //V2
            int count = this.ContarLivrosDoGenero(GeneroLivroEnum.Aventura);

            return count;
        }

        public int ContarLivrosDoGenero(GeneroLivroEnum generoLivro)
        {
            //V1
            //int count = this.Count(k => k.GeneroLivro == generoLivro);

            //V2
            int count = (from element in this
                         where element.GeneroLivro == generoLivro
                         select element).Count();

            return count;
        }

        public int ContarLivrosUltimos3Meses()
        {
            DateTime dataInicio = DateTime.Today.AddMonths(-3);
            DateTime dataFim = DateTime.Today;

            //V1
            //int count = this.Count(k => k.DataEdicao >= dataInicio && k.DataEdicao <= dataFim);

            //V2
            int count = this.ContarLivrosEntreDatas(dataInicio, dataFim); 

            return count;
        }

        public int ContarLivrosEntreDatas(DateTime dataInicio, DateTime dataFim)
        {
            //V1
            //int count = this.Count(k => k.DataEdicao >= dataInicio && k.DataEdicao <= dataFim);

            //V2
            int count = (from element in this
                         where element.DataEdicao >= dataInicio && element.DataEdicao <= dataFim
                         select element).Count();

            return count;
        }

        public IEnumerable<Livro> ObterListaLivros()
        {
            int ano = DateTime.Today.Year;

            //V1
            //IEnumerable<Livro> livros = this.Where(k => k.DataEdicao.Year == ano)
            //                                .OrderBy(k => k.DataEdicao)
            //                                .ThenByDescending(k => k.Titulo);

            IEnumerable<Livro> livros = from element in this
                                        where element.DataEdicao.Year == ano
                                        orderby element.DataEdicao, element.Titulo descending
                                        select element;

            return livros;
        }

        public IEnumerable<Livro> ObterListaLivros2()
        {
            IEnumerable<Livro> livros = from element in this
                                        where element.LivroGrande()
                                        orderby element.Titulo descending
                                        select element;

            return livros;
        }

        //V1
        public float ObterMediaPaginasLivroEditadosMesCorrenteV1()
        {
            IEnumerable<Livro> livros = from element in this
                                        where element.MesCorrente()
                                        select element;

            //V1
            //float media = (float)livros.Average(k => k.NumeroPaginas);

            //V2
            float media = (float)(from element in livros
                                  select element.NumeroPaginas).Average();

            return media; 
        }

        //V2
        public float ObterMediaPaginasLivroEditadosMesCorrenteV2()
        {
            float media = (float)(from element in this
                                  where element.MesCorrente()
                                  select element.NumeroPaginas).Average();

            return media;
        }


    }
}
