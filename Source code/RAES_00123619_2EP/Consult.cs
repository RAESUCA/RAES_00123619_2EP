using System.Data;
using System.Windows.Forms;

namespace RAES_00123619_2EP
{
    public partial class Consult : UserControl
    {
        private DataTable dt = ConnectionDB.ExecuteQuery($"SELECT * FROM APPUSER;");

        public Consult()
        {
            InitializeComponent();
        }

    }
    
}