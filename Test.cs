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
    public partial class Test : Form
    {
        Dictionary<string, string> Saved = new Dictionary<string, string>();
        static Random rand = new Random();
        bool lastIteration;

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            if(InputText.Text != OutputText.Text)
            {
                lastIteration = true;
                UpdateOutput();
            }
        }

        private void UpdateOut_Click(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        public void UpdateOutput()
        {
            string temp = InputText.Text;
            if(IterateBox.Checked && !lastIteration)
            {
                temp = OutputText.Text;
            }
            List<string> Input = temp.Split(' ').ToList<string>();
            string Output = Compile(Input, true, IterateBox.Checked);

            if(lastIteration)
            {
                while (Output.Contains("  ")) Output = Output.Replace("  ", " ");
                Output = Output.Replace(" ~ ", "");
                Output = Output.Replace(" @ ", "\r\n");
            }
            OutputText.Text = Output;
        }

        public string Compile(List<string> Input, bool isFirst, bool isIterate)
        {
            lastIteration = true;
            if(isFirst == true)
            {
                Saved.Clear();
            }
            string Output = "";
            foreach (string str in Input)
            {
                if (Data.Types.ContainsKey(str))
                {
                    lastIteration = false;
                    int rnd = rand.Next(Data.Types[str].Words.Count);
                    if(!isIterate)
                    {
                        Output += Compile(Data.Types[str].Words[rnd].Split(' ').ToList<string>(), false, false) + " ";
                    }
                    else
                    {
                        Output += Data.Types[str].Words[rnd] + " ";
                    }
                }
                else if (str.Length > 1 && str[0] == '[' && str[str.Length - 1] == ']')
                {
                    if (Saved.ContainsKey(str))
                    {
                        Output += Saved[str] + " ";
                    }
                    else
                    {
                        Output += str + " ";
                    }
                }
                else if (str.Contains("[") && str.Contains("]"))
                {
                    if (Data.Types.ContainsKey(str.Substring(0, str.IndexOf("["))))
                    {
                        int rnd = rand.Next(Data.Types[str.Substring(0, str.IndexOf("["))].Words.Count);
                        string Temp = Compile(Data.Types[str.Substring(0, str.IndexOf("["))].Words[rnd].Split(' ').ToList<string>(), false, false);
                        string Key = str.Substring(str.LastIndexOf('['));
                        try
                        {
                            Saved.Add(Key, Temp);
                        }
                        catch
                        {
                            Saved[Key] = Temp;
                        }
                    }
                }
                else if(str == "...")
                {

                }
                else
                {
                    Output += str + " ";
                }
            }
            return Output;
        }
    }
}