using System;

namespace CursoOnline
{
    public class Cliente{

        public string nome {get; set;}
        public string cpf {get; set;}

        public Cliente(string nome, string cpf){            
            
            if(!ValidaDigitoCPF.ValidaCPF(cpf)){
                throw new Exception("Cpf Inválido");
                // throw new Exception();
            }
            
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}