﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garantiTakip
{
    public partial class FrmAra : Form
    {
        stajyerEntities3 db = new stajyerEntities3();
        AnasayfaFrm Form;
        public FrmAra(AnasayfaFrm frm)
        {
            InitializeComponent();
            Form = frm;
        }
       
        private void btnAra_Click(object sender, EventArgs e)
        {
           
            if (txtFirmaNo.Text !="" )
            {
               int firmano = Convert.ToInt32(txtFirmaNo.Text);

                tbl_cari CCari = db.tbl_cari.Find(firmano);


                Form.GetirId(CCari, firmano);
            }
             if(txtFirmaAdi.Text!="")
            {
                String firmaAdi = txtFirmaAdi.Text;

                tbl_cari CCari = db.tbl_cari.Where(x=>x.FIRMAADI==firmaAdi).FirstOrDefault();


                Form.GetirFirmaAdi(CCari,firmaAdi);
            }
             if (txtYetkiliAdSoyad.Text !="")
            {
                String yetkiliAdSoyad = txtYetkiliAdSoyad.Text;

                tbl_cari CCari = db.tbl_cari.Where(x => (x.tbl_Yetkili.AD+" "+x.tbl_Yetkili.SOYAD)==yetkiliAdSoyad).FirstOrDefault();


                Form.GetirlYetkiliAdSoyad(CCari, yetkiliAdSoyad);
            }

            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

     

        private void FrmAra_Load(object sender, EventArgs e)
        {
            txtFirmaAdi.Focus();
        }

        private void txtFirmaNo_Enter(object sender, EventArgs e)
        {
            txtFirmaAdi.Clear();
            txtYetkiliAdSoyad.Clear();
        }

        private void txtFirmaAdi_Enter(object sender, EventArgs e)
        {
            txtFirmaNo.Clear();
            txtYetkiliAdSoyad.Clear();
        }

        private void txtYetkiliAdSoyad_Enter(object sender, EventArgs e)
        {
            txtFirmaNo.Clear();
            txtFirmaAdi.Clear();
        }


    }
}
