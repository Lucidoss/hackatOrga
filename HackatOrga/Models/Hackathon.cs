using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Hackathon
    {
        public int Idhackathon { get; set; }
        public DateOnly? Datedebut { get; set; }
        public DateOnly? Datefin { get; set; }
        public TimeOnly? Heuredebut { get; set; }
        public TimeOnly? Heurefin { get; set; }
        public string? Lieu { get; set; }
        public string? Rue { get; set; }
        public string? Ville { get; set; }
        public string? Cp { get; set; }
        public string? Theme { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateOnly? Datelimite { get; set; }
        public long? Nbplaces { get; set; }
    }
}
