﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bar.io
{
    public partial class VnesiLozinkaKelner : Form
    {
        public VnesiLozinkaKelner()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.ForeColor = SystemColors.InfoText;
            tbPassword.PasswordChar = '*';
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}