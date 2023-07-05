namespace QCM.Forms
{
    partial class frm_AddNewQCM
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddNewQCM));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Level = new System.Windows.Forms.ComboBox();
            this.cb_ChoicesCount = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tv_qcm = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_QuestionListTitleAndCounter = new System.Windows.Forms.Label();
            this.tb_ControlQuestions = new System.Windows.Forms.TextBox();
            this.lbl_ControlTitle = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Done = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tb_Title
            // 
            this.tb_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.tb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.tb_Title.Location = new System.Drawing.Point(38, 101);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(237, 32);
            this.tb_Title.TabIndex = 0;
            this.tb_Title.TextChanged += new System.EventHandler(this.tb_Title_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adding New QCM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Level";
            // 
            // cb_Level
            // 
            this.cb_Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cb_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.cb_Level.FormattingEnabled = true;
            this.cb_Level.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cb_Level.Location = new System.Drawing.Point(37, 163);
            this.cb_Level.Name = "cb_Level";
            this.cb_Level.Size = new System.Drawing.Size(135, 31);
            this.cb_Level.TabIndex = 1;
            // 
            // cb_ChoicesCount
            // 
            this.cb_ChoicesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cb_ChoicesCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChoicesCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ChoicesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.cb_ChoicesCount.FormattingEnabled = true;
            this.cb_ChoicesCount.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cb_ChoicesCount.Location = new System.Drawing.Point(175, 164);
            this.cb_ChoicesCount.Name = "cb_ChoicesCount";
            this.cb_ChoicesCount.Size = new System.Drawing.Size(99, 31);
            this.cb_ChoicesCount.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(170, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Choices";
            // 
            // tv_qcm
            // 
            this.tv_qcm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_qcm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tv_qcm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_qcm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.tv_qcm.ImageIndex = 0;
            this.tv_qcm.ImageList = this.imageList1;
            this.tv_qcm.Location = new System.Drawing.Point(12, 340);
            this.tv_qcm.Name = "tv_qcm";
            this.tv_qcm.SelectedImageIndex = 0;
            this.tv_qcm.Size = new System.Drawing.Size(533, 453);
            this.tv_qcm.TabIndex = 18;
            this.tv_qcm.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_qcm_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_question.png");
            this.imageList1.Images.SetKeyName(1, "img_answer.png");
            // 
            // lbl_QuestionListTitleAndCounter
            // 
            this.lbl_QuestionListTitleAndCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_QuestionListTitleAndCounter.AutoSize = true;
            this.lbl_QuestionListTitleAndCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_QuestionListTitleAndCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionListTitleAndCounter.Location = new System.Drawing.Point(15, 304);
            this.lbl_QuestionListTitleAndCounter.Name = "lbl_QuestionListTitleAndCounter";
            this.lbl_QuestionListTitleAndCounter.Size = new System.Drawing.Size(284, 28);
            this.lbl_QuestionListTitleAndCounter.TabIndex = 19;
            this.lbl_QuestionListTitleAndCounter.Text = "Questions List (0 questions) : ";
            this.lbl_QuestionListTitleAndCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ControlQuestions
            // 
            this.tb_ControlQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_ControlQuestions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.tb_ControlQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.tb_ControlQuestions.Location = new System.Drawing.Point(12, 260);
            this.tb_ControlQuestions.Name = "tb_ControlQuestions";
            this.tb_ControlQuestions.Size = new System.Drawing.Size(449, 32);
            this.tb_ControlQuestions.TabIndex = 3;
            this.tb_ControlQuestions.TextChanged += new System.EventHandler(this.tb_ControlQuestions_TextChanged);
            // 
            // lbl_ControlTitle
            // 
            this.lbl_ControlTitle.AutoSize = true;
            this.lbl_ControlTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ControlTitle.Location = new System.Drawing.Point(15, 232);
            this.lbl_ControlTitle.Name = "lbl_ControlTitle";
            this.lbl_ControlTitle.Size = new System.Drawing.Size(179, 25);
            this.lbl_ControlTitle.TabIndex = 21;
            this.lbl_ControlTitle.Text = "Enter Question [1] : ";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(467, 260);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(78, 32);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QCM.Properties.Resources.img_Q;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(305, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 242);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Location = new System.Drawing.Point(467, 260);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 32);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Done
            // 
            this.btn_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Done.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold);
            this.btn_Done.Location = new System.Drawing.Point(12, 806);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(262, 54);
            this.btn_Done.TabIndex = 5;
            this.btn_Done.Text = "D o n e";
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Location = new System.Drawing.Point(283, 806);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(262, 54);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "C a n c e l";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_AddNewQCM
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(557, 872);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ControlTitle);
            this.Controls.Add(this.tb_ControlQuestions);
            this.Controls.Add(this.lbl_QuestionListTitleAndCounter);
            this.Controls.Add(this.tv_qcm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_ChoicesCount);
            this.Controls.Add(this.cb_Level);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_AddNewQCM";
            this.Load += new System.EventHandler(this.AddNewQCM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Level;
        private System.Windows.Forms.ComboBox cb_ChoicesCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView tv_qcm;
        private System.Windows.Forms.Label lbl_QuestionListTitleAndCounter;
        private System.Windows.Forms.TextBox tb_ControlQuestions;
        private System.Windows.Forms.Label lbl_ControlTitle;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Cancel;
    }
}