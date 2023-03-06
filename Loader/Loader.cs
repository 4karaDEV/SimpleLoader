using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using KeyAuth;

namespace Loader
{
    public partial class Loader : Form
    {
        public static api KeyAuthApp = new api(
            name: "Exemple",
            ownerid: "",
            secret: "",
            version: "1.0"
        );

        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(KeyBox.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Keys");
        }

        private void GetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
