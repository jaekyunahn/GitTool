using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gittool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            printf("App Start\r\n");
        }

        //-------------------------------------------------------------------------------------------------------------

        void printf(string data)
        {
            textBoxLog.AppendText(get_time() + data);
        }

        //시간 가져오기
        string get_time()
        {
            return DateTime.Now.ToString("[yy-MM-dd.HH:mm:ss.ffff]");
        }


        //git 프로그램 실행 및 결과 가져오기
        string process_run(string processname , string workaddress, string sArguments)
        {
            bool result = true;

            string res = "NULL return";
            string errormessage = "none error";

            StreamReader reader;
            StreamReader errorReader;

            try
            {
                Process gitProcess = new Process();
                gitProcess.StartInfo.FileName = processname;
                gitProcess.StartInfo.UseShellExecute = false;
                gitProcess.StartInfo.RedirectStandardOutput = true;
                gitProcess.StartInfo.RedirectStandardError = true;
                gitProcess.StartInfo.WorkingDirectory = workaddress;
                gitProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                gitProcess.StartInfo.Arguments = sArguments;
                gitProcess.Start();

                reader = gitProcess.StandardOutput;
                errorReader = gitProcess.StandardError;

                res = reader.ReadToEnd();
                errormessage = errorReader.ReadToEnd();

                printf("[process]Error:"+ errormessage + "\r\n");

                gitProcess.WaitForExit();
            }
            catch (Exception e)
            {
                printf("Error process_run="+ e + "\r\n");
            }
            return res;
        }

        //-------------------------------------------------------------------------------------------------------------

        private void buttonInit_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetStatus_Click(object sender, EventArgs e)
        {
            //상태 가져오기 -> textBoxFunctionText
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "status");
        }

        private void buttonGet_Name_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = process_run("git", textBoxLocalAddress.Text, "config --global user.name");
        }

        private void buttonSet_Name_Click(object sender, EventArgs e)
        {
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "config --global user.name \"" + textBoxUserName.Text + "\"");
        }

        private void buttonGet_Mail_Click(object sender, EventArgs e)
        {
            textBoxUserMail.Text = process_run("git", textBoxLocalAddress.Text, "config --global user.email");
        }

        private void buttonSet_Mail_Click(object sender, EventArgs e)
        {
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "config --global user.email \"" + textBoxUserMail.Text + "\"");
        }

        private void buttonGet_Branch_Click(object sender, EventArgs e)
        {
            //branch는 좀더 개선 해야 함
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "branch");
        }

        private void buttonFindFile_Click(object sender, EventArgs e)
        {
            if (this.openAddFileDialog.ShowDialog() == DialogResult.OK) 
            {
                this.textBoxAddFileAddress.Text = this.openAddFileDialog.FileName; 
            }
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            //textBoxAddFileAddress.text
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "add \"" + textBoxAddFileAddress.Text + "\"");
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            //textBoxCommit
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "commit -m \"" + textBoxCommit.Text + "\"");
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "push");
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            textBoxFunctionText.Text = process_run("git", textBoxLocalAddress.Text, "pull");
        }
    }
}
