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
    
    public partial class Projeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projeto()
        {
            this.Aluno_Projeto = new HashSet<Aluno_Projeto>();
            this.Avaliador_Projeto = new HashSet<Avaliador_Projeto>();
            this.Liderancas = new HashSet<Lideranca>();
            this.Orientador_Projeto = new HashSet<Orientador_Projeto>();
            this.Pesoes = new HashSet<Peso>();
        }
    
        public int Id { get; set; }
        public string Status { get; set; }
        public string Resposta_1 { get; set; }
        public string Resposta_2 { get; set; }
        public string Resposta_3 { get; set; }
        public string Resposta_4 { get; set; }
        public string Resposta_5 { get; set; }
        public string Resposta_6 { get; set; }
        public string Resposta_7 { get; set; }
        public string Resposta_8 { get; set; }
        public string Resposta_9 { get; set; }
        public string Resposta_10 { get; set; }
        public string Resposta_11 { get; set; }
        public string Resposta_12 { get; set; }
        public string Resposta_13 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aluno_Projeto> Aluno_Projeto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliador_Projeto> Avaliador_Projeto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lideranca> Liderancas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orientador_Projeto> Orientador_Projeto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Peso> Pesoes { get; set; }
    }
}
