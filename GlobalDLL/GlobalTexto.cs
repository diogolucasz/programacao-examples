using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDLL
{
    public class GlobalTexto
    {

        public static string Format(string text, params object[] parameters)
        {
            string result = text;

            if (parameters != null && parameters.Count() > 0)
            {
                int index = 0;
                foreach (var parameter in parameters)
                {
                    if (parameter != null)
                    {
                        string indexText = "{" + index.ToString() + "}";

                        if (result.Contains(indexText))
                        {
                            result = result.Replace(indexText, parameter.ToString());
                        }
                    }
                    index++;
                }
            }

            return result;
        }

        //Crie um a função estática Chamada "ObterNome", na classe "GlobalTexto" na DLL "GlobalDLL",
        // que recebe uma string "nome" por parametro e retorna essa string no formato Primeiro e Último Nome
        // Exemplo: João Fancisco Melro ---> João Melro
        public static string ObterNome(string nome)
        {
            string resultado = string.Empty;

            string[] nomes = nome.Split(' ');

            if (nomes.Length <= 1)
            {
                resultado = nome;
            }
            else
            {
                resultado = nomes[0] + " " + nomes[nomes.Length - 1];
            }

            return resultado;        
        }


        //Crie um a função estática Chamada "ObterUltimoPrimeiroNome", na classe "GlobalTexto" na DLL "GlobalDLL",
        // que recebe uma string "nome" por parametro e retorna essa string no formato Último Nome + Virgula + Primeiro Nome
        // Exemplo: João Fancisco Melro ---> Melro, João
        public static string ObterUltimoPrimeiroNome(string nome)
        {
            string resultado = string.Empty;

            string[] nomes = nome.Split(' ');

            if (nomes.Length <= 1)
            {
                resultado = nome;
            }
            else
            {
                resultado = nomes[nomes.Length - 1] + ", " + nomes[0];
            }

            return resultado;
        }

    }
}
