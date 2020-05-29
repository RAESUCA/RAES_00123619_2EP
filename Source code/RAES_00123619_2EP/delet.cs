using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class delet : UserControl
    {
        public delet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                try
                {
                    var dt = ConnectionDB.ExecuteQuery($"SELECT idUser " +
                                                       $"FROM APPUSER  WHERE username = '{textBox1.Text}'");
                    var dr = dt.Rows[0];
                    var key = (dr[0]);
                    ConnectionDB.ExecuteNonQuery($"DELETE FROM APPUSER WHERE idUser = '{key}'");
                    
                    MessageBox.Show("Usuario eliminado");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
        }
    }
}