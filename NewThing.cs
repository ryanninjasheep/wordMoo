using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wordMoo
{
    public partial class NewThing : Form
    {
        public string Result = "";
        public NewThing()
        {
            InitializeComponent();
        }

        private void NameIt_Click(object sender, EventArgs e)
        {
            Result = ToName.Text.ToString();
            this.Close();
        }

        private void NewThing_Load(object sender, EventArgs e)
        {

        }
    }
}
