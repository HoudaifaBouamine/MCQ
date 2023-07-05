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

namespace QCM.UserControls
{
    public partial class ucTest : UserControl
    {
        public ucTest(clsQCM qcm, User user)
        {
            InitializeComponent();
            isPreview = user.isTeacher();
            this.qcm = qcm;

            lbl_QCM_Title.Text = this.qcm.title;
            btn_All_Answers = new List<Button>();
            btn_All_Answers.Add(btn_Answer1);
            btn_All_Answers.Add(btn_Answer2);
            btn_All_Answers.Add(btn_Answer3);
            btn_All_Answers.Add(btn_Answer4);
            btn_All_Answers.Add(btn_Answer5);

            float font_step = 70 / 5;
            lbl_Score_Ratio.Font = new Font(lbl_Score_Ratio.Font.FontFamily, 1, lbl_Score_Ratio.Font.Style);

            for (int i = 0; i < btn_All_Answers.Count; i++)
            {
                
                if (i < this.qcm.choisesCount)
                {
                    lbl_Score_Ratio.Font = new Font(lbl_Score_Ratio.Font.FontFamily, lbl_Score_Ratio.Font.Size + font_step, lbl_Score_Ratio.Font.Style);
                    btn_All_Answers[i].Visible = true;
                }
                else
                {
                    btn_All_Answers[i].Visible = false;
                    this.Size = new Size(this.Size.Width,this.Size.Height - btn_All_Answers[i].Height);


                    btn_Next    .Location = new Point(btn_Next.Location    .X, btn_Next.Location    .Y - btn_All_Answers[i].Height);
                    btn_Previews    .Location = new Point(btn_Previews.Location    .X, btn_Previews.Location    .Y - btn_All_Answers[i].Height);
                    btn_Submit  .Location = new Point(btn_Submit.Location  .X, btn_Submit.Location  .Y - btn_All_Answers[i].Height);
                    progressBar1.Location = new Point(progressBar1.Location.X, progressBar1.Location.Y - btn_All_Answers[i].Height);
                    Ratio_Of_Correct_Answers.Size = new Size(Ratio_Of_Correct_Answers.Size.Width - btn_Answer1.Height, Ratio_Of_Correct_Answers.Size.Height - btn_Answer1.Height);
                    Ratio_Of_Correct_Answers.Location = new Point(Ratio_Of_Correct_Answers.Location.X + btn_Answer1.Height / 2, Ratio_Of_Correct_Answers.Location.Y);

                    lbl_Score_Ratio.Location = new Point(lbl_Score_Ratio.Location.X + btn_Answer1.Height / 2, lbl_Score_Ratio.Location.Y + (btn_Answer1.Height * 5/7));


                }
            }

            btn_Previews.Enabled = false;
            btn_Next.Enabled = false;

            progressBar1.Step = 1;
            progressBar1.Maximum = this.qcm.questionCount;

            selected_answers = new List<sbyte>();

            for(int i = 0; i < this.qcm.questionCount ; i++)
            {
                selected_answers.Add(-1);
            }


            //
            Ratio_Of_Correct_Answers.Value = 0;
            p_EndScreen.Visible = false;

        }

        public ucTest()
        {

        }
        

        clsQCM qcm;
        bool isPreview ;
        List<Button> btn_All_Answers;
        List<sbyte> selected_answers;

        int currentQuestionIndex;

        private void ucTest_Load(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            ShowQuestion(this.qcm.QuestionList[currentQuestionIndex], currentQuestionIndex + 1);


            if(this.qcm.questionCount == 1)
            {
                btn_Next.Visible   = false;
                btn_Submit.Visible = true;
            }

        }

        private void ShowQuestion(clsQCM.Question question,int QuestionNumber)
        {
            lbl_Question.Text = "Question " + QuestionNumber.ToString("00") + " : " + question.text;

            
            for(int i = 0; i < this.qcm.choisesCount; i++)
            {
                btn_All_Answers[i].Text =  "  0" + (i + 1) + ") "  + question.answers[i];
            }
            

        }

