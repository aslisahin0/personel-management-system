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
    public partial class TakimIslemleri : Form
    {
        testdbEntities db = new testdbEntities();
        static int secilen_id = 0;
      

        public TakimIslemleri()
        {
            InitializeComponent();
        }

        private void TakimKayit_Load(object sender, EventArgs e)
        {
            TakimDoldur();
            ComboDoldur();
           

            dataGridTakim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTakim.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridTakim.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridTakim.Columns["team_id"].Visible = false;
            this.dataGridTakim.Columns["dept_id"].Visible = false;

            dataGridTakim.Columns["dept_name"].HeaderText = "Departman Adı";
            dataGridTakim.Columns["team_name"].HeaderText = "Takım Adı";
        }

        private void ComboDoldur()
        {
            var departmanlar = db.viewDepartment.ToList();
          
            comboBox1.DataSource = departmanlar;
            comboBox1.DisplayMember = "dept_name";
            comboBox1.ValueMember = "dept_id";
           
        }

        private void TakimDoldur()
        {
            var takimlar = db.ViewTeams.ToList();
            dataGridTakim.DataSource = takimlar;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TEAMS temp = new TEAMS();
            temp.team_name = txtTeamName.Text.Trim();
            temp.dept_id = Convert.ToInt32(comboBox1.SelectedValue.ToString());

            txtTeamName.Text = "";

            db.TEAMS.Add(temp);
            db.SaveChanges();
            TakimDoldur();

        }


        private void btnTakimGuncelle_Click(object sender, EventArgs e)
        {
            TEAMS temp = db.TEAMS.Where(a => a.team_id == secilen_id).FirstOrDefault();
            temp.team_name = txtTeamName.Text.Trim();
            temp.dept_id = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            txtTeamName.Text = "";
            db.SaveChanges();
            TakimDoldur();

        }


        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            if (secilen_id > 0)
            {
                TEAMS temp = db.TEAMS.Where(a => a.team_id == secilen_id).FirstOrDefault();
                txtTeamName.Text = "";
                

                db.TEAMS.Remove(temp);
                db.SaveChanges();
                TakimDoldur();
            }
        }

        private void dataGridTakim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridTakim.Rows[e.RowIndex];
                txtTeamName.Text = row.Cells["team_name"].Value.ToString();
                secilen_id = Convert.ToInt32(row.Cells["team_id"].Value.ToString().Trim());

                var temp = db.TEAMS.Where(a => a.team_id == secilen_id).FirstOrDefault();
                comboBox1.SelectedValue = temp.dept_id;
            }

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


        
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    int selected_id = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                   
                   
                }
                catch (Exception)
                {


                }

            }


        }
    }
}

