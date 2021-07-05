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
    public partial class AnasayfaFrm : Form
    {
        stajyerEntities3 db = new stajyerEntities3();

        public AnasayfaFrm()
        {
            InitializeComponent();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            FrmAra frm = new FrmAra(this);
            frm.Show();
        }

        private void AnasayfaFrm_Load(object sender, EventArgs e)
        {

        }
        public void GetirId(tbl_cari cari, int firmano)
        {
            if (cari != null && firmano.ToString() != "")
            {

                cari = db.tbl_cari.Where(x => x.IND == firmano).FirstOrDefault();


                txtYetkili.Text = ((cari.tbl_Yetkili==null)?"Bilinmiyor": (cari.tbl_Yetkili.AD) )+ " " + ((cari.tbl_Yetkili==null)?"": (cari.tbl_Yetkili.SOYAD));


                txtFirmaAd.Text = cari.FIRMAADI;
                txtFirmaKod.Text = cari.FIRMAKODU;
                txtSektor.Text = (cari.tbl_sektor==null)?"Bilinmiyor":(cari.tbl_sektor.SEKTORADI);
                txtFirmaTip.Text = (cari.tbl_firmaTipi==null)?"Bilinmiyor":(cari.tbl_firmaTipi.FIRMATİPİ);
                if ((cari.tbl_status==null)?false: cari.tbl_status.STATUS == true)
                {
                    RbAktif.Checked = true;
                }
                else
                {
                    RbAktif.Checked = false;
                }
                if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == false)
                {
                    RbPasif.Checked = true;
                }
                else
                {
                    RbPasif.Checked = false;
                }
            
              
                txtSehir.Text = cari.SEHIR;
                txtTel.Text = cari.TELEFON1;
                txtTel2.Text = cari.TELEFON2;
                txtMail.Text = cari.EMAIL;
                txtUrl.Text = cari.URL;
                txtHizmetTuru.Text = (cari.tbl_hizmetturu == null) ? "Bilinmiyor" : (cari.tbl_hizmetturu.HIZMETTURU);
                 txtAdresFatura.Text = cari.ADRESFATURA;
                txtAdresSevk.Text = cari.ADRESSEVK;
                txtIskonto.Text = cari.ISKONTO.ToString();
                txtVergiDaire.Text = cari.VERGIDAIRESI;
                txtVergiNo.Text = cari.VERGINO;
                txtParaBirim.Text = cari.PARABIRIMI;
                txtBaslangıcTarih.Text = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
                txtBitisTarih.Text = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
                txtYetkiliAd.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
                txtYetkiliSoyad.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
                txtYetkiliTel.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.TELEFON));
                txtYetkiliMail.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.MAIL));
                txtYetkiliDgmTarih.Text = ((cari.tbl_Yetkili == null) ? DateTime.Now.ToString() : (cari.tbl_Yetkili.DGMTARİH.ToString()));
                txtKayitTarih.Text = cari.KAYITTARIHI.ToString();


            }

            else
            {
                MessageBox.Show("Kayıt Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetirFirmaAdi(tbl_cari cari, string firmaAdi)
        {
            if (cari != null && firmaAdi != "")
            {

                cari = db.tbl_cari.Where(x => x.FIRMAADI == firmaAdi).FirstOrDefault();


                txtYetkili.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD)) + " " + ((cari.tbl_Yetkili == null) ? "" : (cari.tbl_Yetkili.SOYAD));


                txtFirmaAd.Text = cari.FIRMAADI;
                txtFirmaKod.Text = cari.FIRMAKODU;
                txtSektor.Text = (cari.tbl_sektor == null) ? "Bilinmiyor" : (cari.tbl_sektor.SEKTORADI);
                txtFirmaTip.Text = (cari.tbl_firmaTipi == null) ? "Bilinmiyor" : (cari.tbl_firmaTipi.FIRMATİPİ);
                if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == true)
                {
                    RbAktif.Checked = true;
                }
                else
                {
                    RbAktif.Checked = false;
                }
                if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == false)
                {
                    RbPasif.Checked = true;
                }
                else
                {
                    RbPasif.Checked = false;
                }


                txtSehir.Text = cari.SEHIR;
                txtTel.Text = cari.TELEFON1;
                txtTel2.Text = cari.TELEFON2;
                txtMail.Text = cari.EMAIL;
                txtUrl.Text = cari.URL;
                txtHizmetTuru.Text = (cari.tbl_hizmetturu == null) ? "Bilinmiyor" : (cari.tbl_hizmetturu.HIZMETTURU);
                txtAdresFatura.Text = cari.ADRESFATURA;
                txtAdresSevk.Text = cari.ADRESSEVK;
                txtIskonto.Text = cari.ISKONTO.ToString();
                txtVergiDaire.Text = cari.VERGIDAIRESI;
                txtVergiNo.Text = cari.VERGINO;
                txtParaBirim.Text = cari.PARABIRIMI;
                txtBaslangıcTarih.Text = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
                txtBitisTarih.Text = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
                txtYetkiliAd.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
                txtYetkiliSoyad.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
                txtYetkiliTel.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.TELEFON));
                txtYetkiliMail.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.MAIL));
                txtYetkiliDgmTarih.Text = ((cari.tbl_Yetkili == null) ? DateTime.Now.ToString() : (cari.tbl_Yetkili.DGMTARİH.ToString()));
                txtKayitTarih.Text = cari.KAYITTARIHI.ToString();

              

            }

            else
            {
                MessageBox.Show("Kayıt Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public void GetirlYetkiliAdSoyad(tbl_cari cari, string YetkiliAdSoyad)
        {
            if (cari != null && YetkiliAdSoyad != "")
            {

                cari = db.tbl_cari.Where(x => (x.tbl_Yetkili.AD + " " + x.tbl_Yetkili.SOYAD) == YetkiliAdSoyad).FirstOrDefault();


                txtYetkili.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD)) + " " + ((cari.tbl_Yetkili == null) ? "" : (cari.tbl_Yetkili.SOYAD));


                txtFirmaAd.Text = cari.FIRMAADI;
                txtFirmaKod.Text = cari.FIRMAKODU;
                txtSektor.Text = (cari.tbl_sektor == null) ? "Bilinmiyor" : (cari.tbl_sektor.SEKTORADI);
                txtFirmaTip.Text = (cari.tbl_firmaTipi == null) ? "Bilinmiyor" : (cari.tbl_firmaTipi.FIRMATİPİ);
                if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == true)
                {
                    RbAktif.Checked = true;
                }
                else
                {
                    RbAktif.Checked = false;
                }
                if ((cari.tbl_status == null) ? false : cari.tbl_status.STATUS == false)
                {
                    RbPasif.Checked = true;
                }
                else
                {
                    RbPasif.Checked = false;
                }


                txtSehir.Text = cari.SEHIR;
                txtTel.Text = cari.TELEFON1;
                txtTel2.Text = cari.TELEFON2;
                txtMail.Text = cari.EMAIL;
                txtUrl.Text = cari.URL;
                txtHizmetTuru.Text = (cari.tbl_hizmetturu == null) ? "Bilinmiyor" : (cari.tbl_hizmetturu.HIZMETTURU);
                txtAdresFatura.Text = cari.ADRESFATURA;
                txtAdresSevk.Text = cari.ADRESSEVK;
                txtIskonto.Text = cari.ISKONTO.ToString();
                txtVergiDaire.Text = cari.VERGIDAIRESI;
                txtVergiNo.Text = cari.VERGINO;
                txtParaBirim.Text = cari.PARABIRIMI;
                txtBaslangıcTarih.Text = cari.tbl_baslangicBitisTarih.BASLANGICTARİH.ToString();
                txtBitisTarih.Text = cari.tbl_baslangicBitisTarih.BİTİSTARİH.ToString();
                txtYetkiliAd.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
                txtYetkiliSoyad.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.AD));
                txtYetkiliTel.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.TELEFON));
                txtYetkiliMail.Text = ((cari.tbl_Yetkili == null) ? "Bilinmiyor" : (cari.tbl_Yetkili.MAIL));
                txtYetkiliDgmTarih.Text = ((cari.tbl_Yetkili == null) ? DateTime.Now.ToString() : (cari.tbl_Yetkili.DGMTARİH.ToString()));
                txtKayitTarih.Text = cari.KAYITTARIHI.ToString();

                

            }

            else
            {
                MessageBox.Show("Kayıt Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTemizle_Click(object sender, EventArgs e)
        {
            txtYetkili.Clear();
            txtFirmaAd.Clear();
            txtSektor.Clear();
            txtFirmaKod.Clear();
            txtFirmaTip.Clear();
            txtSehir.Clear();
            txtTel.Clear();
            txtTel2.Clear();
            txtMail.Clear();
            txtUrl.Clear();
            txtHizmetTuru.Clear();
            txtAdresFatura.Clear();
            txtAdresSevk.Clear();
            txtIskonto.Clear();
            txtVergiDaire.Clear();
            txtVergiNo.Clear();
            txtParaBirim.Clear();
            txtYetkiliAd.Clear();
            txtYetkiliSoyad.Clear();
            txtYetkiliTel.Clear();
            txtYetkiliMail.Clear();
            txtBaslangıcTarih.Text = DateTime.Now.ToString();
            txtBitisTarih.Text = DateTime.Now.ToString();
            txtYetkiliDgmTarih.Text = DateTime.Now.ToString();
            txtKayitTarih.Text = DateTime.Now.ToString();

            RbAktif.Checked = false;
            RbPasif.Checked = false;
          
        }
    } 
}
