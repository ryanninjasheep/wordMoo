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
    public partial class Edit : Form
    {
        WordType Type = null;
        public Edit(WordType w)
        {
            InitializeComponent();
            Type = w;
            this.Text = Type.WordTypeName;
        }

        private void KeyText_TextChanged(object sender, EventArgs e)
        {
            string x = KeyText.Text;
            x = x.Replace("\r","");
            Type.Words = x.Split('\n').ToList<string>();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            KeyText.Text = string.Join("\r\n", Type.Words.ToArray<string>());
        }
    }
}
