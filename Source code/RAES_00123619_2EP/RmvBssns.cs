using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class RmvBssns : UserControl
    {
        public RmvBssns()
        {
            InitializeComponent();
            comboBox1.DataSource = ConnectionDB.ExecuteQuery($"SELECT name FROM BUSINESS").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals(null))
            {
                MessageBox.Show("Seleccione una opcion");
            }
            else
            {
                try
                {
                    var set = comboBox1.SelectedItem;
                    var dat = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS WHERE name = '{set}'");
                    var id = dat.Rows[0];
                    ConnectionDB.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE idBusiness = '{id}'");

                    MessageBox.Show("Negocio eliminado");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}