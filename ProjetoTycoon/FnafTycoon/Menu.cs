using FnafTycoon.Repository;
using FnafTycoon.Repository.Contract;
using Krypton.Toolkit;


namespace FnafTycoon
{
    public partial class Menu : KryptonForm
    {
        IPizzasRepository _pizzasrepository;
        public Menu(IPizzasRepository pizzasRepository)
        {
            InitializeComponent();
            _pizzasrepository = pizzasRepository;
            AbrirNovaJanela(new Pizzaria(_pizzasrepository));
        }

        int PizzaL = 0;
        bool SideMenu;
        private void AbrirNovaJanela(object abrirnovajanela)
        {
            if (this.PNmenu.Controls.Count > 0)
                this.PNmenu.Controls.RemoveAt(0);
            Form novaJan = abrirnovajanela as Form;
            novaJan.TopLevel = false;
            novaJan.Dock = DockStyle.Fill;
            this.PNmenu.Controls.Add(novaJan);
            this.PNmenu.Tag = novaJan;
            novaJan.Show();

        }


        private void T1_Tick(object sender, EventArgs e)
        {
            PizzaL = _pizzasrepository.GetPizzas();
            TBpizzas.Text = PizzaL.ToString();
            int dindin = 0;
            dindin = _pizzasrepository.GetDinheiro();
            TBdinheiro.Text = dindin.ToString();
        }


        private void TBdinheiro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int dindin = 0;
            dindin = _pizzasrepository.GetDinheiro();
            TBdinheiro.Text = dindin.ToString();
        }



        private void BTpizzaria_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Pizzaria(_pizzasrepository));
        }



        private void BTloja_Click_1(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Loja(_pizzasrepository));
        }

        private void BTanimatronicos_Click_2(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Animatronicos());
        }


        private void SideTimer_Tick(object sender, EventArgs e)
        {

            if (SideMenu)
            {
                PnSideMenu.Visible = false;
                PnSideMenu.Width = PnSideMenu.MinimumSize.Width;
                PnSide.Width -= 8;
                if (PnSide.Width == PnSide.MinimumSize.Width)
                {
                    SideMenu = false;
                    SideTimer.Stop();
                }
            }
            else
            {
                PnSide.Width += 8;
                if (PnSide.Width == PnSide.MaximumSize.Width)
                {
                    SideMenu = true;
                    SideTimer.Stop();
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            SideTimer.Start();
        }

        private void BtOpc_Click(object sender, EventArgs e)
        {
            PnSideMenu.Visible = true;
            PnSideMenu.Width = PnSideMenu.MaximumSize.Width;
        }

        private void BtConf_Click(object sender, EventArgs e)
        {
            PnSideMenu.Visible = true;
            PnSideMenu.Width = PnSideMenu.MaximumSize.Width;
        }

        private void BtSobre_Click(object sender, EventArgs e)
        {
            PnSideMenu.Visible = true;
            PnSideMenu.Width = PnSideMenu.MaximumSize.Width;
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
