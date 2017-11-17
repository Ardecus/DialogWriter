using System.Collections.ObjectModel;

namespace DialogWriter
{
    public class TDialogNode
    {
        public int id { get; set; }
        public string sid { get; set; }
        public string sound { get; set; }
        public string textid { get; set; }
        public string text { get; set; }

        public ObservableCollection<TDialogAction> actions { get; set; } = new ObservableCollection<TDialogAction>();
        public ObservableCollection<TDialogBranch> branches { get; set; } = new ObservableCollection<TDialogBranch>();

        public static ObservableCollection<TDialogNode> dialognodes { get; set; } = new ObservableCollection<TDialogNode>();
    }
}
