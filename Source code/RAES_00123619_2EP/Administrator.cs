using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class Administrator : UserControl
    {
        private UserControl current;
        private delet del = new delet();
        private Consult cons = new Consult();
        public Administrator()
        {
            InitializeComponent();
            current = create1;
            create1.Dock = DockStyle.Fill;
            del.Dock = DockStyle.Fill;
            cons.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(create1,0, 1);
            current = create1;
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetColumnSpan(current,3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(del,0, 1);
            current = del;
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetColumnSpan(current,3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(cons,0, 1);
            current = cons;
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetColumnSpan(current,3);
        }
    }
}