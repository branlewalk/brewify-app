using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace shire_project.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string Body { get; set; }
        [Column(TypeName = "TIMESTAMP")]
        public DateTime? Created { get; set; }

        public Note() { }
    }
}
