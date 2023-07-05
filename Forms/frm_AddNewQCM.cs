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
using System.Xml.Linq;
using static QCM.Classes.clsQCM;

namespace QCM.Forms
{
    public partial class frm_AddNewQCM : Form
    {
        public frm_AddNewQCM()
        {
            InitializeComponent();
            qcm = new clsQCM();
            cb_ChoicesCount.SelectedIndex = 0;
            cb_Level.SelectedIndex = 1;

           
        }

        
        private void AddNewQCM_Load(object sender, EventArgs e)
        {
            if (isModify)
            {
                cb_ChoicesCount.Enabled = false;
                
            }
        
            this.Location = new System.Drawing.Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width / 2 - this.Size.Width / 2, System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height / 2 - this.Size.Height / 2);

            List<Question> q_list = this.qcm.QuestionList;
            correctAnswers = new List<byte>();
            for (int i = 0; i < q_list.Count; i++)
            {

                correctAnswers.Add(q_list[i].correctAnswerIndex);
            }
        }

        clsQCM qcm;clsQCM tmp;
        short ansers_to_add = 0;
        public bool isModify = false;
        bool apply = false;
        List<byte> correctAnswers;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ansers_to_add == 0)
            {// Adding new Question


                if (!string.IsNullOrEmpty(tb_ControlQuestions.Text))
                {
                    tv_qcm.Nodes.Add(tb_ControlQuestions.Text);
                    ansers_to_add = Convert.ToByte(cb_ChoicesCount.Text);
                    lbl_ControlTitle.Text = "Enter Answer [" + 1 + "] :";
                    tv_qcm.Enabled = false;
                    lbl_QuestionListTitleAndCounter.Text = "Questions List(" + tv_qcm.Nodes.Count + " questions) : ";
                }
                tb_ControlQuestions.Clear();
                tb_ControlQuestions.Focus();

                foreach(TreeNode node in tv_qcm.Nodes)
                {
                    node.Collapse();
                }

            }
            else
            {// Adding new answer

                if (ansers_to_add != -1)
                {
                    if (!string.IsNullOrEmpty(tb_ControlQuestions.Text))
                    {
                        tv_qcm.Nodes[tv_qcm.Nodes.Count - 1].Nodes.Add(tb_ControlQuestions.Text);
                        tv_qcm.Nodes[tv_qcm.Nodes.Count - 1].Nodes[tv_qcm.Nodes[tv_qcm.Nodes.Count - 1].Nodes.Count - 1].ImageIndex = 1;
                        ansers_to_add--;
                        lbl_ControlTitle.Text = "Enter Answer [" + (tv_qcm.Nodes[tv_qcm.Nodes.Count - 1].Nodes.Count + 1) + "] :";

                    }
                    tb_ControlQuestions.Clear();
                    tb_ControlQuestions.Focus();
                }

                if(ansers_to_add == 0)
                {
                    ansers_to_add = -1;// Prevent exit
                    lbl_ControlTitle.Text = "Enter Correct answer number :";
                    btn_Add.Text = "Select";
                    tb_ControlQuestions.Text = "";
                    tb_ControlQuestions.MaxLength = 1;
                }
                else if (ansers_to_add == -1 )
                {
                    if (tb_ControlQuestions.Text == "")
                    {
                        errorProvider1.SetError(tb_ControlQuestions, "Can not be empty");
                        return;
                    }



                    if (Convert.ToByte(tb_ControlQuestions.Text[0]) < '1' || Convert.ToByte(cb_ChoicesCount.Text[0]) < Convert.ToByte(tb_ControlQuestions.Text[0]))
                    {
                        tb_ControlQuestions.Text = "";
                        errorProvider1.SetError(tb_ControlQuestions, "Must be number between [1] and [" + cb_ChoicesCount.Text[0] + "]");
                        return;
                    }

                    if (Convert.ToByte(tb_ControlQuestions.Text) >= 1 && Convert.ToByte(tb_ControlQuestions.Text) <= Convert.ToByte(cb_ChoicesCount.Text) + 48)
                    {
                        tv_qcm.Nodes[tv_qcm.Nodes.Count - 1].Nodes[Convert.ToByte(tb_ControlQuestions.Text) - 1].Tag = "1";
                        tv_qcm.Nodes[tv_qcm.Nodes.Count - 1].Nodes[Convert.ToByte(tb_ControlQuestions.Text) - 1].ForeColor = Color.Green;

                        tv_qcm.Enabled = true;
                        lbl_ControlTitle.Text = "Enter Question [" + (tv_qcm.Nodes.Count + 1) + "] :";
                        tb_ControlQuestions.MaxLength = 100;
                        ansers_to_add = 0;// Exit

                        correctAnswers.Add((byte)(Convert.ToByte(tb_ControlQuestions.Text) - 1));
                    }


                }

                errorProvider1.SetError(tb_ControlQuestions, "");
                tb_ControlQuestions.Text = "";
                tv_qcm.Nodes[tv_qcm.Nodes.Count - 1].Expand();
            }
        }

        private void tv_qcm_AfterSelect(object sender, TreeViewEventArgs e)


        {

            for (int i = 0; i < tv_qcm.Nodes.Count; i++)
            {

                tv_qcm.Nodes[i].BackColor = Color.FromArgb(50,50,50);
                tv_qcm.Nodes[i].ForeColor = Color.FromArgb(206,206,206);

                for (int j = 0; j < tv_qcm.Nodes[i].Nodes.Count; j++)
                {

                    tv_qcm.Nodes[i].Nodes[j].BackColor = Color.FromArgb(50, 50, 50);

                    if (tv_qcm.Nodes[i].Nodes[j].Tag == "1")
                    {
                        tv_qcm.Nodes[i].Nodes[j].ForeColor = Color.Green;

                    }
                    else
                    {
                        tv_qcm.Nodes[i].Nodes[j].ForeColor = Color.FromArgb(206, 206, 206);
                    }
                }

            }

            
            tv_qcm.SelectedNode.BackColor = Color.FromArgb(206, 206, 206); //Color.Yellow;
            tv_qcm.SelectedNode.ForeColor = Color.FromArgb(50, 50, 50);// Color.Purple;
            tv_qcm.Enabled = false;

            btn_Add     .Visible = false;
            btn_Update  .Visible = true ;
            this.AcceptButton = btn_Update;


            tb_ControlQuestions.Text = tv_qcm.SelectedNode.Text;
            tb_ControlQuestions.Select();
            tb_ControlQuestions.Focus();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            btn_Add.Visible = true;
            btn_Update.Visible = false;
            tv_qcm.Enabled = true;
            this.AcceptButton = btn_Add;


            if (tb_ControlQuestions.Text == "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this question ?","Confermation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    tv_qcm.SelectedNode.Remove();
                    MessageBox.Show("The Question Will not be deleted if you do not press \"Done\"", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            tv_qcm.SelectedNode.BackColor = Color.FromArgb(50, 50, 50);
            tv_qcm.SelectedNode.ForeColor = Color.FromArgb(206, 206, 206);
            tv_qcm.SelectedNode.Text = tb_ControlQuestions.Text;
            tb_ControlQuestions.Clear();


        }


        private void btn_Done_Click(object sender, EventArgs e)
        {

            apply = true;

            if(tb_Title.Text == "")
            {
                errorProvider1.SetError(tb_Title, "Title Can not be empty");
                tb_Title.Focus();
                return;
            }
            if(tv_qcm.Nodes.Count == 0)
            {
                errorProvider1.SetError(lbl_QuestionListTitleAndCounter, "QCM must have at least one question");
                tb_ControlQuestions.Focus();
                return;
            }

            this.qcm = clsQCM.from_tree_to_QCM_class(tv_qcm, tb_Title.Text, (enLevel)(cb_Level.SelectedIndex + 1),
                Convert.ToByte(cb_ChoicesCount.Text),correctAnswers);
            clsQCM.add_QCM_to_file(this.qcm,isModify);
            this.Close();
        }

        private void tb_Title_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tb_Title, "");

        }

        private void tb_ControlQuestions_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(lbl_QuestionListTitleAndCounter, "");

        }

        

        public void set(clsQCM qcm)
        {
            this.qcm = qcm;
            this.tmp = qcm;
            from_qcm_to_this();

        }

        private void from_qcm_to_this()
        {
            tb_Title.Text = qcm.title;
            cb_ChoicesCount.SelectedIndex = qcm.choisesCount - 3;
            cb_Level.SelectedIndex =  (int)qcm.level - 1;

            TreeView node = this.tv_qcm;

            for (int i = 0; i < qcm.questionCount; i++)
            {

                node.Nodes.Add(qcm.QuestionList[i].text);


                for (int j = 0; j < qcm.choisesCount; j++)
                {
                    node.Nodes[i].Nodes.Add(qcm.QuestionList[i].answers[j]);
                    if (qcm.QuestionList[i].correctAnswerIndex == j)
                    {
                        node.Nodes[i].Nodes[j].ForeColor = Color.Green;
                    }
                }


            }
        }

        public clsQCM get_update()
        {
        
            if (apply)
            {
                apply = false;
                return this.qcm;
            }
            else
            {
                return this.tmp;
            }
        
        }

        private bool no_changes()
        {
            clsQCM tmp2 = clsQCM.from_tree_to_QCM_class(tv_qcm, tb_Title.Text, (enLevel)(cb_Level.SelectedIndex + 1), Convert.ToByte(cb_ChoicesCount.Text), correctAnswers);


            bool result = true;
            result &= tmp2.title        == qcm.title;
            result &= tmp2.choisesCount == qcm.choisesCount;
            result &= tmp2.choisesCount == qcm.choisesCount;
            result &= tmp2.level        == qcm.level;

            for(int i = 0; i <  qcm.QuestionList.Count; i++)
            {
                if (qcm.QuestionList[i].text != tmp.QuestionList[i].text)
                {
                    return false;
                }

                for (int j = 0; j < qcm.QuestionList[i].answers.Count; j++)
                {
                    if (qcm.QuestionList[i].answers[j] != tmp.QuestionList[i].answers[j])
                        return false;
                }

            }


            return result;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            apply = false;
            if (isModify)
            {
                if (no_changes())
                {
                    this.Close();
                    return;
                }

                DialogResult result = MessageBox.Show("Do you need to ignour your modifications ?", "Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you need to cancel the new QCM ?", "Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
