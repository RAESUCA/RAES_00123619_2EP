using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class AdminMenu : UserControl
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Administrator usr = new Administrator();
            usr.Dock = DockStyle.Fill;
            Parent.Controls.Add(usr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            BussinesMenu bsm = new BussinesMenu();
            bsm.Dock = DockStyle.Fill;
            Parent.Controls.Add(bsm);
        }
    }
}