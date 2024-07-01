using FnafTycoon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FnafTycoon.Repository.Contract
{
    public interface IPizzasRepository
    {
        void Adicionar(int pizzas);
        
        int GetPizzas();
        int GetDinheiro();

        void Vender(int quant, int valor);
    }
}
