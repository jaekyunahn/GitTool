
namespace gittool
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGet_Name = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonSet_Name = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSet_Mail = new System.Windows.Forms.Button();
            this.buttonGet_Mail = new System.Windows.Forms.Button();
            this.textBoxUserMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSet_Address = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSet_Branch = new System.Windows.Forms.Button();
            this.buttonGet_Branch = new System.Windows.Forms.Button();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonGetStatus = new System.Windows.Forms.Button();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCommit = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonFindFile = new System.Windows.Forms.Button();
            this.textBoxAddFileAddress = new System.Windows.Forms.TextBox();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGetServerStatus = new System.Windows.Forms.Button();
            this.textBoxFunctionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLocalAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openAddFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonPull = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGet_Name
            // 
            this.buttonGet_Name.Location = new System.Drawing.Point(276, 31);
            this.buttonGet_Name.Name = "buttonGet_Name";
            this.buttonGet_Name.Size = new System.Drawing.Size(75, 23);
            this.buttonGet_Name.TabIndex = 0;
            this.buttonGet_Name.Text = "Get";
            this.buttonGet_Name.UseVisualStyleBackColor = true;
            this.buttonGet_Name.Click += new System.EventHandler(this.buttonGet_Name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(101, 33);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(169, 21);
            this.textBoxUserName.TabIndex = 2;
            // 
            // buttonSet_Name
            // 
            this.buttonSet_Name.Location = new System.Drawing.Point(357, 31);
            this.buttonSet_Name.Name = "buttonSet_Name";
            this.buttonSet_Name.Size = new System.Drawing.Size(75, 23);
            this.buttonSet_Name.TabIndex = 3;
            this.buttonSet_Name.Text = "Set";
            this.buttonSet_Name.UseVisualStyleBackColor = true;
            this.buttonSet_Name.Click += new System.EventHandler(this.buttonSet_Name_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLocalAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonSet_Mail);
            this.groupBox1.Controls.Add(this.buttonGet_Mail);
            this.groupBox1.Controls.Add(this.textBoxUserMail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSet_Name);
            this.groupBox1.Controls.Add(this.buttonGet_Name);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // buttonSet_Mail
            // 
            this.buttonSet_Mail.Location = new System.Drawing.Point(357, 66);
            this.buttonSet_Mail.Name = "buttonSet_Mail";
            this.buttonSet_Mail.Size = new System.Drawing.Size(75, 23);
            this.buttonSet_Mail.TabIndex = 7;
            this.buttonSet_Mail.Text = "Set";
            this.buttonSet_Mail.UseVisualStyleBackColor = true;
            this.buttonSet_Mail.Click += new System.EventHandler(this.buttonSet_Mail_Click);
            // 
            // buttonGet_Mail
            // 
            this.buttonGet_Mail.Location = new System.Drawing.Point(276, 66);
            this.buttonGet_Mail.Name = "buttonGet_Mail";
            this.buttonGet_Mail.Size = new System.Drawing.Size(75, 23);
            this.buttonGet_Mail.TabIndex = 4;
            this.buttonGet_Mail.Text = "Get";
            this.buttonGet_Mail.UseVisualStyleBackColor = true;
            this.buttonGet_Mail.Click += new System.EventHandler(this.buttonGet_Mail_Click);
            // 
            // textBoxUserMail
            // 
            this.textBoxUserMail.Location = new System.Drawing.Point(101, 68);
            this.textBoxUserMail.Name = "textBoxUserMail";
            this.textBoxUserMail.Size = new System.Drawing.Size(169, 21);
            this.textBoxUserMail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Mail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSet_Branch);
            this.groupBox2.Controls.Add(this.buttonSet_Address);
            this.groupBox2.Controls.Add(this.buttonGet_Branch);
            this.groupBox2.Controls.Add(this.textBoxAddress);
            this.groupBox2.Controls.Add(this.textBoxBranch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(24, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 90);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Address";
            // 
            // buttonSet_Address
            // 
            this.buttonSet_Address.Enabled = false;
            this.buttonSet_Address.Location = new System.Drawing.Point(344, 18);
            this.buttonSet_Address.Name = "buttonSet_Address";
            this.buttonSet_Address.Size = new System.Drawing.Size(75, 23);
            this.buttonSet_Address.TabIndex = 0;
            this.buttonSet_Address.Text = "Set";
            this.buttonSet_Address.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Location = new System.Drawing.Point(88, 20);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(169, 21);
            this.textBoxAddress.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            // 
            // buttonSet_Branch
            // 
            this.buttonSet_Branch.Enabled = false;
            this.buttonSet_Branch.Location = new System.Drawing.Point(344, 51);
            this.buttonSet_Branch.Name = "buttonSet_Branch";
            this.buttonSet_Branch.Size = new System.Drawing.Size(75, 23);
            this.buttonSet_Branch.TabIndex = 3;
            this.buttonSet_Branch.Text = "Set";
            this.buttonSet_Branch.UseVisualStyleBackColor = true;
            // 
            // buttonGet_Branch
            // 
            this.buttonGet_Branch.Location = new System.Drawing.Point(263, 51);
            this.buttonGet_Branch.Name = "buttonGet_Branch";
            this.buttonGet_Branch.Size = new System.Drawing.Size(75, 23);
            this.buttonGet_Branch.TabIndex = 0;
            this.buttonGet_Branch.Text = "Get";
            this.buttonGet_Branch.UseVisualStyleBackColor = true;
            this.buttonGet_Branch.Click += new System.EventHandler(this.buttonGet_Branch_Click);
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Location = new System.Drawing.Point(88, 53);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.Size = new System.Drawing.Size(169, 21);
            this.textBoxBranch.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Branch";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(25, 278);
            this.textBoxLog.MaxLength = 3276700;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(771, 366);
            this.textBoxLog.TabIndex = 4;
            // 
            // buttonInit
            // 
            this.buttonInit.Enabled = false;
            this.buttonInit.Location = new System.Drawing.Point(11, 20);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(141, 23);
            this.buttonInit.TabIndex = 8;
            this.buttonInit.Text = "Init Project";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonGetStatus
            // 
            this.buttonGetStatus.Location = new System.Drawing.Point(158, 20);
            this.buttonGetStatus.Name = "buttonGetStatus";
            this.buttonGetStatus.Size = new System.Drawing.Size(141, 23);
            this.buttonGetStatus.TabIndex = 9;
            this.buttonGetStatus.Text = "Get Status";
            this.buttonGetStatus.UseVisualStyleBackColor = true;
            this.buttonGetStatus.Click += new System.EventHandler(this.buttonGetStatus_Click);
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(6, 20);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(141, 23);
            this.buttonCommit.TabIndex = 10;
            this.buttonCommit.Text = "Commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCommit);
            this.groupBox3.Controls.Add(this.buttonCommit);
            this.groupBox3.Location = new System.Drawing.Point(501, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 246);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commit";
            // 
            // textBoxCommit
            // 
            this.textBoxCommit.Location = new System.Drawing.Point(6, 49);
            this.textBoxCommit.MaxLength = 3276700;
            this.textBoxCommit.Multiline = true;
            this.textBoxCommit.Name = "textBoxCommit";
            this.textBoxCommit.Size = new System.Drawing.Size(430, 191);
            this.textBoxCommit.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAddFile);
            this.groupBox4.Controls.Add(this.buttonFindFile);
            this.groupBox4.Controls.Add(this.textBoxAddFileAddress);
            this.groupBox4.Location = new System.Drawing.Point(802, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 83);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add File";
            // 
            // buttonFindFile
            // 
            this.buttonFindFile.Location = new System.Drawing.Point(6, 20);
            this.buttonFindFile.Name = "buttonFindFile";
            this.buttonFindFile.Size = new System.Drawing.Size(141, 23);
            this.buttonFindFile.TabIndex = 12;
            this.buttonFindFile.Text = "Find File";
            this.buttonFindFile.UseVisualStyleBackColor = true;
            this.buttonFindFile.Click += new System.EventHandler(this.buttonFindFile_Click);
            // 
            // textBoxAddFileAddress
            // 
            this.textBoxAddFileAddress.Location = new System.Drawing.Point(6, 49);
            this.textBoxAddFileAddress.Name = "textBoxAddFileAddress";
            this.textBoxAddFileAddress.Size = new System.Drawing.Size(458, 21);
            this.textBoxAddFileAddress.TabIndex = 8;
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(158, 20);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(141, 23);
            this.buttonAddFile.TabIndex = 13;
            this.buttonAddFile.Text = "Add File";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonPull);
            this.groupBox5.Controls.Add(this.buttonPush);
            this.groupBox5.Controls.Add(this.buttonGetServerStatus);
            this.groupBox5.Controls.Add(this.buttonGetStatus);
            this.groupBox5.Controls.Add(this.buttonInit);
            this.groupBox5.Location = new System.Drawing.Point(802, 367);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(464, 277);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Function";
            // 
            // buttonGetServerStatus
            // 
            this.buttonGetServerStatus.Enabled = false;
            this.buttonGetServerStatus.Location = new System.Drawing.Point(305, 20);
            this.buttonGetServerStatus.Name = "buttonGetServerStatus";
            this.buttonGetServerStatus.Size = new System.Drawing.Size(141, 23);
            this.buttonGetServerStatus.TabIndex = 10;
            this.buttonGetServerStatus.Text = "Get Server Status";
            this.buttonGetServerStatus.UseVisualStyleBackColor = true;
            // 
            // textBoxFunctionText
            // 
            this.textBoxFunctionText.Location = new System.Drawing.Point(960, 57);
            this.textBoxFunctionText.MaxLength = 3276700;
            this.textBoxFunctionText.Multiline = true;
            this.textBoxFunctionText.Name = "textBoxFunctionText";
            this.textBoxFunctionText.Size = new System.Drawing.Size(312, 215);
            this.textBoxFunctionText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(958, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Function Text";
            // 
            // textBoxLocalAddress
            // 
            this.textBoxLocalAddress.Location = new System.Drawing.Point(119, 104);
            this.textBoxLocalAddress.Name = "textBoxLocalAddress";
            this.textBoxLocalAddress.Size = new System.Drawing.Size(313, 21);
            this.textBoxLocalAddress.TabIndex = 9;
            this.textBoxLocalAddress.Text = "D:\\jaekyunahn\\Ai_Daily_report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Local Address";
            // 
            // openAddFileDialog
            // 
            this.openAddFileDialog.FileName = "openFileDialog1";
            this.openAddFileDialog.InitialDirectory = "D:\\jaekyunahn\\Ai_Daily_report";
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(11, 49);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(141, 23);
            this.buttonPush.TabIndex = 11;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonPull
            // 
            this.buttonPull.Location = new System.Drawing.Point(158, 49);
            this.buttonPull.Name = "buttonPull";
            this.buttonPull.Size = new System.Drawing.Size(141, 23);
            this.buttonPull.TabIndex = 12;
            this.buttonPull.Text = "Pull";
            this.buttonPull.UseVisualStyleBackColor = true;
            this.buttonPull.Click += new System.EventHandler(this.buttonPull_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 656);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFunctionText);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGet_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonSet_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSet_Mail;
        private System.Windows.Forms.Button buttonGet_Mail;
        private System.Windows.Forms.TextBox textBoxUserMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSet_Address;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSet_Branch;
        private System.Windows.Forms.Button buttonGet_Branch;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonGetStatus;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCommit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonFindFile;
        private System.Windows.Forms.TextBox textBoxAddFileAddress;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGetServerStatus;
        private System.Windows.Forms.TextBox textBoxFunctionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLocalAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openAddFileDialog;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonPull;
    }
}

