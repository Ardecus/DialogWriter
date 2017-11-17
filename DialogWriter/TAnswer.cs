using System.Collections.ObjectModel;

namespace DialogWriter
{
    public class TAnswer : TDialogNode
    {
        public string hintid { get; set; }
        public string hint { get; set; }
        public string reqskillsid { get; set; }
        public string reqskillvalue { get; set; }
        public string reqattributesid { get; set; }
        public string reqattributevalue { get; set; }
        public string naxtdialogsid { get; set; }

        public static ObservableCollection<TAnswer> answers = new ObservableCollection<TAnswer>();

        public TAnswer()
        {
            id = answers.Count;
        }
    }
}
