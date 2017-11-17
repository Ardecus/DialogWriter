using System.Collections.ObjectModel;

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
        public int skill { get; set; }
        public float skillmodchance { get; set; }
        public EStatAttribute attribute { get; set; }
        public float attributemodchance { get; set; }
        public string nextdialogsid { get; set; }
        public int nextdialogid { get; set; }
        public ObservableCollection<int> flags { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<TDialogAction> actions { get; set; } = new ObservableCollection<TDialogAction>();
    }
}
