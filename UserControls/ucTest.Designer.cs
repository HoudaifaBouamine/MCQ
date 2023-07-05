namespace QCM.UserControls
{
    partial class ucTest
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Answer1 = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.lbl_QCM_Title = new System.Windows.Forms.Label();
            this.btn_Answer2 = new System.Windows.Forms.Button();
            this.btn_Answer3 = new System.Windows.Forms.Button();
            this.btn_Answer4 = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previews = new System.Windows.Forms.Button();
            this.btn_Answer5 = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.p_EndScreen = new System.Windows.Forms.Panel();
            this.btn_Conternue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Score_Ratio = new System.Windows.Forms.Label();
            this.Ratio_Of_Correct_Answers = new CircularProgressBar.CircularProgressBar();
            this.timer_Result_Inc = new System.Windows.Forms.Timer(this.components);
            this.p_EndScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Answer1
            // 
            this.btn_Answer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Answer1.FlatAppearance.BorderSize = 0;
            this.btn_Answer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Answer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.btn_Answer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Answer1.Location = new System.Drawing.Point(230, 195);
            this.btn_Answer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Answer1.Name = "btn_Answer1";
            this.btn_Answer1.Size = new System.Drawing.Size(773, 68);
            this.btn_Answer1.TabIndex = 0;
            this.btn_Answer1.Tag = "0";
            this.btn_Answer1.Text = " 01) Answer 1";
            this.btn_Answer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Answer1.UseVisualStyleBackColor = false;
            this.btn_Answer1.Click += new System.EventHandler(this.btn_SelectAnswer_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Question.Location = new System.Drawing.Point(112, 59);
            this.lbl_Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(1006, 122);
            this.lbl_Question.TabIndex = 1;
            this.lbl_Question.Text = "Question 01: ";
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Question.Click += new System.EventHandler(this.lbl_Question_Click);
            // 
            // lbl_QCM_Title
            // 
            this.lbl_QCM_Title.AutoSize = true;
            this.lbl_QCM_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QCM_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_QCM_Title.Location = new System.Drawing.Point(18, 12);
            this.lbl_QCM_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QCM_Title.Name = "lbl_QCM_Title";
            this.lbl_QCM_Title.Size = new System.Drawing.Size(209, 50);
            this.lbl_QCM_Title.TabIndex = 2;
            this.lbl_QCM_Title.Text = "QCM : Title";
            // 
            // btn_Answer2
            // 
            this.btn_Answer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Answer2.FlatAppearance.BorderSize = 0;
            this.btn_Answer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Answer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.btn_Answer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Answer2.Location = new System.Drawing.Point(230, 268);
            this.btn_Answer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Answer2.Name = "btn_Answer2";
            this.btn_Answer2.Size = new System.Drawing.Size(773, 68);
            this.btn_Answer2.TabIndex = 3;
            this.btn_Answer2.Tag = "0";
            this.btn_Answer2.Text = " 02) Answer 2";
            this.btn_Answer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Answer2.UseVisualStyleBackColor = false;
            this.btn_Answer2.Click += new System.EventHandler(this.btn_SelectAnswer_Click);
            // 
            // btn_Answer3
            // 
            this.btn_Answer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Answer3.FlatAppearance.BorderSize = 0;
            this.btn_Answer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Answer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.btn_Answer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Answer3.Location = new System.Drawing.Point(230, 341);
            this.btn_Answer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Answer3.Name = "btn_Answer3";
            this.btn_Answer3.Size = new System.Drawing.Size(773, 68);
            this.btn_Answer3.TabIndex = 4;
            this.btn_Answer3.Tag = "0";
            this.btn_Answer3.Text = " 03) Answer 3";
            this.btn_Answer3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Answer3.UseVisualStyleBackColor = false;
            this.btn_Answer3.Click += new System.EventHandler(this.btn_SelectAnswer_Click);
            // 
            // btn_Answer4
            // 
            this.btn_Answer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Answer4.FlatAppearance.BorderSize = 0;
            this.btn_Answer4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Answer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.btn_Answer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Answer4.Location = new System.Drawing.Point(230, 414);
            this.btn_Answer4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Answer4.Name = "btn_Answer4";
            this.btn_Answer4.Size = new System.Drawing.Size(773, 68);
            this.btn_Answer4.TabIndex = 5;
            this.btn_Answer4.Tag = "0";
            this.btn_Answer4.Text = " 04) Answer 4";
            this.btn_Answer4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Answer4.UseVisualStyleBackColor = false;
            this.btn_Answer4.Click += new System.EventHandler(this.btn_SelectAnswer_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(93)))));
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Next.Location = new System.Drawing.Point(881, 565);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(122, 41);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Back
            // 
            this.btn_Previews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Previews.FlatAppearance.BorderSize = 0;
            this.btn_Previews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previews.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Previews.Location = new System.Drawing.Point(751, 565);
            this.btn_Previews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Previews.Name = "btn_Back";
            this.btn_Previews.Size = new System.Drawing.Size(122, 41);
            this.btn_Previews.TabIndex = 7;
            this.btn_Previews.Text = "Previews";
            this.btn_Previews.UseVisualStyleBackColor = false;
            this.btn_Previews.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Answer5
            // 
            this.btn_Answer5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Answer5.FlatAppearance.BorderSize = 0;
            this.btn_Answer5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Answer5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.btn_Answer5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Answer5.Location = new System.Drawing.Point(230, 487);
            this.btn_Answer5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Answer5.Name = "btn_Answer5";
            this.btn_Answer5.Size = new System.Drawing.Size(773, 68);
            this.btn_Answer5.TabIndex = 8;
            this.btn_Answer5.Tag = "0";
            this.btn_Answer5.Text = " 05) Answer 5";
            this.btn_Answer5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Answer5.UseVisualStyleBackColor = false;
            this.btn_Answer5.Click += new System.EventHandler(this.btn_SelectAnswer_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(93)))));
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Submit.Location = new System.Drawing.Point(881, 565);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(122, 41);
            this.btn_Submit.TabIndex = 9;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(93)))));
            this.progressBar1.Location = new System.Drawing.Point(230, 565);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(514, 41);
            this.progressBar1.TabIndex = 10;
            // 
            // p_EndScreen
            // 
            this.p_EndScreen.Controls.Add(this.btn_Conternue);
            this.p_EndScreen.Controls.Add(this.label1);
            this.p_EndScreen.Controls.Add(this.lbl_Score_Ratio);
            this.p_EndScreen.Controls.Add(this.Ratio_Of_Correct_Answers);
            this.p_EndScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_EndScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(93)))));
            this.p_EndScreen.Location = new System.Drawing.Point(0, 0);
            this.p_EndScreen.Name = "p_EndScreen";
            this.p_EndScreen.Size = new System.Drawing.Size(1247, 631);
            this.p_EndScreen.TabIndex = 11;
            this.p_EndScreen.Visible = false;
            // 
            // btn_Conternue
            // 
            this.btn_Conternue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(93)))));
            this.btn_Conternue.FlatAppearance.BorderSize = 0;
            this.btn_Conternue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Conternue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conternue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_Conternue.Location = new System.Drawing.Point(1104, 12);
            this.btn_Conternue.Name = "btn_Conternue";
            this.btn_Conternue.Size = new System.Drawing.Size(127, 48);
            this.btn_Conternue.TabIndex = 3;
            this.btn_Conternue.Text = "Continue";
            this.btn_Conternue.UseVisualStyleBackColor = false;
            this.btn_Conternue.Click += new System.EventHandler(this.btn_Conternue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 32.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Score :";
            // 
            // lbl_Score_Ratio
            // 
            this.lbl_Score_Ratio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Score_Ratio.AutoSize = true;
            this.lbl_Score_Ratio.Font = new System.Drawing.Font("Segoe UI Semibold", 70.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Score_Ratio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_Score_Ratio.Location = new System.Drawing.Point(438, 226);
            this.lbl_Score_Ratio.Name = "lbl_Score_Ratio";
            this.lbl_Score_Ratio.Size = new System.Drawing.Size(378, 156);
            this.lbl_Score_Ratio.TabIndex = 1;
            this.lbl_Score_Ratio.Text = "00/20";
            this.lbl_Score_Ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Score_Ratio.Click += new System.EventHandler(this.lbl_Score_Ratio_Click);
            // 
            // Ratio_Of_Correct_Answers
            // 
            this.Ratio_Of_Correct_Answers.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Ratio_Of_Correct_Answers.AnimationSpeed = 1000;
            this.Ratio_Of_Correct_Answers.BackColor = System.Drawing.Color.Transparent;
            this.Ratio_Of_Correct_Answers.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Ratio_Of_Correct_Answers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ratio_Of_Correct_Answers.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Ratio_Of_Correct_Answers.InnerMargin = 2;
            this.Ratio_Of_Correct_Answers.InnerWidth = -1;
            this.Ratio_Of_Correct_Answers.Location = new System.Drawing.Point(373, 59);
            this.Ratio_Of_Correct_Answers.MarqueeAnimationSpeed = 2000;
            this.Ratio_Of_Correct_Answers.Name = "Ratio_Of_Correct_Answers";
            this.Ratio_Of_Correct_Answers.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Ratio_Of_Correct_Answers.OuterMargin = -25;
            this.Ratio_Of_Correct_Answers.OuterWidth = 26;
            this.Ratio_Of_Correct_Answers.ProgressColor = System.Drawing.Color.DarkGreen;
            this.Ratio_Of_Correct_Answers.ProgressWidth = 25;
            this.Ratio_Of_Correct_Answers.SecondaryFont = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratio_Of_Correct_Answers.Size = new System.Drawing.Size(500, 500);
            this.Ratio_Of_Correct_Answers.StartAngle = 270;
            this.Ratio_Of_Correct_Answers.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Ratio_Of_Correct_Answers.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Ratio_Of_Correct_Answers.SubscriptText = ".23";
            this.Ratio_Of_Correct_Answers.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Ratio_Of_Correct_Answers.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Ratio_Of_Correct_Answers.SuperscriptText = "°C";
            this.Ratio_Of_Correct_Answers.TabIndex = 0;
            this.Ratio_Of_Correct_Answers.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Ratio_Of_Correct_Answers.Value = 68;
            this.Ratio_Of_Correct_Answers.Click += new System.EventHandler(this.Ratio_Of_Correct_Answers_Click);
            // 
            // timer_Result_Inc
            // 
            this.timer_Result_Inc.Interval = 1000;
            this.timer_Result_Inc.Tick += new System.EventHandler(this.timer_Result_Inc_Tick);
            // 
            // ucTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.p_EndScreen);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Answer5);
            this.Controls.Add(this.btn_Previews);
            this.Controls.Add(this.btn_Answer4);
            this.Controls.Add(this.btn_Answer3);
            this.Controls.Add(this.btn_Answer2);
            this.Controls.Add(this.lbl_QCM_Title);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.btn_Answer1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Next);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTest";
            this.Size = new System.Drawing.Size(1247, 631);
            this.Load += new System.EventHandler(this.ucTest_Load);
            this.p_EndScreen.ResumeLayout(false);
            this.p_EndScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Answer1;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label lbl_QCM_Title;
        private System.Windows.Forms.Button btn_Answer2;
        private System.Windows.Forms.Button btn_Answer3;
        private System.Windows.Forms.Button btn_Answer4;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previews;
        private System.Windows.Forms.Button btn_Answer5;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel p_EndScreen;
        private CircularProgressBar.CircularProgressBar Ratio_Of_Correct_Answers;
        private System.Windows.Forms.Label lbl_Score_Ratio;
        private System.Windows.Forms.Timer timer_Result_Inc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Conternue;
    }
}
