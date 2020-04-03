/*************************************
//	Basic Network Programing Lab1.2
//	Form1.cs
//	Purpose: Spell one Number.
//
//	@author 15520755@gm.uit.edu.vn
**************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Exit?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string s1Text = textBox1.Text;

            int s1Int = int.Parse(s1Text);
            string s2Int;

            switch (s1Int)
            {
                case 1:
                    s2Int = "Một";
                    break;
                case 2:
                    s2Int = "Hai";
                    break;
                case 3:
                    s2Int = "Ba";
                    break;
                case 4:
                    s2Int = "Bốn";
                    break;
                case 5:
                    s2Int = "Năm";
                    break;
                case 6:
                    s2Int = "Sáu";
                    break;
                case 7:
                    s2Int = "Bảy";
                    break;
                case 8:
                    s2Int = "Tám";
                    break;
                case 9:
                    s2Int = "Chín";
                    break;
                default:
                    s2Int = "Không";
                    break;
            }

            textBox2.Text = s2Int.ToString();
        }
    }
}
