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
    public partial class FrmSektor : Form
    {
        public FrmSektor()
        {
            InitializeComponent();
        }

        stajyerEntities3 db = new stajyerEntities3();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Listele()
        {
            dataGridView1.DataSource = db.tbl_sektor.Select(x => new { x.IND, x.FIRMANO, x.SEKTORADI }).ToList();
        }
        private void FrmSektor_Load(object sender, EventArgs e)
        {


            Listele();
            foreach (var item in db.tbl_sektor)
            {
                comboBox1.Items.Add(item.SEKTORADI);

            }


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tbl_sektor sektor = new tbl_sektor();
            sektor.SEKTORADI = comboBox1.Text;
            db.tbl_sektor.Add(sektor);
            db.SaveChanges();
            MessageBox.Show("Sektör Eklenmiştir");
            FrmSektor_Load(sender, e);
            




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1 != null)
                {
                    int a = int.Parse(textBox2.Text);
                    var sektoradi = db.tbl_sektor.Where(w => w.IND == a).FirstOrDefault();
                    db.tbl_sektor.Remove(sektoradi);
                    db.SaveChanges();
                    FrmSektor_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
            catch 
            {

                MessageBox.Show("Kullanıcı Bulunamadı");
            }
            
        }

       

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

           
            
                int a = int.Parse(textBox2.Text);
                
                    tbl_sektor guncelle = db.tbl_sektor.Where(x => x.IND == a).FirstOrDefault();
                    
                    
                    



                if (comboBox1.Text == "")

                {
                    MessageBox.Show("Sektör Adını boş geçmeyin");
                    return;
                }
                else
                {
                    guncelle.SEKTORADI = comboBox1.Text;
                   
                }
                db.SaveChanges();

                Listele();


           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox2.Text = (dataGridView1.CurrentRow.Cells[0].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            comboBox1.Text = (dataGridView1.CurrentRow.Cells[2].Value == null) ? "" : (dataGridView1.CurrentRow.Cells[2].Value.ToString());
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Clear();
            txtArama.Clear();
        }

       
        

        private void txtArama_KeyUp(object sender, KeyEventArgs e)

        {
            if (e.KeyCode==Keys.Enter)
            {
                dataGridView1.DataSource = db.tbl_sektor.Where(x => x.SEKTORADI.Contains(txtArama.Text)).ToList();
            }
            
        }
    }
    }

