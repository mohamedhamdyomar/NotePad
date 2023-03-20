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
    public partial class WriteForm : Form
    {
        public WriteForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.AcceptButton = okbtn;

            
        }


        public string CusText
        {
            get => this.txt.Text;
            set => this.txt.Text = value;
        }
    }


}
