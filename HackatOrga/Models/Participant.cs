using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Participant
    {
        public int Idparticipant { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public DateOnly? Datenaissance { get; set; }
        public string? Ville { get; set; }
        public string? Rue { get; set; }
        public string? Cp { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public string? Mdp { get; set; }
    }
}
