using System;
using Xunit;
using CursoOnline.Models;

namespace CursoOnline.Tests
{
    public class CursoTest
    {
        [Fact]
        public void CriarCurso()
        {
            string nome = "Curso de ADS";
            string publicoAlvo = "Estudante";

            var curso = new Curso(nome, publicoAlvo);

            Assert.Equal(nome, curso.nome);
            Assert.Equal(publicoAlvo, curso.publicoAlvo);          

        }

        [Fact]
        public void CriarCliente_Cpf_ok()
        {
            string nome = "Rodrigo";
            string cpfValido = "980.699.080-33";

            var cliente = new Cliente(nome, cpfValido);
         
            Assert.True(ValidaDigitoCPF.ValidaCPF(cliente.cpf)); 
            Assert.Equal(nome, cliente.nome);          
            Assert.Equal(cpfValido, cliente.cpf);          
        }

        [Fact]
        public void CriarCliente_Cpf_Invalido()
        {
            string nome = "Rodrigo";
            string cpfInvalido = "021.699.080-33";

            var ex = Assert.Throws<Exception>(() => new Cliente(nome, cpfInvalido));
            Assert.Equal("Cpf Inválido", ex.Message);
 
        }               

    }
}
