namespace Notebook.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Note")]
    public partial class Note
    {
        public int No { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(200)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Username { get; set; }

        public virtual LoginDB LoginDB { get; set; }

        public virtual NoteDB NoteDB { get; set; }
    }
}
