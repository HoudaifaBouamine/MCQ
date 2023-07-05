using QCM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM
{
    public partial class frm_Login : Form
    {
        public User user;
        public bool successfull =  false;
        public frm_Login()
        {
            InitializeComponent();
            successfull = false;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width / 2 - this.Size.Width / 2, System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height / 2 - this.Size.Height / 2);
            user = new User();

            App.instance().Status = App.enStatus.eLogin;

        }

        private void btn_login_teacher_Click(object sender, EventArgs e)
        {

            if(user.Email == "houdaifa@gmail.com" && user.isCorrectPassword("1234"))
            {

                user = User.get_Teacher();
                this.successfull = true;
                this.Close();
            }
            else
            {
                errorProvider1.SetError(btn_login_teacher, "email or password not valid");
                tb_Password.Text = "";
                
            }

        }

        private void tb_Email_Validating(object sender, CancelEventArgs e)
        {
            user.Email = tb_Email.Text;

            if (user.Email == null)
            {

                e.Cancel = true;
                tb_Email.Focus();
                errorProvider1.SetError(tb_Email, "Not valied email enter valied one");


            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_Email, "");
            }
        }

        private void tb_Password_Validating(object sender, CancelEventArgs e)
        {

            user.Password = "";

            if (string.IsNullOrWhiteSpace(tb_Password.Text))
            {

                e.Cancel = true;
                tb_Email.Focus();
                errorProvider1.SetError(tb_Password, "Password can not be empty or white space");


            }
            else
            {
                user.Password = tb_Password.Text;
                e.Cancel = false;
                errorProvider1.SetError(tb_Password, "");
            }
        }

        private void btn_login_student_Click(object sender, EventArgs e)
        {
            if (user.Email == "h.bouamine@gmail.com" && user.isCorrectPassword("1234"))
            {

                user = User.get_Student();
                this.successfull = true;
                this.Close();
            }
            else
            {
                errorProvider1.SetError(btn_login_teacher, "email or password not valid");
                tb_Password.Text = "";

            }
        }
    }
}
