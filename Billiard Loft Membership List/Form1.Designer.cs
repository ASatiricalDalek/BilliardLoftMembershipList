namespace Billiard_Loft_Membership_List
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.lst_CurrentMembers = new System.Windows.Forms.ListBox();
            this.txt_MemberSearch = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Renew = new System.Windows.Forms.Button();
            this.btn_DeleteMember = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.grp_AddMember = new System.Windows.Forms.GroupBox();
            this.rad_2Months = new System.Windows.Forms.RadioButton();
            this.rad_1Month = new System.Windows.Forms.RadioButton();
            this.chk_Override = new System.Windows.Forms.CheckBox();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.txt_EndDate = new System.Windows.Forms.MaskedTextBox();
            this.txt_StartDate = new System.Windows.Forms.MaskedTextBox();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_expired = new System.Windows.Forms.TabPage();
            this.lst_ExpiredMembers = new System.Windows.Forms.ListBox();
            this.tab_current = new System.Windows.Forms.TabPage();
            this.lbl_sdLabel = new System.Windows.Forms.Label();
            this.lbl_sd = new System.Windows.Forms.Label();
            this.lbl_edLabel = new System.Windows.Forms.Label();
            this.lbl_ed = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_AddMember.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tab_expired.SuspendLayout();
            this.tab_current.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_CurrentMembers
            // 
            this.lst_CurrentMembers.FormattingEnabled = true;
            this.lst_CurrentMembers.Location = new System.Drawing.Point(6, 6);
            this.lst_CurrentMembers.Name = "lst_CurrentMembers";
            this.lst_CurrentMembers.Size = new System.Drawing.Size(239, 160);
            this.lst_CurrentMembers.TabIndex = 0;
            this.lst_CurrentMembers.SelectedIndexChanged += new System.EventHandler(this.lst_CurrentMembers_SelectedIndexChanged);
            // 
            // txt_MemberSearch
            // 
            this.txt_MemberSearch.Location = new System.Drawing.Point(12, 228);
            this.txt_MemberSearch.Name = "txt_MemberSearch";
            this.txt_MemberSearch.Size = new System.Drawing.Size(255, 20);
            this.txt_MemberSearch.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(12, 254);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(255, 24);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search Current Members";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Renew
            // 
            this.btn_Renew.Location = new System.Drawing.Point(277, 49);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(134, 44);
            this.btn_Renew.TabIndex = 4;
            this.btn_Renew.Text = "Renew Membership";
            this.btn_Renew.UseVisualStyleBackColor = true;
            this.btn_Renew.Click += new System.EventHandler(this.btn_Renew_Click);
            // 
            // btn_DeleteMember
            // 
            this.btn_DeleteMember.Location = new System.Drawing.Point(277, 99);
            this.btn_DeleteMember.Name = "btn_DeleteMember";
            this.btn_DeleteMember.Size = new System.Drawing.Size(134, 44);
            this.btn_DeleteMember.TabIndex = 5;
            this.btn_DeleteMember.Text = "Delete Member";
            this.btn_DeleteMember.UseVisualStyleBackColor = true;
            this.btn_DeleteMember.Click += new System.EventHandler(this.btn_DeleteMember_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(9, 45);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(131, 20);
            this.txt_FirstName.TabIndex = 6;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(155, 45);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(131, 20);
            this.txt_LastName.TabIndex = 7;
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.Location = new System.Drawing.Point(278, 145);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(115, 29);
            this.btn_AddMember.TabIndex = 12;
            this.btn_AddMember.Text = "Add Member";
            this.btn_AddMember.UseVisualStyleBackColor = true;
            this.btn_AddMember.Click += new System.EventHandler(this.btn_AddMember_Click);
            // 
            // grp_AddMember
            // 
            this.grp_AddMember.Controls.Add(this.rad_2Months);
            this.grp_AddMember.Controls.Add(this.rad_1Month);
            this.grp_AddMember.Controls.Add(this.chk_Override);
            this.grp_AddMember.Controls.Add(this.lbl_Duration);
            this.grp_AddMember.Controls.Add(this.txt_EndDate);
            this.grp_AddMember.Controls.Add(this.txt_StartDate);
            this.grp_AddMember.Controls.Add(this.lbl_EndDate);
            this.grp_AddMember.Controls.Add(this.label1);
            this.grp_AddMember.Controls.Add(this.lbl_LastName);
            this.grp_AddMember.Controls.Add(this.lbl_FirstName);
            this.grp_AddMember.Controls.Add(this.btn_AddMember);
            this.grp_AddMember.Controls.Add(this.txt_LastName);
            this.grp_AddMember.Controls.Add(this.txt_FirstName);
            this.grp_AddMember.Location = new System.Drawing.Point(12, 303);
            this.grp_AddMember.Name = "grp_AddMember";
            this.grp_AddMember.Size = new System.Drawing.Size(399, 189);
            this.grp_AddMember.TabIndex = 13;
            this.grp_AddMember.TabStop = false;
            this.grp_AddMember.Text = "Add New Member";
            // 
            // rad_2Months
            // 
            this.rad_2Months.AutoSize = true;
            this.rad_2Months.Location = new System.Drawing.Point(100, 163);
            this.rad_2Months.Name = "rad_2Months";
            this.rad_2Months.Size = new System.Drawing.Size(69, 17);
            this.rad_2Months.TabIndex = 22;
            this.rad_2Months.TabStop = true;
            this.rad_2Months.Text = "2 Months";
            this.rad_2Months.UseVisualStyleBackColor = true;
            // 
            // rad_1Month
            // 
            this.rad_1Month.AutoSize = true;
            this.rad_1Month.Checked = true;
            this.rad_1Month.Location = new System.Drawing.Point(9, 163);
            this.rad_1Month.Name = "rad_1Month";
            this.rad_1Month.Size = new System.Drawing.Size(64, 17);
            this.rad_1Month.TabIndex = 21;
            this.rad_1Month.TabStop = true;
            this.rad_1Month.Text = "1 Month";
            this.rad_1Month.UseVisualStyleBackColor = true;
            this.rad_1Month.CheckedChanged += new System.EventHandler(this.rad_1Month_CheckedChanged);
            // 
            // chk_Override
            // 
            this.chk_Override.AutoSize = true;
            this.chk_Override.Location = new System.Drawing.Point(318, 19);
            this.chk_Override.Name = "chk_Override";
            this.chk_Override.Size = new System.Drawing.Size(75, 17);
            this.chk_Override.TabIndex = 20;
            this.chk_Override.Text = "Advanced";
            this.chk_Override.UseVisualStyleBackColor = true;
            this.chk_Override.CheckedChanged += new System.EventHandler(this.chk_Override_CheckedChanged);
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Location = new System.Drawing.Point(6, 141);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(107, 13);
            this.lbl_Duration.TabIndex = 19;
            this.lbl_Duration.Text = "Membership Duration";
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.Enabled = false;
            this.txt_EndDate.Location = new System.Drawing.Point(155, 107);
            this.txt_EndDate.Mask = "00/00/0000";
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Size = new System.Drawing.Size(70, 20);
            this.txt_EndDate.TabIndex = 18;
            this.txt_EndDate.ValidatingType = typeof(System.DateTime);
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.Enabled = false;
            this.txt_StartDate.Location = new System.Drawing.Point(9, 107);
            this.txt_StartDate.Mask = "00/00/0000";
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Size = new System.Drawing.Size(84, 20);
            this.txt_StartDate.TabIndex = 17;
            this.txt_StartDate.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(152, 91);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(139, 13);
            this.lbl_EndDate.TabIndex = 16;
            this.lbl_EndDate.Text = "Membership Expiration Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Membership Start Date";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(152, 29);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 14;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(6, 29);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 13;
            this.lbl_FirstName.Text = "First Name";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab_expired);
            this.tabs.Controls.Add(this.tab_current);
            this.tabs.Location = new System.Drawing.Point(12, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(259, 195);
            this.tabs.TabIndex = 14;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tab_expired
            // 
            this.tab_expired.Controls.Add(this.lst_ExpiredMembers);
            this.tab_expired.Location = new System.Drawing.Point(4, 22);
            this.tab_expired.Name = "tab_expired";
            this.tab_expired.Padding = new System.Windows.Forms.Padding(3);
            this.tab_expired.Size = new System.Drawing.Size(251, 169);
            this.tab_expired.TabIndex = 0;
            this.tab_expired.Text = "Expired Members";
            this.tab_expired.UseVisualStyleBackColor = true;
            // 
            // lst_ExpiredMembers
            // 
            this.lst_ExpiredMembers.FormattingEnabled = true;
            this.lst_ExpiredMembers.Location = new System.Drawing.Point(6, 6);
            this.lst_ExpiredMembers.Name = "lst_ExpiredMembers";
            this.lst_ExpiredMembers.Size = new System.Drawing.Size(239, 160);
            this.lst_ExpiredMembers.TabIndex = 15;
            this.lst_ExpiredMembers.SelectedIndexChanged += new System.EventHandler(this.lst_ExpiredMembers_SelectedIndexChanged);
            // 
            // tab_current
            // 
            this.tab_current.Controls.Add(this.lst_CurrentMembers);
            this.tab_current.Location = new System.Drawing.Point(4, 22);
            this.tab_current.Name = "tab_current";
            this.tab_current.Padding = new System.Windows.Forms.Padding(3);
            this.tab_current.Size = new System.Drawing.Size(251, 169);
            this.tab_current.TabIndex = 1;
            this.tab_current.Text = "All Members";
            this.tab_current.UseVisualStyleBackColor = true;
            // 
            // lbl_sdLabel
            // 
            this.lbl_sdLabel.AutoSize = true;
            this.lbl_sdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdLabel.Location = new System.Drawing.Point(287, 157);
            this.lbl_sdLabel.Name = "lbl_sdLabel";
            this.lbl_sdLabel.Size = new System.Drawing.Size(115, 13);
            this.lbl_sdLabel.TabIndex = 15;
            this.lbl_sdLabel.Text = "Membership Start Date";
            // 
            // lbl_sd
            // 
            this.lbl_sd.AutoSize = true;
            this.lbl_sd.Location = new System.Drawing.Point(316, 175);
            this.lbl_sd.Name = "lbl_sd";
            this.lbl_sd.Size = new System.Drawing.Size(57, 13);
            this.lbl_sd.TabIndex = 16;
            this.lbl_sd.Text = "xx/xx/xxxx";
            // 
            // lbl_edLabel
            // 
            this.lbl_edLabel.AutoSize = true;
            this.lbl_edLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edLabel.Location = new System.Drawing.Point(287, 198);
            this.lbl_edLabel.Name = "lbl_edLabel";
            this.lbl_edLabel.Size = new System.Drawing.Size(112, 13);
            this.lbl_edLabel.TabIndex = 17;
            this.lbl_edLabel.Text = "Membership End Date";
            // 
            // lbl_ed
            // 
            this.lbl_ed.AutoSize = true;
            this.lbl_ed.Location = new System.Drawing.Point(316, 219);
            this.lbl_ed.Name = "lbl_ed";
            this.lbl_ed.Size = new System.Drawing.Size(57, 13);
            this.lbl_ed.TabIndex = 19;
            this.lbl_ed.Text = "xx/xx/xxxx";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "About";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.lbl_ed);
            this.Controls.Add(this.lbl_edLabel);
            this.Controls.Add(this.lbl_sd);
            this.Controls.Add(this.lbl_sdLabel);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.grp_AddMember);
            this.Controls.Add(this.btn_DeleteMember);
            this.Controls.Add(this.btn_Renew);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_MemberSearch);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Billiard Loft Membership List";
            this.Load += new System.EventHandler(this.main_Load);
            this.grp_AddMember.ResumeLayout(false);
            this.grp_AddMember.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tab_expired.ResumeLayout(false);
            this.tab_current.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_CurrentMembers;
        private System.Windows.Forms.TextBox txt_MemberSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Renew;
        private System.Windows.Forms.Button btn_DeleteMember;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Button btn_AddMember;
        private System.Windows.Forms.GroupBox grp_AddMember;
        private System.Windows.Forms.CheckBox chk_Override;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.MaskedTextBox txt_EndDate;
        private System.Windows.Forms.MaskedTextBox txt_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.RadioButton rad_2Months;
        private System.Windows.Forms.RadioButton rad_1Month;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_expired;
        private System.Windows.Forms.ListBox lst_ExpiredMembers;
        private System.Windows.Forms.TabPage tab_current;
        private System.Windows.Forms.Label lbl_sdLabel;
        private System.Windows.Forms.Label lbl_sd;
        private System.Windows.Forms.Label lbl_edLabel;
        private System.Windows.Forms.Label lbl_ed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

