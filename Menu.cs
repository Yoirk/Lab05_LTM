using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            bai01.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            bai02.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();  
            bai03.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai04 bai04 = new Bai04();
            bai04.Show();
        }
    }
}
