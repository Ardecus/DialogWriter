using System.Collections.ObjectModel;

namespace DialogWriter
{
    public class TDialog : TDialogNode
    {
        public string image { get; set; }

        public static ObservableCollection<TDialog> dialogs = new ObservableCollection<TDialog>();

        public TDialog()
        {
            id = dialogs.Count;
        }
    }
}
