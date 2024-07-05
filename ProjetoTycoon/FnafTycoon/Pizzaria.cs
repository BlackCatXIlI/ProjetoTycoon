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

    public partial class Pizzaria : Form
    {
        IPizzasRepository _pizzasRepository;
        public Pizzaria(IPizzasRepository pizzasRepository)
        {
            InitializeComponent();
            _pizzasRepository = pizzasRepository;
        }



        private void BTpizza_Click(object sender, EventArgs e)
        {

        }

        private void BTpizza_Click_1(object sender, EventArgs e)
        {
            _pizzasRepository.Adicionar(1);
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
