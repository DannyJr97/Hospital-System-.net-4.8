using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital97.UI
{
    public partial class MenuForm2222 : Form
    {
        public MenuForm2222()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnFecharMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool menuExpand = false;

        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuContainer.Height -= 50;
                if (menuContainer.Height <= 83)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                menuContainer.Height += 50;
                if (menuContainer.Height >= 225)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
            }
        }

        private void btnPacientesDoutores_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 280)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
