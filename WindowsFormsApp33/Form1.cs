using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        Student model = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void Tozalash()
        {
            txtFirstName.Text = txtLastName.Text = txtCity.Text = txtAddress.Text = txtTelifonraqam.Text = "";
            btnQoshish.Text = "Qo'shish";
            btnOchirish.Enabled = false;
            model.id = 0;

        }

        private void btnTozalash_Click(object sender, EventArgs e)
        {
            Tozalash();
            dgvChiqarish();
        
        }

        private void btnQoshish_Click(object sender, EventArgs e)
        {
            model.FirstName = txtFirstName.Text.Trim();
            model.LastName = txtLastName.Text.Trim();
            model.City = txtCity.Text.Trim();
            //model.Address = txtAddress.Text.Trim();
            model.Telifon_raqam = txtTelifonraqam.Text.Trim();
            using (MalumotEntities db=new MalumotEntities ())
            {
                if (model.id == 0)
                    db.Students.Add(model);
                else
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Tozalash();
            dgvChiqarish();
                MessageBox.Show("Malumotlar bazaga qo'shildi!");
        }
        void dgvChiqarish()
        {
            dgvStudent.AutoGenerateColumns = false;
            using (MalumotEntities db=new MalumotEntities ())
            {
                dgvStudent.DataSource = db.Students.ToList<Student>();
            }
        }



        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tozalash();
            dgvChiqarish();
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if(dgvStudent.CurrentRow.Index!=-1)
            {
                model.id = Convert.ToInt32(dgvStudent.CurrentRow.Cells["id"].Value);
            using (MalumotEntities db=new MalumotEntities ())
                {
                    model = db.Students.Where(x => x.id == model.id).FirstOrDefault();
                    txtFirstName.Text = model.FirstName;
                    txtLastName.Text = model.LastName;
                    txtCity.Text = model.City;
                    txtTelifonraqam.Text = model.Telifon_raqam; 
                }
                btnQoshish.Text = "Taxrirlash";
                btnOchirish.Enabled = true;
            }
        }

        private void btnOchirish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Malumot bazadan o'chirilsinmi", "O'chirish holati", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MalumotEntities db = new MalumotEntities())
                {
                    var ert = db.Entry(model);
                    if (ert.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Students.Attach(model);
                        db.Students.Remove(model);
                        db.SaveChanges();
                        dgvChiqarish();
                        Tozalash();
                        MessageBox.Show("Malumot o'chirildi!");
                    }
                }
            }
            else
                MessageBox.Show("Malumot o'chirilmadi!");
        }

        private void btnIzlash_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = txtIzlash.Text;
            List<Student> students = new List<Student>();
            using(MalumotEntities db=new MalumotEntities ())
            {
                students = db.Students.Where(x => x.FirstName == txtFirstName.Text).ToList();
            }
            dgvStudent.DataSource = students;
        }
    }
}
