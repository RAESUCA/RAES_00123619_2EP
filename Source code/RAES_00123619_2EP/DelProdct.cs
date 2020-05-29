using System.Data;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class DelProdct : UserControl
    {
        public DelProdct( int id )
        {
            InitializeComponent();
            comboBox1.DataSource = ConnectionDB.ExecuteQuery($"SELECT name FROM PRODUCT WHERE idBusiness = '{id}'");
        }
    }
}