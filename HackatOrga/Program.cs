using Microsoft.EntityFrameworkCore;
using HackatOrga.Models;

namespace HackatOrga
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //connexion ? la BD
            hackatonsContext cnx = new hackatonsContext();

            ICollection<Hackathon> FrenchCustomer = cnx.Hackathons.ToList();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Accueil());
        }
    }
}