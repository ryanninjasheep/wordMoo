using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wordMoo
{
    public class Data
    {
        public static Dictionary<string, WordType> Types = new Dictionary<string, WordType>();
        public void AddWordType(string ToAdd)
        {
            Data.Types.Add(ToAdd, new WordType(ToAdd));
        }
    }
    public class WordType
    {
        public static Boolean DoNotOpen;
        public List<string> Words = new List<string>();
        public Edit EditWindow = null;
        public string WordTypeName = "";
        public WordType(string doodah)
        {
            WordTypeName = doodah;
            Open();
        }
        public WordType(string doodah, List<string> WordList)
        {
            WordTypeName = doodah;
            Words = WordList;
            Open();
        }
        public void Open()
        {
            if(DoNotOpen == false)
            {
                EditWindow = new Edit(this);
                EditWindow.Show();
            }
        }
    }
}
