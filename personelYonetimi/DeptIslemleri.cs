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
    public partial class DeptIslemleri : Form
    {
        testdbEntities db = new testdbEntities();
        static int secilen_id=0;
        public DeptIslemleri()
        {
            InitializeComponent();
        }
              



        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testdbDataSet1.DEPARTMENT' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dEPARTMENTTableAdapter.Fill(this.testdbDataSet1.DEPARTMENT);
            DepartmanDoldur();
            dataGridPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPersonel.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridPersonel.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridPersonel.Columns["dept_name"].HeaderText = "Departman Adı";

            this.dataGridPersonel.Columns["dept_id"].Visible = false;
            this.dataGridPersonel.Columns["TEAMS"].Visible = false;
          

        }



        private void DepartmanDoldur()
        {
            var departmanlar = db.DEPARTMENT.ToList();
           
            dataGridPersonel.DataSource = departmanlar;

        }
       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DEPARTMENT temp = new DEPARTMENT();
            temp.dept_name = txtDeptName.Text.Trim();
            txtDeptName.Text= " ";

            
            db.DEPARTMENT.Add(temp);
            db.SaveChanges();
            DepartmanDoldur();

        }

        private void btnDeptGuncelle_Click(object sender, EventArgs e)
        {
            DEPARTMENT temp = db.DEPARTMENT.Where(a => a.dept_id == secilen_id).FirstOrDefault();
            temp.dept_name = txtDeptName.Text.Trim();
            db.SaveChanges();
            DepartmanDoldur();
            txtDeptName.Text = "";


        }
        
        private void btnDeptSil_Click(object sender, EventArgs e)
        {
            if (secilen_id>0)
            {
                DEPARTMENT temp = db.DEPARTMENT.Where(a => a.dept_id == secilen_id ).FirstOrDefault();
                db.DEPARTMENT.Remove(temp);
                txtDeptName.Text = "";
                db.SaveChanges();
                DepartmanDoldur();
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

       

      
        

        private void dataGridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridPersonel.Rows[e.RowIndex];
                txtDeptName.Text = row.Cells["dept_name"].Value.ToString();
                secilen_id=Convert.ToInt32(row.Cells["dept_id"].Value.ToString().Trim());
            }

            DataGridViewColumn column = this.dataGridPersonel.Columns[e.ColumnIndex];
            dataGridPersonel.Columns["dept_name"].HeaderText = "Departman Adı";
           
        }
    }
}

