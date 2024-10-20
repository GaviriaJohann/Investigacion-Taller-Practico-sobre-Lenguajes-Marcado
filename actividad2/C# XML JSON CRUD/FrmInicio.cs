using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__XML_JSON_CRUD
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnXML_Click(object sender, EventArgs e)
        {
            FrmXml frmXml = new FrmXml();
            frmXml.ShowDialog();
        }

        private void BtnJson_Click(object sender, EventArgs e)
        {
            FrmJson frmJson = new FrmJson();
            frmJson.ShowDialog();
        }
    }
}
