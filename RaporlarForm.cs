using System;
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
    public partial class RaporlarForm : Form
    {
        public RaporlarForm()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();

        public void Listele()
        {
            dataGridView1.DataSource = db.tbl_cari.Select(x => new
            {
                x.IND,
                x.FIRMAKODU,
                x.FIRMAADI,
                x.YETKILI,
                x.VERGIDAIRESI,
                x.VERGINO,
                x.KAYITTARIHI,
                x.ISKONTO,
                x.tbl_firmaTipi.FIRMATİPİ,
                x.tbl_Yetkili.AD,
                x.tbl_Yetkili.SOYAD,
                x.UNVAN,
                x.tbl_sektor.SEKTORADI,
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.tbl_personel.PERSONELAD,
                x.tbl_yorum.YORUM,
                x.PERSONELNO,
               
                x.tbl_status.STATUS,

                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).ToList();

        }
        public void Ara()
        {
            string ad = txtCariAra.Text;

            dataGridView1.DataSource = db.tbl_cari.Select(x => new
            {
                x.IND,
                x.FIRMAKODU,
                x.FIRMAADI,
                x.YETKILI,
                x.VERGIDAIRESI,
                x.VERGINO,
                x.KAYITTARIHI,
                x.ISKONTO,
                x.tbl_firmaTipi.FIRMATİPİ,
                x.tbl_Yetkili.AD,
                x.tbl_Yetkili.SOYAD,
                x.UNVAN,
                x.tbl_sektor.SEKTORADI,
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.PERSONELNO,
                x.tbl_status.STATUS,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH
            }).Where(x => x.FIRMAADI.Contains(ad)).ToList();
        }
        private void RaporlarForm_Load(object sender, EventArgs e)
        {


            Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ara();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbl_cari cari = new tbl_cari();
            int id = Convert.ToInt16(txtSil.Text);
            cari = db.tbl_cari.Find(id);

            if (cari != null)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Cari Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.tbl_cari.Remove(cari);
                    db.SaveChanges();
                    RaporlarForm_Load(sender, e);
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("İd Bulunamadı");
            }
        }

        private void txtCariAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ara();
            }
        }

       
    }
}
