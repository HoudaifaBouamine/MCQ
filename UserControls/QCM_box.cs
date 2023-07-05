using QCM.Classes;
using QCM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QCM.UserControls;

namespace QCM
{
    public enum enLevel { eEasy = 1, eMedium, eHard };

    public partial class ucQCM_box : UserControl
    {
        public ucQCM_box()
        {
            InitializeComponent();
        }

        public ucQCM_box(User user,string title,enLevel level,byte quationCount,byte chooseCount,Point location)
        {
            InitializeComponent();

            this.qcm = new clsQCM();

            if (user.isTeacher())
            {
                btn_Modify .Visible = true;
                btn_Preview.Visible = true;

            }
            else if (user.isStudent())
            {
                btn_Modify .Visible = false;
                btn_Preview.Visible = false;
            }

            this.user                  = user;
            this.lbl_Title.Text        =                        this.qcm.title = title;
            this.lbl_Level.Text        = "Level : "          + (this.qcm.level = level).ToString().Substring(1);
            this.lbl_QuationCount.Text = "Quastion Count : " + (this.qcm.questionCount = quationCount).ToString();
            this.lbl_ChoseCount.Text   = "Choose Count :"    + (this.qcm.choisesCount = chooseCount).ToString();
            this.Location = location;


        }


        private int number;
        public ucQCM_box(User user, clsQCM qcm, Point location,int Number)
        {

            InitializeComponent();

            this.qcm = qcm;
            this.user = user;
            this.Location = location;

            init_summary();

            this.number = Number;

            if (this.user.isStudent())
            {
                btn_Modify.Visible  = false;
                btn_Preview.Visible = false;
                btn_Delete.Visible  = false;
            }
            else if (this.user.isTeacher())
            {
                btn_Test.Visible    = false;
            }
            else if (this.user.isAdmin())
            {
                btn_Test.Visible = false;


            }
        }

        private void init_summary()
        {
            this.lbl_Title.Text = this.qcm.title;

            switch (this.qcm.level)
            {
                case enLevel.eEasy:
                    {
                        this.lbl_Level.Text = "Easy";
                        this.lbl_Level.ForeColor = Color.Green;
                        break;
                    }

                case enLevel.eMedium:
                    {
                        this.lbl_Level.Text = "Medium";
                        this.lbl_Level.ForeColor = Color.Yellow;
                        break;
                    }

                case enLevel.eHard:
                    {
                        this.lbl_Level.Text = "Hard";
                        this.lbl_Level.ForeColor = Color.Red;
                        break;
                    }

            }
        

            this.lbl_QuationCount.Text = "Question Count : " + this.qcm.questionCount.ToString();
            this.lbl_ChoseCount.Text = "Choose Count : " + this.qcm.choisesCount.ToString();
        }

        public ucQCM_box(User user, clsQCM qcm, Point location)
        {

            InitializeComponent();

            this.qcm = qcm;
            this.user = user;
            this.Location = location;

            init_summary();


        }

        // Global var
        clsQCM qcm;
        User user;

        private void QCM_box_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (user.havePermation(this))
            {


                frm_AddNewQCM frm = new frm_AddNewQCM();
                frm.isModify = true;
                frm.set(this.qcm);
                frm.ShowDialog();
                this.qcm = frm.get_update();

                string[] tmp = File.ReadAllLines(App.fQCM_List);
                tmp[this.number] = clsQCM.from_QCM_to_line(this.qcm);

                File.WriteAllLines(App.fQCM_List, tmp);
                 init_summary();

            }

         
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            App.instance().main_form.tp_Main.SelectedIndex = 1;
            ucTest test_preview = new ucTest(this.qcm,this.user);
            test_preview.Dock = DockStyle.None;
            App.instance().main_form.tp_Main.SelectedTab.Controls.Add(test_preview);

            Size tmp_Size = App.instance().main_form.tp_Main.SelectedTab.Size;
            test_preview.Location = new System.Drawing.Point(tmp_Size.Width/2 - test_preview.Width/2, tmp_Size.Height / 2 - test_preview.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string[] tmp = File.ReadAllLines(App.fQCM_List);
            if (tmp.Length == 0) return;

            string[] tmp2 = new string[tmp.Length-1];

            for (int i = 0; i < tmp.Length; i++)
            {
                if(i < this.number)
                {
                    tmp2[i] = tmp[i];
                }
                else if(i > this.number)
                {
                    tmp2[i-1] = tmp[i];
                }
            }

            File.WriteAllLines(App.fQCM_List, tmp2);
            App.instance().main_form.reload();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            App.instance().main_form.tp_Main.SelectedIndex = 1;
            ucTest test = new ucTest(this.qcm, this.user);
            test.Dock = DockStyle.None;
            App.instance().main_form.tp_Main.SelectedTab.Controls.Add(test);

            Size tmp_Size = App.instance().main_form.tp_Main.SelectedTab.Size;
            test.Location = new System.Drawing.Point(tmp_Size.Width / 2 - test.Width / 2, tmp_Size.Height / 2 - test.Height / 2);
       
        
        }
    }
}
