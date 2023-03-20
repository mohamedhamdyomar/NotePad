using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            openDig.Filter = "Text Files |*.txt| Rich Text |*.rft";

            saveDig.Filter = "Text Files |*.txt| Rich Text |*.rft";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDig.ShowDialog() == DialogResult.OK)
                txtInput.SelectionColor = colorDig.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(fontDig.ShowDialog() == DialogResult.OK)
                txtInput.SelectionFont = fontDig.Font;
                
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           if (openDig.ShowDialog() == DialogResult.OK)
                txtInput.LoadFile(openDig.FileName,RichTextBoxStreamType.PlainText);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveDig.ShowDialog() == DialogResult.OK)
                txtInput.SaveFile(saveDig.FileName, RichTextBoxStreamType.RichText);
        }

        private void openDig_FileOk(object sender, CancelEventArgs e)
        {

        }

        WriteForm wr = new WriteForm();

        private void btnMyDig_Click(object sender, EventArgs e)
        {
            wr.CusText = "Type Here";
            if(wr.ShowDialog() == DialogResult.OK)
                txtInput.AppendText(wr.CusText);
        }
    }
}
