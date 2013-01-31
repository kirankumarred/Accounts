using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kiran.Accountportal.Common;
using Kiran.Accountportal.DTO;

namespace Kiran.Accountportal.UI
{
    public partial class Login : Form
    {
        private AuthorizationDTO authDTO;
        public AuthorizationDTO AuthDTO { get { return authDTO; } }
        public Login()
        {
            InitializeComponent();
        }

        private void ubtnLogin_Click(object sender, EventArgs e)
        {
            authDTO = new AuthorizationDTO("admin");
            Exception ex = authDTO.SystemException;
            if (utxtPassword.Text == "Password")
            {

            }
            if (authDTO.ErrorCode != ErrorCodes.NO_ERROR)
            {
            }
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
