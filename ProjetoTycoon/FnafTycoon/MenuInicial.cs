using FnafTycoon.Repository.Contract;
using Krypton.Toolkit;
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
    public partial class MenuInicial : KryptonForm
    {
        IPizzasRepository _pizzasRepository;
        public MenuInicial(IPizzasRepository pizzasRepository)
        {
            InitializeComponent();
            _pizzasRepository = pizzasRepository;
            PnBotaoInicial.Width = PnBotaoInicial.MaximumSize.Width;
            PnBotoes.Width = PnBotoes.MaximumSize.Width;
            BarraCarregamento.Visible = false;
            
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        private void BtInicio_Click(object sender, EventArgs e)
        {
            BtInicio.Visible = false;
            BtInicio.Enabled = false;
            PnBotaoInicial.Width = PnBotaoInicial.MinimumSize.Width;

        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            PnBotoes.Visible = false;
            PnBotoes.Enabled = false;
            PnBotoes.Width = PnBotoes.MinimumSize.Width;
            BarraCarregamento.Visible=true;
            TmLoading.Start();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TmLoading_Tick(object sender, EventArgs e)
        {
            {
                if (BarraCarregamento.Value < 1000)
                {
                    BarraCarregamento.Value = BarraCarregamento.Value + 10;
                }
                else
                {
                    TmLoading.Enabled = false;
                    this.Visible = false;

                    Menu Menu = new Menu(_pizzasRepository);
                    this.Hide();
                    Menu.Show();
                    
                }
            }
        }
    }
}
