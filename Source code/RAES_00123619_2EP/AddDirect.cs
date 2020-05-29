using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class AddDirect : UserControl
    {
        public AddDirect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                                                 $"VALUES(1, 'Residencia X, Casa Y, Santa Tecla, La Libertad');");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
    }
}