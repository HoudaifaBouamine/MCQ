using QCM.UserControls;

namespace QCM
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.p_QCM_List = new System.Windows.Forms.Panel();
            this.lbl_qcm_list = new System.Windows.Forms.Label();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.tp_Main = new System.Windows.Forms.TabControl();
            this.tp_QCM_LIST = new System.Windows.Forms.TabPage();
            this.tp_Preview = new System.Windows.Forms.TabPage();
            this.btn_BackToQCM_List = new System.Windows.Forms.Button();
            this.p_QCM_List.SuspendLayout();
            this.tp_Main.SuspendLayout();
            this.tp_QCM_LIST.SuspendLayout();
            this.tp_Preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_QCM_List
            // 
            this.p_QCM_List.AutoScroll = true;
            this.p_QCM_List.Controls.Add(this.lbl_qcm_list);
            this.p_QCM_List.Controls.Add(this.btn_AddNew);
            this.p_QCM_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_QCM_List.Location = new System.Drawing.Point(3, 3);
            this.p_QCM_List.Name = "p_QCM_List";
            this.p_QCM_List.Size = new System.Drawing.Size(1568, 852);
            this.p_QCM_List.TabIndex = 0;
            this.p_QCM_List.Scroll += new System.Windows.Forms.ScrollEventHandler(this.p_QCM_List_Scroll);
            this.p_QCM_List.Paint += new System.Windows.Forms.PaintEventHandler(this.p_QCM_List_Paint);
            // 
            // lbl_qcm_list
            // 
            this.lbl_qcm_list.AutoSize = true;
            this.lbl_qcm_list.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qcm_list.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_qcm_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbl_qcm_list.Location = new System.Drawing.Point(0, 18);
            this.lbl_qcm_list.Name = "lbl_qcm_list";
            this.lbl_qcm_list.Size = new System.Drawing.Size(160, 46);
            this.lbl_qcm_list.TabIndex = 0;
            this.lbl_qcm_list.Text = "QCM List";
            this.lbl_qcm_list.Click += new System.EventHandler(this.lbl_qcm_list_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_AddNew.FlatAppearance.BorderSize = 0;
            this.btn_AddNew.Location = new System.Drawing.Point(1463, 18);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(63, 59);
            this.btn_AddNew.TabIndex = 1;
            this.btn_AddNew.Text = "New";
            this.btn_AddNew.UseVisualStyleBackColor = false;
            this.btn_AddNew.LocationChanged += new System.EventHandler(this.btn_AddNew_LocationChanged);
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // tp_Main
            // 
            this.tp_Main.Controls.Add(this.tp_QCM_LIST);
            this.tp_Main.Controls.Add(this.tp_Preview);
            this.tp_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tp_Main.Location = new System.Drawing.Point(0, -46);
            this.tp_Main.Name = "tp_Main";
            this.tp_Main.SelectedIndex = 0;
            this.tp_Main.Size = new System.Drawing.Size(1582, 899);
            this.tp_Main.TabIndex = 0;
            this.tp_Main.SelectedIndexChanged += new System.EventHandler(this.tb_main_SelectedIndexChanged);
            // 
            // tp_QCM_LIST
            // 
            this.tp_QCM_LIST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tp_QCM_LIST.Controls.Add(this.p_QCM_List);
            this.tp_QCM_LIST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.tp_QCM_LIST.Location = new System.Drawing.Point(4, 37);
            this.tp_QCM_LIST.Name = "tp_QCM_LIST";
            this.tp_QCM_LIST.Padding = new System.Windows.Forms.Padding(3);
            this.tp_QCM_LIST.Size = new System.Drawing.Size(1574, 858);
            this.tp_QCM_LIST.TabIndex = 0;
            this.tp_QCM_LIST.Text = "QCM List";
            // 
            // tp_Preview
            // 
            this.tp_Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tp_Preview.Controls.Add(this.btn_BackToQCM_List);
            this.tp_Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.tp_Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.tp_Preview.Location = new System.Drawing.Point(4, 37);
            this.tp_Preview.Name = "tp_Preview";
            this.tp_Preview.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Preview.Size = new System.Drawing.Size(1574, 759);
            this.tp_Preview.TabIndex = 1;
            this.tp_Preview.Text = "Preview";
            // 
            // btn_BackToQCM_List
            // 
            this.btn_BackToQCM_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn_BackToQCM_List.FlatAppearance.BorderSize = 0;
            this.btn_BackToQCM_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackToQCM_List.Location = new System.Drawing.Point(6, 6);
            this.btn_BackToQCM_List.Name = "btn_BackToQCM_List";
            this.btn_BackToQCM_List.Size = new System.Drawing.Size(112, 45);
            this.btn_BackToQCM_List.TabIndex = 0;
            this.btn_BackToQCM_List.Text = "Back";
            this.btn_BackToQCM_List.UseVisualStyleBackColor = false;
            this.btn_BackToQCM_List.Click += new System.EventHandler(this.btn_BackToQCM_List_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tp_Main);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Main";
            this.Text = "QCM";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.p_QCM_List.ResumeLayout(false);
            this.p_QCM_List.PerformLayout();
            this.tp_Main.ResumeLayout(false);
            this.tp_QCM_LIST.ResumeLayout(false);
            this.tp_Preview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel p_QCM_List;
        public System.Windows.Forms.Label lbl_qcm_list;
        public System.Windows.Forms.TabControl tp_Main;
        public System.Windows.Forms.TabPage tp_QCM_LIST;
        public System.Windows.Forms.TabPage tp_Preview;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_BackToQCM_List;
    }
}

