using System;
using System.Text;

namespace DialogWriter
{
    public enum EDialogAction
    {
        None,
        Gold,
        Exp,
        SkillPoints,
        Alignment,
        AddItem,
        RemoveItem,
        ActivateUsableByStringTag,
        GetCount
    }

    public class TDialogAction
    {
        public EDialogAction action { get; set; }
        public int    param1  { get; set; }
        public int    param2  { get; set; }
        public int    param3  { get; set; }
        public int    param4  { get; set; }
        public string sparam1 { get; set; } = string.Empty;
        public string sparam2 { get; set; } = string.Empty;
        public string sparam3 { get; set; } = string.Empty;
        public string sparam4 { get; set; } = string.Empty;

        public string ToString(int spaces)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(' ', spaces);
            sb.Append("actionid = EDialogAction.");
            sb.AppendLine(Enum.GetName(typeof(EDialogAction), action));
            sb.Append(' ', spaces);
            sb.Append("param1 = ");
            sb.AppendLine(param1.ToString());
            sb.Append(' ', spaces);
            sb.Append("param2 = ");
            sb.AppendLine(param2.ToString());
            sb.Append(' ', spaces);
            sb.Append("sparam1 = ");
            sb.AppendLine(sparam1.ToString());
            sb.Append(' ', spaces);
            sb.Append("sparam2 = ");
            sb.Append(sparam2.ToString());
            return sb.ToString();
        }
    }
}
