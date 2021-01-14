namespace Notebook.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginDB")]
    public partial class LoginDB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoginDB()
        {
            Notes = new HashSet<Note>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int No { get; set; }

        [Key]
        [StringLength(200)]
        public string Username { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
