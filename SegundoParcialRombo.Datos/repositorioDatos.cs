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

       
        public List<Rombo> ObtenerRombos()
        {
            return rombos;
        }
    }
}
