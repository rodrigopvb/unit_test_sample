namespace CursoOnline
{
    public class Curso{

        public string nome {get; set;}
        public string publicoAlvo {get; set;}

        public Curso(string nome, string publicoAlvo){            
            
            this.nome = nome;
            this.publicoAlvo = publicoAlvo;


        }
    }
}