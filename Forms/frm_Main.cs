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
using System.IO;
using QCM.Forms;
using QCM.UserControls;

namespace QCM
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            
        }

        User currentUser;
        Point position_new_button;

        private void frm_Main_Load(object sender, EventArgs e)
        {
            App.instance().main_form = this;


            if(!login())
            {
                return;
            }

            load_QCM_boxes();

            lbl_qcm_list.BackColor = Color.Transparent;

            position_new_button = btn_AddNew.Location;


            if (this.currentUser.isTeacher())
            {
                btn_AddNew.Visible = true;
            }
            else
            {
                btn_AddNew.Visible= false;
            }








            bool login()
            {
                this.Visible = false;
                frm_Login frmLogin = new frm_Login();
                frmLogin.ShowDialog();

                if (frmLogin.successfull)
                {
                    this.currentUser = frmLogin.user;
                    this.Visible = true;
                    frmLogin.Dispose();
                    App.instance().Status = App.enStatus.eList;

                   

                    return true;
                }
                else
                {
                    this.Close();
                    return false;
                }
            }

            
            
         

        }


        public void load_QCM_boxes()
        {
            p_QCM_List.AutoScrollPosition = new Point(0,0);

            reload();

        }

        public void reload()
        {
            for (int i = 0; i < this.p_QCM_List.Controls.Count; i++)
            {
                if (this.p_QCM_List.Controls[i] is ucQCM_box)
                {
                    this.p_QCM_List.Controls[i].Visible = false;

                }
            }

            

            this.p_QCM_List.Refresh();
            
            string[] QCM_List = File.ReadAllLines(App.fQCM_List);

            

            for (int i = 0; i < QCM_List.Count(); i++)
            {
                string[] qcm_info = QCM_List[i].Split(':');

                clsQCM qcm = new clsQCM(qcm_info[0], (enLevel)Convert.ToInt16(qcm_info[1]), Convert.ToByte(qcm_info[2]), Convert.ToByte(qcm_info[3]));
              

                for (int j = 0; j < qcm.questionCount; j++)
                {
                    string[] sQuestion = qcm_info[4 + j].Split('/');
                    clsQCM.Question question = new clsQCM.Question();
                    question.text = sQuestion[0];
                    question.correctAnswerIndex = Convert.ToByte(sQuestion[1]);
                    question.mark = Convert.ToByte(sQuestion[2]);

                    for (int k = 0; k < qcm.choisesCount; k++)
                    {
                        if (k + 3 < sQuestion.Length)
                        {
                            question.answers.Add(sQuestion[k + 3]);
                        }
                        else
                        {
                            question.answers.Add("NULL");

                        }
                    }

                    qcm.QuestionList.Add(question);
                }


                //this.p_QCM_List.Controls.Add(new ucQCM_box(currentUser,"Mecanique",enLevel.eEasy,20,5, new Point(80,100)));

                this.p_QCM_List.Controls.Add(new ucQCM_box(currentUser, qcm, new Point(170, 100 + 170 * i), i));
            }
        }

       
       

        private void tb_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tp_Main.SelectedTab == tp_QCM_LIST)
            {

            }
            else if(tp_Main.SelectedTab == tp_Preview)
            {
                if (this.currentUser.isStudent())
                {
                    btn_BackToQCM_List.Visible = false;
                }

            }
        }

        //private void Modify()
        //{
        //    clsQCM QCM = App.instance().CurrentQCM;
        //    TreeView node = new TreeView();
        //    node = tv_QCM;
        //    QCM.title


        //    for (int i = 0; i < QCM.questionCount; i++)
        //    {

        //        node.Nodes.Add(QCM.QuestionList[i].question);


        //        for (int j = 0; j < QCM.choisesCount; j++)
        //        {
        //            node.Nodes[i].Nodes.Add(QCM.QuestionList[i].answers[j]);
        //            if (QCM.QuestionList[i].correctAnswerIndex == j)
        //            {
        //                node.Nodes[i].Nodes[j].ForeColor = Color.Green;
        //            }
        //        }


        //    }
        //}

        private void tv_QCM_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {

            add_new_qcm();

            void add_new_qcm()
            {

                frm_AddNewQCM frm = new frm_AddNewQCM();
                frm.ShowDialog();
                load_QCM_boxes();
            }
        }

        private void p_QCM_List_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_QCM_List_Scroll(object sender, ScrollEventArgs e)
        {
            //this.btn_AddNew.Location = position_new_button;
        }

        private void btn_AddNew_LocationChanged(object sender, EventArgs e)
        {
            this.btn_AddNew.Location = position_new_button;

        }

        private void lbl_qcm_list_Click(object sender, EventArgs e)
        {

        }

        private void btn_BackToQCM_List_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.tp_Main.SelectedTab.Controls)
            {
                if(c is ucTest)
                {
                    c.Dispose();
                }
            }

            this.tp_Main.SelectedIndex = 0;
        }
    }
}
