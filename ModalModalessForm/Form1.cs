using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "종료합니다";
            Application.ExitThread();
        }

        private void BtmModal_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        private void ModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        private void ShowModal()
        {
            this.statusMessage.Text = "모달 창을 띄웁니다.";
            FormModal m = new FormModal();
            m.Title = "모달 창띄우기";
            m.ShowDialog();
        }

        private void ModallessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModalless();
        }

        private void ShowModalless()
        {
            this.statusMessage.Text = "모달리스 창을 띄웁니다.";
            FormModalless f = new FormModalless();
            f.Title = "모달리스 창띄우기";
            f.Show();
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            ShowModalless();
        }

        private void 이프로그램은ModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은...(Modal)";
            FormAbout a = new FormAbout();
            a.Title = "이 프로그램은...(Modal)";
            a.ShowDialog();
        }

        private void 이프로그램은ModallessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은...(Modalless)";
            FormAbout a = new FormAbout();
            a.Title = "이 프로그램은...(Modalless)";
            a.Show();
        }
    }
}
