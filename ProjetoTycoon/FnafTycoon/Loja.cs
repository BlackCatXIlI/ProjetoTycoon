using FnafTycoon.Repository.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FnafTycoon
{
    public partial class Loja : Form
    {
        IPizzasRepository _ipizzasRepository;
        public Loja(IPizzasRepository pizzasRepository)
        {
            _ipizzasRepository = pizzasRepository;
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int dindin = 0;
            dindin = _ipizzasRepository.GetDinheiro();
            int pizzas = 0;
            pizzas = _ipizzasRepository.GetPizzas();

            _ipizzasRepository.Vender(pizzas, 5);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Loja_Load(object sender, EventArgs e)
        {

        }
    }
}
