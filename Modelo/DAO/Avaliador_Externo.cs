//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Avaliador_Externo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avaliador_Externo()
        {
            this.Avaliador_Projeto = new HashSet<Avaliador_Projeto>();
        }
    
        public int Id { get; set; }
        public int Id_Participante { get; set; }
        public string Area_Atuacao { get; set; }
        public string Formacao { get; set; }
    
        public virtual Participante Participante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliador_Projeto> Avaliador_Projeto { get; set; }
    }
}
