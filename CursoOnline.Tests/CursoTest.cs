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
        public void CriarCurso_Valida_Campo_Valor_Null()
        {
            string nome = "Curso de ADS";
            string publicoAlvo = "Estudante";
            string valor = null;

            var curso = new Curso(nome, publicoAlvo);

            Assert.Equal(nome, curso.nome);
            Assert.Equal(publicoAlvo, curso.publicoAlvo); 
            

        }

    }
}
