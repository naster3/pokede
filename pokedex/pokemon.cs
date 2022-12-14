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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.IO;
    using System.Net;

    public partial class pokemon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pokemon()
        {
            this.orden = new HashSet<orden>();
        }
    
        public int idPokemon { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string tipo { get; set; }
        public string path { get; set; }

        

        [NotMapped]
        public Image image { 
            get 
            {
                if (!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path)) return Image.FromFile(path);
                }
                return null;
            } 
            
        }
        

        

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden> orden { get; set; }
        public virtual tipo tipo1 { get; set; }
    }
}
