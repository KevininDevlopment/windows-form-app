﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listCity.GetItemText(listCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = textName.Text;
            String address = textAddress.Text;
            MessageBox.Show(name + address);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
