using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPMT
{
    public partial class MainForm : Form
    {
        private View.SecurityLookupForm securityLookupForm = new View.SecurityLookupForm();
        private View.AnotherForm anotherForm = new View.AnotherForm();

        public MainForm()
        {
            InitializeComponent();
            securityLookupForm.TopLevel = false;
            securityLookupForm.Dock = DockStyle.Fill;
            this.pnlCurrentForm.Controls.Clear();
            this.pnlCurrentForm.Controls.Add(securityLookupForm);
            securityLookupForm.Show();
        }

        private void btnSecurityLookup_Click(object sender, EventArgs e)
        {
            securityLookupForm.TopLevel = false;
            securityLookupForm.Dock = DockStyle.Fill;
            this.pnlCurrentForm.Controls.Clear();
            this.pnlCurrentForm.Controls.Add(securityLookupForm);
            securityLookupForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anotherForm.TopLevel = false;
            anotherForm.Dock = DockStyle.Fill;
            this.pnlCurrentForm.Controls.Clear();
            this.pnlCurrentForm.Controls.Add(anotherForm);
            anotherForm.Show();
        }
    }
}
