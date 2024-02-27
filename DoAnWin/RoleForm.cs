using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin
{
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void btnFreelan_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();    
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
