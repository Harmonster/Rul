using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rul
{
    public partial class Authorization : Form
    {
        //private int loginAttempts = 0;

        public Authorization()
        {
            InitializeComponent();

            BtnExit.BackColor = Resources.Misc.ColorAccent;
            PnlHeader.BackColor = Resources.Misc.ColorAdditional;
            PnlFooter.BackColor = Resources.Misc.ColorAdditional;

            CaptchaGenerator captcha = new CaptchaGenerator();
            captcha.Captcha(6, RtbCaptchaOutput);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TbCaptcha.Text == RtbCaptchaOutput.Text)
            {
                MessageBox.Show("ДА");
            }
            else
            {
                MessageBox.Show("НЕТ");
            }
        }
    }
}
