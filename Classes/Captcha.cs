using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Rul
{
    public class CaptchaGenerator
    {
        private int length { get; set; }

        public CaptchaGenerator()
        {
            this.length = length;
        }

        public void Captcha(int length, RichTextBox RtbCaptchaOutput)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            RtbCaptchaOutput.Clear();

            switch (randomNumber)
            {
                case 1:
                    RtbCaptchaOutput.SelectionFont = new System.Drawing.Font("Comic Sans MS", 8, System.Drawing.FontStyle.Strikeout);
                    RtbCaptchaOutput.SelectedText = GenerateCaptcha(6);
                    break;
                case 2:
                    RtbCaptchaOutput.SelectionFont = new System.Drawing.Font("Comic Sans MS", 8, System.Drawing.FontStyle.Strikeout);
                    RtbCaptchaOutput.SelectedText = GenerateCaptcha(6);
                    break;
                case 3:
                    RtbCaptchaOutput.SelectionFont = new System.Drawing.Font("Comic Sans MS", 8, System.Drawing.FontStyle.Strikeout);
                    RtbCaptchaOutput.SelectedText = GenerateCaptcha(6);
                    break;
            }

        }

        private string GenerateCaptcha(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var captcha = new char[length];

            for (var i = 0; i < length; i++)
            {
                captcha[i] = chars[random.Next(chars.Length)];
            }

            return new string(captcha);
        }

    }
}
