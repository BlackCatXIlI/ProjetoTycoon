using FnafTycoon.Repository;
using FnafTycoon.Repository.Contract;

namespace FnafTycoon
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cria uma instância de PizzasRepository

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IPizzasRepository pizzasRepository = new PizzasRepository();


            Application.Run(new MenuInicial(pizzasRepository));
        }
    }
}