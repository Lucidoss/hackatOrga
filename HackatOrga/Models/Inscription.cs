using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Inscription
    {
        public int Code { get; set; }
        public int Idparticipant { get; set; }
        public int Idhackathon { get; set; }
        public DateOnly? Dateinscription { get; set; }
        public string? Description { get; set; }
    }
}
