using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class AddPrdct : UserControl
    {
        public AddPrdct()
        {
            InitializeComponent();
           
            comboBox1.DataSource = ConnectionDB.ExecuteQuery($"SELECT name FROM BUSINESS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals(null) || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                try
                {
                    var set = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS " +
                                                        $"WHERE name = '{comboBox1.SelectedItem}'");
                    var id = set.Rows[0];
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO PRODUCT('{id}', '{comboBox1.SelectedItem}')" +
                                                 $"VALUES(1, '{textBox1.Text}');");

                    MessageBox.Show("Producto agregado exitosamente");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha habido un error");
                }
            }
        }
    }
}