using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.GUI
{
    public partial class fChinhSuaTonKho : Form
    {
        public fChinhSuaTonKho()
        {
            InitializeComponent();
        }

        public int layTonKhoToiThieu()
        {
            return int.Parse(nmrTonKho.Value.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
