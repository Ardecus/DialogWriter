using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace DialogWriter
{
    public class TDialog : TDialogNode
    {
        public ObservableCollection<string> answers = new ObservableCollection<string>();

        public static ObservableCollection<TDialog> dialogs = new ObservableCollection<TDialog>();

        public TDialog()
        {
            id = dialogs.Count;
        }

        public static void SaveConfigToFile(string filepath, string name)
        {
            using (StreamWriter sw = new StreamWriter(File.OpenWrite(filepath)))
            {
                sw.Write(name);
                sw.Write(" : ");
                sw.WriteLine(begin);
                var sb = new StringBuilder();
                foreach(var dialog in dialogs)
                {
                    sw.Write("   [*] : ");
                    sw.WriteLine(begin);
                    sw.Write("      id = ");
                    sw.WriteLine(dialog.id);
                    sw.Write("      sid = ");
                    sw.WriteLine(dialog.sid);
                    sw.Write("      image = ");
                    sw.WriteLine(dialog.image);
                    sw.Write("      sound = ");
                    sw.WriteLine(dialog.sound);
                    sw.Write("      text = ");
                    sw.WriteLine(dialog.textid);
                    sw.Write("      onstartactions : ");
                    sw.WriteLine(begin);
                    foreach (var action in dialog.actions)
                        sw.WriteLine(action.ToString(9));
                    sw.Write("      ");
                    sw.WriteLine(end);
                    sw.Write("      onstartdialogbranches : ");
                    sw.WriteLine(begin);
                    foreach (var branch in dialog.branches)
                        sw.WriteLine(branch.ToString(9));
                    sw.Write("      ");
                    sw.WriteLine(end);
                    sw.Write("      answers : ");
                    sw.WriteLine(begin);
                    foreach (var answer in dialog.answers)
                    {
                        sw.Write("         [*] = ");
                        sw.WriteLine(answer);
                    }
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
                foreach (var dialog in dialogs)
                {
                    sw.Write("\t@");
                    sw.WriteLine(dialog.textid);
                    sw.WriteLine(dialog.text);
                }
            }
        }

        public static void SaveToFile(string filepath)
        {
            int delim = filepath.IndexOf('\\');
            string name = delim > 0 ? filepath.Substring(delim + 1) : filepath;
            SaveConfigToFile(filepath + "DialogPrototype.cfg", name);
            SaveTextToFile(filepath + "DialogText.cfg");
        }
    }
}
