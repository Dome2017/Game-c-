using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Shop : Form
    {
        private Postac postac;
        private Form2 form2;
        public Shop(Postac postac, Form2 form2)
        {
            InitializeComponent();
            this.postac = postac;
            this.form2 = form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ukryj Shop i pokaż Form2 (menu) po zamknięciu
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            form2.Show(); // Pokaż Form2 po zamknięciu Shop
        }
    }
}
