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
        public int param1 { get; set; }
        public int param2 { get; set; }
        public int param3 { get; set; }
        public int param4 { get; set; }
        public string sparam1 { get; set; }
        public string sparam2 { get; set; }
        public string sparam3 { get; set; }
        public string sparam4 { get; set; }
    }
}
