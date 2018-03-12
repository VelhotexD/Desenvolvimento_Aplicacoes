using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerepessoas
{
    class Pessoa
    {
        #region Fields
        private string nome;
        private DateTime data_nascimento;
        private string morada;
        private int pontucao;
        private int idade_final;
        #endregion

        #region Properties
        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public int Idade_Final
        {
            get
            {
                if (idade_final == 0)
                {
                    int idade = DateTime.Now.Year - Data_Nascimento.Year;
                    if (DateTime.Now.Month < Data_Nascimento.Month ||
                        (DateTime.Now.Month == Data_Nascimento.Month && DateTime.Now.Day < Data_Nascimento.Day))
                        idade--;
                    idade_final = idade;
                }
                return idade_final;
            }
        }

        public DateTime Data_Nascimento
        {
            get
            {
                return data_nascimento;
            }
        }

        public string Morada
        {
            get
            {
                return morada;
            }
        }
        public int Pontucao
        {
            get
            {
               return pontucao;
            }
            

        }
        #endregion

        #region Constructors

        public Pessoa()
        {

        }

        public Pessoa(string nome,DateTime data_nascimento, string morada)
        {
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.morada = morada;
            pontucao = 0;
            idade_final = 0;
        }
      
        #endregion

        #region Public Methods
        public int idade()
        {
            //int total;
            //DateTime d1 = DateTime.Now;
            //DateTime d2 = data_nascimento;

            //TimeSpan Tspan = d2 - d1;

            //double idade_final = Tspan.TotalDays;

            //total = Convert.ToInt32(idade_final) / 365;
            //return Convert.ToInt32(total);


            int idade = DateTime.Now.Year - Data_Nascimento.Year;
            if (DateTime.Now.Month < Data_Nascimento.Month ||
                (DateTime.Now.Month == Data_Nascimento.Month && DateTime.Now.Day < Data_Nascimento.Day))
                idade--;

            return idade;
        }
        

        public int pontos()
        {
            pontucao = pontucao + 1;
            return pontucao;

        }

        public override string ToString()
        {
            return string.Concat("Nome: ",Nome," Data de Nascimento: ",Data_Nascimento," Morada: ",Morada,"Idade: ",idade() ," Pontos: ",Pontucao);
        }

        #endregion

        #region Private Methods 
        #endregion

    }
}
