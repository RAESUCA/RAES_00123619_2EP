using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class create : UserControl
    {
        public create()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") 
                || comboBox1.SelectedItem.Equals(null))
            {
                MessageBox.Show("Se deben llenar todos los campos");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO APPUSER(fullname, username, password, userType) " +
                                                 $"VALUES('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', " +
                                                 $"'{comboBox1.SelectedItem.ToString()}')");
                    MessageBox.Show("Ha sido agregado exitosamente");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}