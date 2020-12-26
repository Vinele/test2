using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamNew.Views
{
    public partial class LoginForm : SForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string rawpass = textBox1.Text;
            var bytes = Encoding.UTF8.GetBytes(rawpass);
            var key = Encoding.UTF8.GetBytes("key");
            var h = new HMACSHA256(key);
            var hash = h.ComputeHash(bytes);

            textBox2.Text = Convert.ToBase64String(hash);
        }
    }
}
