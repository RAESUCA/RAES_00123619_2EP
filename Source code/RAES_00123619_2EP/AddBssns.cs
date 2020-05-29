using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class AddBssns : UserControl
    {
        public AddBssns()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || richTextBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los formularios");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO BUSINESS(name, description) " +
                                                 $"VALUES ('{textBox1.Text}', '{richTextBox1.Text}');");
                    MessageBox.Show("Negocio agregado");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}