using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_intermediario.Models
{
    public class Pessoa
    {
        public Pessoa() // Construtor, para quando os valores sāo informados depois        
        { 

        }
        public Pessoa(string nome, string sobrenome) // Construtor (Para valores padrāo) - Mesmo nome da classe
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome) // Deconstrutor
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; // Campo utilizado apenas na classe, para tratativas internas (Ex.: Validaçōes)
        private int _idade;

        public string Nome 
        {
            get
            {
                return _nome.ToUpper();
            } //ou get => _nome.ToUpper(); (Usado para atribuiçōes simples)


            set
            {
                if (value/*Variável que recebe o valor internamente*/ == "")
                {
                    throw new ArgumentException("O nome nāo pode ser vazio"); // Para a aplicaçāo e espera uma correçāo. Caso nāo receba uma correçāo o programa será encerrado
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Propriedade apenas com GET

        public int Idade 
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade nāo pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}