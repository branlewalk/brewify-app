using System;

namespace shire_project.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }

        public Note() { }
    }
}
