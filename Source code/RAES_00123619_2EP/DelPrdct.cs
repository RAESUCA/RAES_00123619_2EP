using System;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class DelPrdct : UserControl
    {
        
        public DelPrdct()
        {
            InitializeComponent();
            comboBox1.DataSource = ConnectionDB.ExecuteQuery($"SELECT name FROM BUSINESS");
           // var set = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS " +
           //                                    $"WHERE name = '{comboBox1.SelectedItem}'");

            // comboBox2.DataSource = ConnectionDB.ExecuteQuery($"SELECT name FROM PRODUCT WHERE idBusiness ='{set}'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals(null))
            {
                MessageBox.Show("Seleccione una opcion");
            }
            else
            {
                Hide();
                int id= Convert.ToInt32(ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS " +
                                                                  $"WHERE name = '{comboBox1.SelectedItem}'"));
                DelProdct del = new DelProdct(id);
                del.Dock = DockStyle.Fill;
                Parent.Controls.Add(del);
            }
        }
    }
}