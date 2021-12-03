using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Верфь
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Auth auth = new Auth();
            this.Hide();
            auth.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            this.Hide();
            auth.Show();
        }
        private void userButton_Click(object sender, EventArgs e)
        {
            UsersForm user = new UsersForm();
            this.Hide();
            user.Show();
        }
        private void manufactureButton_Click(object sender, EventArgs e)
        {
            Manufacture manuf = new Manufacture();
            this.Hide();
            manuf.Show();
        }
        private void priceButton_Click(object sender, EventArgs e)
        {
            Prices price = new Prices();
            this.Hide();
            price.Show();
        }
    }
}
