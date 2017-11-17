using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DialogWriter
{
    public enum EStatAttribute
    {
        None,
        ST,
        DX,
        IQ,
        HT,
        HP,
        PE,
        WP,
        FP,
        MP,
        GetCount
    }

    public class TDialogBranch
    {
        public float basechance { get; set; }
        public string skill { get; set; }
        public float skillmodchance { get; set; }
        public EStatAttribute attribute { get; set; }
        public float attributemodchance { get; set; }
        public string nextdialogsid { get; set; }
        public int newflag { get; set; }
        public ObservableCollection<int> flags { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<TDialogAction> actions { get; set; } = new ObservableCollection<TDialogAction>();

        public string ToString(int spaces)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(' ', spaces);
            sb.Append("basechance = ");
            sb.AppendLine(basechance.ToString());
            sb.Append(' ', spaces);
            sb.Append("skill = ");
            sb.AppendLine(skill);
            sb.Append(' ', spaces);
            sb.Append("skillmodchance = ");
            sb.AppendLine(skillmodchance.ToString());
            sb.Append(' ', spaces);
            sb.Append("actionid = EStatAttribute.");
            sb.AppendLine(Enum.GetName(typeof(EStatAttribute), attribute));
            sb.Append(' ', spaces);
            sb.Append("attributemodchance = ");
            sb.AppendLine(attributemodchance.ToString());
            sb.Append(' ', spaces);
            sb.Append("nextdialogsid = ");
            sb.AppendLine(nextdialogsid);
            sb.Append(' ', spaces);
            sb.Append("flags : ");
            sb.AppendLine(TDialogNode.begin);
            foreach (var flag in flags)
            {
                sb.Append(' ', spaces + 3);
                sb.Append("[*] = ");
                sb.AppendLine(flag.ToString());
            }
            sb.Append(' ', spaces);
            sb.AppendLine(TDialogNode.end);
            sb.Append(' ', spaces);
            sb.Append("actions : ");
            sb.AppendLine(TDialogNode.begin);
            foreach (var action in actions)
                sb.AppendLine(action.ToString(spaces + 3));
            sb.Append(' ', spaces);
            sb.Append(TDialogNode.end);
            return sb.ToString();
        }
    }
}
