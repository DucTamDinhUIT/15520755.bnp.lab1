/*************************************
//	Basic Network Programing Lab1.1
//	Form1.cs
//	Purpose: Find Max min of 3 operators.
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

namespace bt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1Text = textBox1.Text;
            string s2Text = textBox2.Text;
            string s3Text = textBox3.Text;

            int s1Int = int.Parse(s1Text);
            int s2Int = int.Parse(s2Text);
            int s3Int = int.Parse(s3Text);

            long maxLong = 0;
            long minLong = 0;

            if (s1Int >= s2Int)
            {
                if (s2Int >= s3Int)
                {
                    maxLong = s1Int;
                    minLong = s3Int;
                }
                else
                {
                    if (s1Int >= s3Int)
                    {
                        maxLong = s1Int;
                        minLong = s2Int;
                    }
                    else
                    {
                        maxLong = s3Int;
                        minLong = s2Int;
                    }
                }
            }
            else
            {
                if (s2Int <= s3Int)
                {
                    maxLong = s3Int;
                    minLong = s1Int;
                }
                else
                {
                    if (s1Int >= s3Int)
                    {
                        maxLong = s2Int;
                        minLong = s3Int;
                    }
                    else
                    {
                        maxLong = s2Int;
                        minLong = s1Int;
                    }
                }

            };

            textBox4.Text = maxLong.ToString();
            textBox5.Text = minLong.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Exit?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }


    }
}
