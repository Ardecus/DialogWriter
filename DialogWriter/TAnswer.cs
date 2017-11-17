using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace DialogWriter
{
    public class TAnswer : TDialogNode
    {
        public string reqskillsid       { get; set; }
        public int    reqskillvalue     { get; set; }
        public string reqattributesid   { get; set; }
        public int    reqattributevalue { get; set; }
        public string naxtdialogsid     { get; set; }

        public static ObservableCollection<TAnswer> answers = new ObservableCollection<TAnswer>();

        public TAnswer()
        {
            id = answers.Count;
        }


        public static void SaveConfigToFile(string filepath, string name)
        {
            using (StreamWriter sw = new StreamWriter(File.OpenWrite(filepath)))
            {
                sw.Write(name);
                sw.WriteLine(begin);
                var sb = new StringBuilder();
                foreach (var answer in answers)
                {
                    sw.Write("   [*] : ");
                    sw.WriteLine(begin);
                    sw.Write("      id = ");
                    sw.WriteLine(answer.id);
                    sw.Write("      sid = ");
                    sw.WriteLine(answer.sid);
                    sw.Write("      image = ");
                    sw.WriteLine(answer.image);
                    sw.Write("      sound = ");
                    sw.WriteLine(answer.sound);
                    sw.Write("      text = ");
                    sw.WriteLine(answer.textid);
                    sw.Write("      reqskillsid = ");
                    sw.WriteLine(answer.reqskillsid);
                    sw.Write("      reqskillvalue = ");
                    sw.WriteLine(answer.reqskillvalue);
                    sw.Write("      reqattributesid = ");
                    sw.WriteLine(answer.reqattributesid);
                    sw.Write("      reqattributevalue = ");
                    sw.WriteLine(answer.reqattributevalue);
                    sw.Write("      naxtdialogsid = ");
                    sw.WriteLine(answer.naxtdialogsid);
                    sw.Write("      actions : ");
                    sw.WriteLine(begin);
                    foreach (var action in answer.actions)
                        sw.WriteLine(action.ToString(9));
                    sw.Write("      ");
                    sw.WriteLine(end);
                    sw.Write("      dialogbranches : ");
                    sw.WriteLine(begin);
                    foreach (var branch in answer.branches)
                        sw.WriteLine(branch.ToString(9));
                    sw.Write("      ");
                    sw.WriteLine(end);
                    sw.Write("   ");
                    sw.WriteLine(end);
                }
                sw.WriteLine(end);
            }
        }

        public static void SaveTextToFile(string filepath)
        {
            using (StreamWriter sw = new StreamWriter(File.OpenWrite(filepath)))
            {
                foreach (var answer in answers)
                {
                    sw.Write("\t@");
                    sw.WriteLine(answer.textid);
                    sw.WriteLine(answer.text);
                }
            }
        }

        public static void SaveToFile(string filepath)
        {
            int delim = filepath.IndexOf('\\');
            string name = delim > 0 ? filepath.Substring(delim) : filepath;
            SaveConfigToFile(filepath + "AnswerPrototype.cfg", name);
            SaveTextToFile(filepath + "AnswerText.cfg");
        }
    }
}
