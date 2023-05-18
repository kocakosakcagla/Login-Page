using loginOOP.Classes.Model;
using loginOOP.Classes.Structure.Concrete;
using loginOOP.Classes.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginOOP
{
    public partial class Form1 : Form
    {
        IAction action;

        public Form1()
        {
            InitializeComponent();
            action = new Actions();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            action.Login(txtKullaniciAdi.Text, txtSifre.Text);
        }

        private void linklbl_HesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_hesapOlustur form2 = new frm_hesapOlustur();

            form2.ShowDialog();

        }
    }
}
