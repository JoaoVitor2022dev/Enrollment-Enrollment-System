using System;
using System.Collections.Generic;

namespace Exercicio_Generic.Entities
{
    internal class Aluno
    {
        public int Matricula { get; set; }

        public Aluno(int matricula)
        {
            Matricula = matricula;
        }
        public override int GetHashCode()
        {
            return Matricula.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Aluno))
            {
                return false; 
            }

            Aluno other = obj as Aluno;
            return Matricula.Equals(other.Matricula); 
        }
    }
}
