using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krotoz
{
    public partial class frmFileName : Form
    {
        public Action<string> crear;
        public frmFileName()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var titulo = txtTitle.Text;
            crear(titulo);
            this.Close();
        }
    }
}
