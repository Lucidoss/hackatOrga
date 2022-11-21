using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Evenement
    {
        public int Idevenement { get; set; }
        public int Idhackathon { get; set; }
        public string? Nomevenement { get; set; }
        public DateOnly? Datedebut { get; set; }
        public DateOnly? Datefin { get; set; }
        public TimeOnly? Duree { get; set; }
    }
}
