﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dictionary_user
{
    public partial class Idiom : Form
    {
        
        private bool ktSwitch = false;
        
        public Idiom()
        {
            InitializeComponent();
          
        }
       
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (ktSwitch == true)
            {
                ktSwitch = false;
                pictureBoxFlagLeft.Image = Properties.Resources.vietnam;
                pictureBoxFlagRight.Image = Properties.Resources.united_kingdom;
                labelLanguage.Text = "Vietnamese Idiom";
            }
            else
            {
                ktSwitch = true;
                pictureBoxFlagLeft.Image = Properties.Resources.united_kingdom;
                pictureBoxFlagRight.Image = Properties.Resources.vietnam;
                labelLanguage.Text = "English Idiom";
            }
        }
        private void panelSuggestion_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            iconBookmark.Visible = true;
            textBoxResult.Visible = true;
            textBoxMeaning.Visible = true;
            pictureBoxSearched.Visible = true;
            pictureBoxMeaning.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textboxSearch.Text = textBox1.Text;
        }

        private void textboxSearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox2.Text;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox3.Text;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = textBox4.Text;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox6.Text;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox7.Text;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox8.Text;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textboxBookmark.Text = textBox9.Text;
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox11.Text;
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox12.Text;
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox13.Text;
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox14.Text;
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox15.Text;
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            textboxHistory.Text = textBox16.Text;
        }
    }
}
