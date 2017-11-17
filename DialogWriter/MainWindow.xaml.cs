using System.Collections.Generic;
using System.Windows;

namespace DialogWriter
{
    public partial class MainWindow : Window
    {
        public Dictionary<EDialogAction, string> actions { get; set; } = new Dictionary<EDialogAction, string>(){

            {EDialogAction.Gold, "Gold"},
            {EDialogAction.Exp, "Exp"},
            {EDialogAction.SkillPoints, "SkillPoints"},
            {EDialogAction.Alignment, "Alignment"},
            {EDialogAction.AddItem, "AddItem"},
            {EDialogAction.RemoveItem, "RemoveItem"},
            {EDialogAction.ActivateUsableByStringTag, "ActivateUsableByStringTag"}
        };

        public Dictionary<EStatAttribute, string> attributes { get; set; } = new Dictionary<EStatAttribute, string>(){

            {EStatAttribute.ST, "ST"},
            {EStatAttribute.DX, "DX"},
            {EStatAttribute.IQ, "IQ"},
            {EStatAttribute.HT, "HT"},
            {EStatAttribute.HP, "HP"},
            {EStatAttribute.PE, "PE"},
            {EStatAttribute.WP, "WP"},
            {EStatAttribute.FP, "FP"},
            {EStatAttribute.MP, "MP"}
        };
        
        public MainWindow()
        {
            InitializeComponent();
            dialogslist.ItemsSource = TDialogNode.dialognodes;
            App.normaltext = FindResource("NormalText") as Style;
            App.errortext = FindResource("ErrorText") as Style;
        }

        private void AddDialog(object sender, RoutedEventArgs e)
        {
            var dialog = new TDialog();
            TDialogNode.dialognodes.Add(dialog);
            TDialog.dialogs.Add(dialog);
        }

        private void AddAnswer(object sender, RoutedEventArgs e)
        {
            TDialogNode.dialognodes.Add(new TAnswer());

            var answer = new TAnswer();
            TDialogNode.dialognodes.Add(answer);
            TAnswer.answers.Add(answer);
        }
    }
}
