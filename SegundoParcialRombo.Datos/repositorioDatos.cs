using SegundoParcialRombo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SegundoParcialRombo.Datos
{
    internal class RepositorioRombos
    {


      
        private List<Rombo> rombos;

     
        public RepositorioRombos()
        {
            rombos = new List<Rombo>();
        }

       
        public int CantidadDeRombos()
        {
            return rombos.Count;
        }

        public bool AgregarRombo(Rombo nuevoRombo)
        {
            if (!rombos.Any(r => r.DiagonalMayor == nuevoRombo.DiagonalMayor &&
                                 r.DiagonalMenor == nuevoRombo.DiagonalMenor &&
                                 r.TipoContorno == nuevoRombo.TipoContorno))
            {
                rombos.Add(nuevoRombo);
                return true; 
            }
            return false; 
        }
        private double CalcularLado(Rombo rombo)
        {
            return Math.Sqrt(
                Math.Pow(rombo.DiagonalMayor / 2, 2) +
                Math.Pow(rombo.DiagonalMenor / 2, 2)
            );
        }

       
        public List<Rombo> OrdenarPorLadoAscendente()
        {
            return rombos.OrderBy(r => CalcularLado(r)).ToList();
        }

        
        public List<Rombo> OrdenarPorLadoDescendente()
        {
            return rombos.OrderByDescending(r => CalcularLado(r)).ToList();
        }
    }
}
}
