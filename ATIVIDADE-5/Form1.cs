﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensalista_Click(object sender, EventArgs e)
        {
            frmMensalista ObjMensalista = new frmMensalista();
            ObjMensalista.Show();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            frmHorista ObjHorista = new frmHorista();
            ObjHorista.Show();
        }
    }
}
