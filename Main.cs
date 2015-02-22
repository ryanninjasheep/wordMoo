using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace wordMoo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Main(string path)
        {
            InitializeComponent();
            string FileText = System.IO.File.ReadAllText(path);
            string[] FileData = Regex.Split(FileText, "\r\n==========\r\n");
            Data.Types.Clear();
            string[] NewTypes = FileData[0].Replace("\r", "").Split('\n');
            string[] Names = new string[NewTypes.Length];
            int temp = 0;
            WordType.DoNotOpen = true;
            foreach (string s in NewTypes)
            {
                Data.Types.Add(s, new WordType(s));
                Names[temp] = s;
                temp++;
            }
            WordType.DoNotOpen = false;
            for (int i = 0; i < FileData.Length - 1; i++)
            {
                string[] tempList = FileData[i + 1].Replace("\r", "").Split('\n');
                Data.Types[NewTypes[i]].Words = tempList.ToList<string>();
            }
            UpdateTypeList();
        }

        private void AddType_Click(object sender, EventArgs e)
        {
            NewThing ed = new NewThing();
            ed.ShowDialog(this);
            if (ed.Result != "")
            {
                Data.Types.Add(ed.Result, new WordType(ed.Result));
                UpdateTypeList();
            }
        }

        public void UpdateTypeList()
        {
            TypeList.Items.Clear();
            foreach(string s in Data.Types.Keys)
            {
                TypeList.Items.Add(s);
            }
        }

        private void OpenTest_Click(object sender, EventArgs e)
        {
            Test ed = new Test();
            ed.Show();
        }

        private void EditType_Click(object sender, EventArgs e)
        {
            string Selected = TypeList.SelectedItem.ToString();
            if (Data.Types.ContainsKey(Selected))
            {
                Data.Types[Selected].Open();
            }
        }

        private void DeleteType_Click(object sender, EventArgs e)
        {
            string Selected = TypeList.SelectedItem.ToString();
            if (Data.Types.ContainsKey(Selected))
            {
                Data.Types.Remove(Selected);
                UpdateTypeList();
            }
        }
        private void TypeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void OpenMoo()
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "WordMoo files (*.wmoo)|*.wmoo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string FileText = System.IO.File.ReadAllText(ofd.FileName);
                string[] FileData = Regex.Split(FileText, "\r\n==========\r\n");
                Data.Types.Clear();
                string[] NewTypes = FileData[0].Replace("\r", "").Split('\n');
                string[] Names = new string[NewTypes.Length];
                int temp = 0;
                WordType.DoNotOpen = true;
                foreach (string s in NewTypes)
                {
                    Data.Types.Add(s, new WordType(s));
                    Names[temp] = s;
                    temp++;
                }
                WordType.DoNotOpen = false;
                for (int i = 0; i < FileData.Length - 1; i++)
                {
                    string[] tempList = FileData[i + 1].Replace("\r", "").Split('\n');
                    Data.Types[NewTypes[i]].Words = tempList.ToList<string>();
                }
                UpdateTypeList();
            }
        }

        private void OpenThing_Click(object sender, EventArgs e)
        {
            OpenMoo();
        }

        private void SaveMoo()
        {
            List<string> toWrite = new List<string>();
            foreach(string s in Data.Types.Keys)
            {
                toWrite.Add(s);
            }
            toWrite.Add("==========");
            foreach(WordType w in Data.Types.Values)
            {
                foreach(string s in w.Words)
                {
                    toWrite.Add(s);
                }
                toWrite.Add("==========");
            }
            toWrite.RemoveAt(toWrite.Count - 1);
            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.Filter = "WordMoo files (*.wmoo)|*.wmoo";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, string.Join("\r\n", toWrite.ToArray()));
            }
        }

        private void SaveThings_Click(object sender, EventArgs e)
        {
            SaveMoo();
        }

        private void CopyType_Click(object sender, EventArgs e)
        {
            NewThing ed = new NewThing();
            ed.ShowDialog(this);
            if (ed.Result != "")
            {
                Data.Types.Add(ed.Result, new WordType(ed.Result, Data.Types[TypeList.SelectedItem.ToString()].Words));
                UpdateTypeList();
            }
        }
    }
}
