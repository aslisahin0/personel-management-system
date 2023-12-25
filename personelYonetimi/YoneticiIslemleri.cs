using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelYonetimi
{
    public partial class YoneticiIslemleri : Form
    {
        
        testdbEntities db = new testdbEntities();
        static int secilen_id = 0;
        

        public YoneticiIslemleri()
        {
            InitializeComponent();
        }



        private void YoneticiIslemleri_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            YoneticiDoldur();
            

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.Columns["mngr_id"].Visible = false;
            

            dataGridView1.Columns["first_name"].HeaderText = "Adı";
            dataGridView1.Columns["last_name"].HeaderText = "Soyadı";  
            dataGridView1.Columns["salary"].HeaderText = "Maaşı";
            dataGridView1.Columns["gender"].HeaderText = "Cinsiyeti";
            dataGridView1.Columns["age"].HeaderText = "Yaşı";
            
        }

        //private void ComboTakimDoldur(int dept_id)
        //{
        //    var takimlar = db.ViewTeams.Where(a => a.dept_id == dept_id).ToList();

        //  comboBoxTakim.DataSource = takimlar;
        //  comboBoxTakim.ValueMember = "team_id";
        //  comboBoxTakim.DisplayMember = "team_name";

        //}

        private void ComboDoldur()
        {

            var departmanlar = db.DEPARTMENT.ToList();
            comboBoxDept.DataSource = departmanlar;
            comboBoxDept.ValueMember = "dept_id";
            comboBoxDept.DisplayMember = "dept_name";

        }

        private void YoneticiDoldur()
        {
            var yonetici = db.ViewManagers.ToList();
            dataGridView1.DataSource = yonetici;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MANAGERS temp = new MANAGERS();
            temp.first_name = txtAd.Text.Trim();
            temp.last_name = txtSoyad.Text.Trim();
            temp.gender = txtGender.Text.Trim();
            temp.dept_id = Convert.ToInt32(comboBoxDept.SelectedValue.ToString());
            temp.age = Convert.ToInt32(txtAge.Text.Trim());
            temp.salary= Convert.ToInt32(txtMaas.Text.Trim());
            txtAd.Text = txtAge.Text = txtGender.Text = txtMaas.Text = txtSoyad.Text = "";

            db.MANAGERS.Add(temp);
            db.SaveChanges();
            YoneticiDoldur();

        }

        private void btnDepİslemler_Click(object sender, EventArgs e)
        {
            DeptIslemleri formDept = new DeptIslemleri();
            formDept.Show();
            this.Hide();
        }

        private void btnPrsnlIslemler_Click(object sender, EventArgs e)
        {
            PersonelIslemleri formPrsnl = new PersonelIslemleri();
            formPrsnl.Show();
            this.Hide();
        }

        private void BtnTkmIslemleri_Click(object sender, EventArgs e)
        {
            TakimIslemleri formTakim = new TakimIslemleri();
            formTakim.Show();
            this.Hide();
        }

        private void btnMngrIslemleri_Click(object sender, EventArgs e)
        {
            YoneticiIslemleri formMngr = new YoneticiIslemleri();
            formMngr.Show();
            this.Hide();
        }


        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtMaas.Text = row.Cells["salary"].Value.ToString();
                txtAd.Text = row.Cells["first_name"].Value.ToString();
                txtSoyad.Text = row.Cells["last_name"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
                txtGender.Text = row.Cells["gender"].Value.ToString();
                secilen_id = Convert.ToInt32(row.Cells["mngr_id"].Value.ToString().Trim());
                
                var temp = db.MANAGERS.Where(a => a.mngr_id == secilen_id).FirstOrDefault();
                //var temp2 = db.TEAMS.Where(a => a.team_id == temp.team_id).FirstOrDefault();
                //ComboTakimDoldur(temp2.dept_id);

                comboBoxDept.SelectedValue = temp.dept_id;
                
            }

        }

        private void btnMngrSil_Click(object sender, EventArgs e)
        {
            if (secilen_id > 0)
            {
              MANAGERS temp = db.MANAGERS.Where(a => a.mngr_id == secilen_id).FirstOrDefault();
                txtAd.Text = txtAge.Text = txtGender.Text = txtMaas.Text = txtSoyad.Text = "";

                db.MANAGERS.Remove(temp);
                db.SaveChanges();
                YoneticiDoldur();
            }
           
        }

        private void btnMngrGuncelle_Click(object sender, EventArgs e)
        {
            MANAGERS temp = db.MANAGERS.Where(a => a.mngr_id == secilen_id).FirstOrDefault();
            temp.first_name = txtAd.Text.Trim();
            temp.last_name = txtSoyad.Text.Trim();
            temp.gender = txtGender.Text.Trim();
            temp.age = Convert.ToInt32(txtAge.Text.Trim());
            temp.salary = Convert.ToInt32(txtMaas.Text.Trim());
            //temp.dept_id = Convert.ToInt32(comboBoxDept.SelectedValue.ToString());
            txtAd.Text = txtAge.Text = txtGender.Text = txtMaas.Text = txtSoyad.Text = "";

            ComboDoldur();
            YoneticiDoldur();
            db.SaveChanges();
           
        }

   

        //private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //      {
        //            try
        //            {
        //               int department_id = Convert.ToInt32(comboBoxDept.SelectedValue.ToString());

        //            //if (department_id != null)
        //            //{
        //            //    ComboTakimDoldur(department_id);
        //            //}
        //        }
        //        catch (Exception)
        //            {


        //            }

        //        }

        //}
    }
    }

