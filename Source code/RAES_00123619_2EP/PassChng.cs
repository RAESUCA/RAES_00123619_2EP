using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class PassChng : UserControl
    {
        public PassChng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                try
                {
                    var dt = ConnectionDB.ExecuteQuery($"SELECT idUser " +
                                                       $"FROM APPUSER  WHERE username = '{textBox1.Text}' AND password = '{textBox2.Text}'");
                    var dr = dt.Rows[0];
                    var key = (dr[0]);
                    ConnectionDB.ExecuteNonQuery($"UPDATE APPUSER SET password = '{textBox3.Text}' WHERE idUser = '{key}'");
                    
                    MessageBox.Show("Contraseña cambiada");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Un error ha ocurrido");
                }
            }
        }
    }
}