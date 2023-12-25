using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace personelYonetimi
{
    public partial class PersonelIslemleri : Form
    {

        testdbEntities db = new testdbEntities();

        static int secilen_id = 0;
        

        public PersonelIslemleri()
        {
            InitializeComponent();
        }


        private void Form7_Load(object sender, EventArgs e)
        {
            
            PersonelDoldur();
            ComboDoldur();
            

            dataGridPersonelIslemleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPersonelIslemleri.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridPersonelIslemleri.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridPersonelIslemleri.Columns["employee_id"].Visible = false;
            this.dataGridPersonelIslemleri.Columns["dept_id"].Visible = false;
            this.dataGridPersonelIslemleri.Columns["team_id"].Visible = false;
            


            dataGridPersonelIslemleri.Columns["team_name"].HeaderText = "Takımı";
            dataGridPersonelIslemleri.Columns["dept_name"].HeaderText= "Departmanı";
            dataGridPersonelIslemleri.Columns["salary"].HeaderText = "Maaş";
            dataGridPersonelIslemleri.Columns["first_name"].HeaderText = "Adı";
            dataGridPersonelIslemleri.Columns["last_name"].HeaderText = "Soyadı";
            dataGridPersonelIslemleri.Columns["gender"].HeaderText = "Cinsiyeti";
            dataGridPersonelIslemleri.Columns["age"].HeaderText = "Yaşı";

        }

        private void TakimDoldur(int dept_id)
        {

            var takimlar = db.ViewTeams.Where(a=>a.dept_id==dept_id).ToList();
            comboBoxTakim.DataSource = takimlar;
            comboBoxTakim.ValueMember = "team_id";
            comboBoxTakim.DisplayMember = "team_name";

        }

        //private void TakimDoldur(int selected_id)
        //{
        //    var takimlar = db.ViewTeams.Where(a => a.dept_id == selected_id).ToList();
        //    comboBoxTakim.DataSource = takimlar;
        //    comboBoxTakim.DisplayMember = "team_name";
        //    comboBoxTakim.ValueMember = "team_id";
        //}

        private void ComboDoldur()
        {
            var departmanlar = db.DEPARTMENT.ToList();
            comboBoxDept.DataSource = departmanlar;
            comboBoxDept.DisplayMember = "dept_name";
            comboBoxDept.ValueMember = "dept_id";
        }


        private void PersonelDoldur()
        {
            var personel = db.ViewEmployees.ToList();
            dataGridPersonelIslemleri.DataSource = personel;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            EMPLOYEES temp = new EMPLOYEES();

            temp.first_name = txtAd.Text.Trim();
            temp.last_name = txtSoyad.Text.Trim();
            temp.gender = txtGender.Text.Trim();
            temp.team_id = Convert.ToInt32(comboBoxTakim.SelectedValue.ToString());
            temp.age = Convert.ToInt32(txtAge.Text.Trim());
            temp.salary = Convert.ToInt32(txtMaas.Text.Trim());

            txtAd.Text = txtAge.Text = txtGender.Text = txtMaas.Text = txtSoyad.Text = "";

            db.EMPLOYEES.Add(temp);
            db.SaveChanges();
            PersonelDoldur();

        }


        private void btnDepİslemler_Click(object sender, EventArgs e)
        {

            {
                DeptIslemleri formDept = new DeptIslemleri();
                formDept.Show();
                this.Hide();

            }
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

       



       

        private void dataGridPersonelIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridPersonelIslemleri.Rows[e.RowIndex];

                txtMaas.Text = row.Cells["salary"].Value.ToString();
                txtAd.Text = row.Cells["first_name"].Value.ToString();
                txtSoyad.Text = row.Cells["last_name"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
                txtGender.Text = row.Cells["gender"].Value.ToString();
                secilen_id = Convert.ToInt32(row.Cells["employee_id"].Value.ToString().Trim());
                

                var temp = db.EMPLOYEES.Where(a => a.employee_id == secilen_id).FirstOrDefault();
                var temp2 = db.TEAMS.Where(a => a.team_id == temp.team_id).FirstOrDefault();
                TakimDoldur(temp2.dept_id);
                comboBoxDept.SelectedValue = temp2.dept_id;
              


            }
        }
        

        private void btnPrsnlSil_Click(object sender, EventArgs e)
        {
            if (secilen_id > 0)
            {
                EMPLOYEES temp = db.EMPLOYEES.Where(a => a.employee_id == secilen_id).FirstOrDefault();
               
                txtAd.Text = txtAge.Text = txtGender.Text = txtMaas.Text = txtSoyad.Text = "";

                db.EMPLOYEES.Remove(temp);
                db.SaveChanges();
                PersonelDoldur();
            }
        }


        private void btnPrsnlGuncelle_Click(object sender, EventArgs e)
        {
            EMPLOYEES temp = db.EMPLOYEES.Where(a => a.employee_id == secilen_id).FirstOrDefault();

            temp.first_name = txtAd.Text.Trim();
            temp.last_name = txtSoyad.Text.Trim();
            temp.gender = txtGender.Text.Trim();
            temp.age = Convert.ToInt32(txtAge.Text.Trim());
            temp.salary = Convert.ToInt32(txtMaas.Text.Trim());
            temp.team_id = Convert.ToInt32(comboBoxTakim.SelectedValue.ToString());

            txtAd.Text = txtAge.Text = txtGender.Text = txtMaas.Text = txtSoyad.Text = "";

            db.SaveChanges();
            PersonelDoldur();
        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
            try
            {
                int department_id = Convert.ToInt32(comboBoxDept.SelectedValue.ToString());
                if (department_id!=null)
                {
                    TakimDoldur(department_id);
                }
               
            } 
            catch (Exception)
            {


            }
        }

       
    }
}




