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
    public partial class frm_hesapOlustur : Form
    {
        IHesapOlustur hesapOlustur;
        public frm_hesapOlustur()
        {
            InitializeComponent();
            hesapOlustur = new HesapOlustur();
        }

        private void btn_hesapOlustur_Click(object sender, EventArgs e)
        {
            hesapOlustur.KaydetClick(txtBox_kullaniciAdiOlustur.Text, txtBox_sifreOlustur.Text, txtBox_sifreTekrar.Text);
        }
    }
}
