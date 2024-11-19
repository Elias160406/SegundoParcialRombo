using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRombo.Entidades
{
    public class Rombo
        {

            public int DiagonalMayor { get; set; }
            public int DiagonalMenor { get; set; }
        public int TipoContorno { get; set; }
            public double Lado
            {
                get
                {
                    return Math.Sqrt(Math.Pow(DiagonalMayor / 2.0, 2) + Math.Pow(DiagonalMenor / 2.0, 2));
                }
            }


            public double CalcularArea()
            {
                return (DiagonalMayor * DiagonalMenor) / 2.0;
            }


            public double CalcularPerimetro()
            {
                return 4 * Lado;
            }


            public Rombo(int diagonalMayor, int diagonalMenor)
            {
                DiagonalMayor = diagonalMayor;
                DiagonalMenor = diagonalMenor;
            }

        }
    }


    