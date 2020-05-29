using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                try
                {
                   var dt = ConnectionDB.ExecuteQuery($"SELECT userType " +
                   $"FROM APPUSER  WHERE username = '{textBox1.Text}' AND password = '{textBox2.Text}'");
                   var dr = dt.Rows[0];
                   var key = (dr[0]);
                   if (key.Equals(true))
                   {
                       Hide();
                       AdminMenu ad = new AdminMenu();
                       ad.Dock = DockStyle.Fill;
                       Parent.Controls.Add(ad);
                   }
                   else
                   {
                       Hide();
                       NormalMenu nor = new NormalMenu();
                       nor.Dock = DockStyle.Fill;
                       Parent.Controls.Add(nor);
                   }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
           PassChng pas = new PassChng();
            pas.Dock = DockStyle.Fill;
            Parent.Controls.Add(pas);
        }
    }
}