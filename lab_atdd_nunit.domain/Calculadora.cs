using System;

namespace lab_atdd_nunit.domain
{
    /// <summary>
    /// Clase Calculadora
    /// </summary>
    public class Calculadora
    {
        public const string _SUMANDO_NEGATIVO = "Uno de los sumandos es negativo, no se puede realizar la suma";
        //public int Suma (int numeroUno, int numeroDos) => numeroUno + numeroDos;
        public int Suma (int numeroUno, int numeroDos) {
            if (numeroUno < 0) throw new Exception(_SUMANDO_NEGATIVO);
            if (numeroDos < 0) throw new Exception(_SUMANDO_NEGATIVO);
            return numeroUno + numeroDos;
        }
    }
}
