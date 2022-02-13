using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            desing();
            panelSearching.Visible = false;
        }
        PersonelEntities personel = new PersonelEntities();
         
        private void desing()
        {
            panelPersonelSub.Visible = false;
            panelProcedure.Visible = false;
            panelInfo.Visible = true;
        }
        private void hide()
        {
            if (panelPersonelSub.Visible == true)
            {
                panelPersonelSub.Visible = false;
            }
            if (panelProcedure.Visible == true)
            {
                panelProcedure.Visible = false;
            }

        }
        private void showMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hide();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            showMenus(panelPersonelSub);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hide();
            listDoctors();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hide();
            listAsistans();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hide();
            listNurses();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hide();
            listCleaninh_Staff();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            showMenus(panelProcedure);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hide();
            panelSearching.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void listDoctors()
        {
            var query = from item in personel.Doctors
                        join item1 in personel.Salaries
                        on item.salary_id equals item1.id
                        select new
                        {
                            item.name,
                            item.surname,
                            item.isSentry,
                            item1.salary1
                        };
            dataGridView2.DataSource = query.ToList();
        }

        private void listAsistans()
        {
            var query = from item in personel.Asistans
                        select new { item.name, item.surname, item.salary, item.isSentry };
            dataGridView2.DataSource = query.ToList();
        }
        private void listCleaninh_Staff()
        {
            var query = from item in personel.Cleaning_Staff
                        join item1 in personel.Salaries
                        on item.salary_id equals item1.id
                        join item2 in personel.Shifts
                        on item.shift_id equals item2.id
                        select new

                        {
                            item.name,
                            item.surname,
                            item1.salary1,
                            item2.type
                        };
            dataGridView2.DataSource = query.ToList();
        }
        private void listNurses()
        {
            var query = from item in personel.Nurses
                        join item1 in personel.Salaries

                        on item.salary_id equals item1.id
                        select new
                        {
                            item.name,
                            item.surname,
                            item1.salary1
                        };
            dataGridView2.DataSource = query.ToList();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView2.Visible = false;
                search_Doctors();
                dataGridView2.Visible = true;
            }
            else if (radioButton2.Checked == true)
            {
                dataGridView2.Visible = false;
                search_Asistans();
                dataGridView2.Visible = true;
            }
            else if (radioButton3.Checked == true)
            {
                dataGridView2.Visible = false;
                search_Nurses();
                dataGridView2.Visible = true;
            }
            else if (radioButton4.Checked == true)
            {
                dataGridView2.Visible = false;
                search_Cleaning_Staff();
                dataGridView2.Visible = true;
            }
            else
            {
                MessageBox.Show("Arama yapılacak çalışan tablosunu seçin");
            }
        }
        private void search_Doctors()
        {
            string search = txtName.Text;
            var query = from item in personel.Doctors
                        join item1 in personel.Salaries
                        on item.salary_id equals item1.id
                        where item.name.Contains(search)
                        select new
                        {
                            item.name,
                            item.surname,
                            item.isSentry,
                            item1.salary1
                        };
            dataGridView2.DataSource = query.ToList();
        }
        private void search_Asistans()
        {
            string search = txtName.Text;
            var query = from item in personel.Asistans
                        where item.name.Contains(search)
                        select new { item.name, item.surname, item.salary, item.isSentry };
            dataGridView2.DataSource = query.ToList();
        }
        private void search_Nurses()
        {
            string search = txtName.Text;
            var query = from item in personel.Nurses
                        join item1 in personel.Salaries
                        on item.salary_id equals item1.id
                        where item.name.Contains(search)
                        select new
                        {
                            item.name,
                            item.surname,
                            item1.salary1
                        };
            dataGridView2.DataSource = query.ToList();
        }
        private void search_Cleaning_Staff()
        {
            string search = txtName.Text;
            var query = from item in personel.Cleaning_Staff
                        join item1 in personel.Salaries
                        on item.salary_id equals item1.id
                        join item2 in personel.Shifts
                        on item.shift_id equals item2.id
                        where item.name.Contains(search)
                        select new
                        {
                            item.name,
                            item.surname,
                            item1.salary1,
                            item2.type
                        };
            dataGridView2.DataSource = query.ToList();
        }
    }
}
