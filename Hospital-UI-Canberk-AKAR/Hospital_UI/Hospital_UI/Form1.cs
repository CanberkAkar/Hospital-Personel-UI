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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLogins.Visible = false;
            txtPassword.PasswordChar = '*';
            txtPassword_Main.PasswordChar = '*';
        }
        PersonelEntities personel = new PersonelEntities();
        Login lgn = new Login();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogins_Click(object sender, EventArgs e)
        {
            panelLogins.Visible = true;
            panel1.Visible = false;
            lblPsw.Visible = false;
            txtPassword.Visible = false;
            btnUsers.Visible = false;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            panelLogins.Visible = true;
            panel1.Visible = true;
            lblPsw.Visible = true;
            txtPassword.Visible = true;
            txtName.Clear();
            txtPassword_Main.Clear();
            btnUsers.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (personel.Logins.Where(r => r.name == txtName.Text && r.password == txtPassword_Main.Text).Count() > 0)
                {
                    MessageBox.Show("Başarılı, Hoşgeldin " + txtName.Text);
                    Form2 form2 = new Form2();
                    form2.Show(); 
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("Şifreniz veya parolanız yanlış lütefen tekrar deneyin");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            if (txtPassword_Main.Text == txtPassword.Text)
            {
                lgn.name = txtName.Text;
                lgn.password = (txtPassword_Main.Text).ToString();
                personel.Logins.Add(lgn);
                personel.SaveChanges();
                MessageBox.Show("Kayıt Başarılı, Hoşgeldin " + txtName.Text);
            }
            else
            {

                MessageBox.Show("Şifreniz veya parolanız yanlış lütefen tekrar deneyin");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
