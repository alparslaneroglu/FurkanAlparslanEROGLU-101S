using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanAlparslanEROGLU_101S
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        #region PanelIslemleri
        void Paneller()
        {
            gbSag.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl8.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gbSag.Text = button1.Text;
            Paneller();
            pnl2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSag.Text = button2.Text;
            Paneller();
            pnl3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbSag.Text = button3.Text;
            Paneller();
            pnl4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbSag.Text = button4.Text;
            Paneller();
            pnl5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gbSag.Text = button5.Text;
            Paneller();
            pnl6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gbSag.Text = button6.Text;
            Paneller();
            pnl7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gbSag.Text = button7.Text;
            Paneller();
            pnl8.Visible = true;
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        #endregion
    }
}
