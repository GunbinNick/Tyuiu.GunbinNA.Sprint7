using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GunbinNA.Sprint7.Project.V13
{
    public partial class FormHelp : Form
    {
        bool but = false;
        public FormHelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (but)
            {
                this.Close();

            }
            else
            {
                button1.Text = "Закрывайте на свой страх и риск";
            }
            but = !but;
        }
    }
}
