using FnafTycoon.Models;
using FnafTycoon.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FnafTycoon.Repository
{
    public class PizzasRepository : IPizzasRepository
    {
        Pizzas pizzasI = new Pizzas();
        public void Adicionar(int pizzas)
        {
            
            pizzasI.Pizza = pizzasI.Pizza + pizzas;
        }

        public int GetPizzas()
        {
            
            return pizzasI.Pizza;
        }     
        public int GetDinheiro()
        {
            
            return pizzasI.Dinheiro;
        }

        public void Vender(int quant, int valor)
        {
            try
            {
                if (pizzasI.Pizza != quant && quant != 0)
                {
                    int resul = 0;
                    resul = pizzasI.Pizza - quant;
                    pizzasI.Dinheiro = pizzasI.Dinheiro + pizzasI.Pizza * valor;
                    pizzasI.Pizza = resul;

                }
                if (pizzasI.Pizza == quant && quant != 0)
                {
                    int resul = 0;
                    resul = pizzasI.Pizza - quant;
                    pizzasI.Dinheiro = pizzasI.Dinheiro + pizzasI.Pizza * valor;
                    pizzasI.Pizza = resul;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
