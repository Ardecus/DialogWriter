using System.Collections.ObjectModel;

namespace DialogWriter
{
    public class TDialogNode
    {
        public static string begin = "struct.begin";
        public static string end = "struct.end";
        
        public int    id     { get; set; }
        public string sid    { get; set; }
        public string sound  { get; set; }
        public string image  { get; set; }
        public string textid { get; set; }
        public string text   { get; set; }

        public ObservableCollection<TDialogAction> actions  { get; set; } = new ObservableCollection<TDialogAction>();
        public ObservableCollection<TDialogBranch> branches { get; set; } = new ObservableCollection<TDialogBranch>();

        public static ObservableCollection<TDialogNode> dialognodes { get; set; } = new ObservableCollection<TDialogNode>();
    }
}
