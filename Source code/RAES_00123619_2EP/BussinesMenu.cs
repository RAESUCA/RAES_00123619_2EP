using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class BussinesMenu : UserControl
    {
        private UserControl current;
        private AddBssns add = new AddBssns();
        public BussinesMenu()
        {
            InitializeComponent();
            add.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(add,0, 1);
            current = add;
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}