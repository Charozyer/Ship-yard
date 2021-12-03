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
    public partial class Manufacture : Form
    {
        Model1 db = new Model1();
        public Manufacture()
        {
            InitializeComponent();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
        private void Manufacture_Load(object sender, EventArgs e)
        {
            boatsBindingSource.DataSource = db.Boats.ToList();
        }

        private void Manufacture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
