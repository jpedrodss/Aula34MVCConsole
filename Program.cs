using System;
using Aula34MVCConsole.Controllers;

namespace Aula34MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController a = new ProdutoController();

            a.Buscar("1799");
        }
    }
}