        private void lbl_Question_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        { 
            currentQuestionIndex--;
            progressBar1.Value -= progressBar1.Step;

            ShowQuestion(this.qcm.QuestionList[currentQuestionIndex], currentQuestionIndex + 1);

            if(currentQuestionIndex == 0)
            {
                btn_Previews.Enabled = false;
            }

            btn_Next  .Visible = true ;
            btn_Submit.Visible = false;

        }


        private void btn_Next_Click(object sender, EventArgs e)
        {


            currentQuestionIndex++;
            progressBar1.Value += progressBar1.Step;


            ShowQuestion(this.qcm.QuestionList[currentQuestionIndex], currentQuestionIndex + 1);

            btn_Previews.Enabled = true;


            if (currentQuestionIndex + 1 == this.qcm.questionCount)
            {
                btn_Next.Visible = false;
                btn_Submit.Visible = true;

                btn_Submit.Enabled = (selected_answers[currentQuestionIndex] != -1);

            }

            if (selected_answers[currentQuestionIndex] == -1)
                btn_Next.Enabled = false;




            reset_Buttons_Status();

            if (selected_answers[currentQuestionIndex] != -1)
            {
                btn_All_Answers[selected_answers[currentQuestionIndex]].Tag = "1";
            }


            apply_button_check();

        }

        private void apply_button_check()
        {

            foreach (Button btn in btn_All_Answers)
            {
                if (btn.Tag == "1")
                {
                    btn.BackColor = Color.FromArgb(44, 187, 93);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(60,60,60);

                }
            }

        }


        int score = 0;

        private void calcScore()
        {
            for(int i = 0; i < qcm.questionCount; i++)
            {

                if (selected_answers[i] == qcm.QuestionList[i].correctAnswerIndex)
                {
                    score += 1;
                }

            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {

            calcScore();

            Ratio_Of_Correct_Answers.Maximum = qcm.questionCount * 10;

            if (this.score != 0)
            {
                timer_Result_Inc.Interval = (int)(1000.0 / this.score);
            }
            else
            {
                timer_Result_Inc.Interval = 1000;

            }

            timer_Result_Inc.Start();

            if (!isPreview)
            {
                Save();
            }

        }
        private void Save()
        {
            // Note (Houdaifa) Here you must save the results to the student (not to teacher) info in file 
        }
        private void btn_SelectAnswer_Click(object sender, EventArgs e)
        {

            reset_Buttons_Status();
            ((Button)(sender)).Tag = "1";
            
            for(int i = 0; i < qcm.questionCount;i++)
            {
                if (btn_All_Answers[i].Tag.ToString() == "1")
                {
                    selected_answers[currentQuestionIndex] = ((sbyte)i);
                }
            }

            apply_button_check();
            btn_Next.Enabled = true;
            btn_Submit.Enabled = true;

        }

        private void reset_Buttons_Status()
        {
            foreach (Button btn in btn_All_Answers)
            {
                btn.Tag = "0";
            }
        }

        private void set_Buttons_Status()
        {
            foreach (Button btn in btn_All_Answers)
            {
                btn.Tag = "0";
            }
        }

   

        int counter = 0;
        private void timer_Result_Inc_Tick(object sender, EventArgs e)
        {

            
            p_EndScreen.Visible = true;
            lbl_Score_Ratio.Text = counter.ToString("00") + "/" + this.qcm.questionCount.ToString("00");

            if(counter != 0)
            Ratio_Of_Correct_Answers.Increment(10);

            if (counter >= score)
            {
                timer_Result_Inc.Stop();
            }

            counter++;
        }

        private void Ratio_Of_Correct_Answers_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Score_Ratio_Click(object sender, EventArgs e)
        {

        }

        private void btn_Conternue_Click(object sender, EventArgs e)
        {
            App.instance().main_form.tp_Main.SelectedIndex = 0;
        }
    }
}
