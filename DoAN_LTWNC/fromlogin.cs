﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_LTWNC
{
    public partial class fromlogin : Form
    {
        public fromlogin()
        {
            InitializeComponent();
        }

        private void Fromlogin_Load(object sender, EventArgs e)
        {
               
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        fromMain from = new fromMain();
        private void user_pass1_Click(object sender, EventArgs e)
        {
            if (user_pass1.h == 1)
            {
                MessageBox.Show("");
                from.Show();
            }
        }
    }
}
