//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pokedex
{
    using System;
    using System.Collections.Generic;
    
    public partial class orden
    {
        public int ordenID { get; set; }
        public Nullable<int> ordenNumero { get; set; }
        public string idtipo { get; set; }
        public Nullable<int> idPokemon { get; set; }
    
        public virtual pokemon pokemon { get; set; }
        public virtual tipo tipo { get; set; }
    }
}
