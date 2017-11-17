using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DialogWriter
{
    public partial class App : Application
    {
        public static Style normaltext;
        public static Style errortext;

        public static Dictionary<EDialogAction, string> actionoptions { get; set; } = new Dictionary<EDialogAction, string>(){

            {EDialogAction.Gold, "Gold"},
            {EDialogAction.Exp, "Exp"},
            {EDialogAction.SkillPoints, "SkillPoints"},
            {EDialogAction.Alignment, "Alignment"},
            {EDialogAction.AddItem, "AddItem"},
            {EDialogAction.RemoveItem, "RemoveItem"},
            {EDialogAction.ActivateUsableByStringTag, "ActivateUsableByStringTag"}
        };

        public static Dictionary<EStatAttribute, string> attributeoptions { get; set; } = new Dictionary<EStatAttribute, string>(){

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

        private void Validate(object sender, TextChangedEventArgs e)
        {
            var s = (TextBox)sender;
            try
            {
                int id = int.Parse(s.Text);
                s.Style = normaltext;
            }
            catch
            {
                s.Style = errortext;
            }
        }

        private void ValidateFloat(object sender, TextChangedEventArgs e)
        {
            var s = (TextBox)sender;
            try
            {
                float val = float.Parse(s.Text);
                s.Style = normaltext;
            }
            catch
            {
                s.Style = errortext;
            }
        }

        private void AddAction(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.DataContext is TDialog)
                ((TDialog)button.DataContext).actions.Add(new TDialogAction());
            else
                ((TAnswer)button.DataContext).actions.Add(new TDialogAction());
        }

        private void AddBranch(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.DataContext is TDialog)
                ((TDialog)button.DataContext).branches.Add(new TDialogBranch());
            else
                ((TAnswer)button.DataContext).branches.Add(new TDialogBranch());
        }

        private void AddBranchAction(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var branch = button.DataContext as TDialogBranch;
            branch.actions.Add(new TDialogAction());
        }

        private void AddFlag(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var branch = button.DataContext as TDialogBranch;
            branch.flags.Add(branch.newflag);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class ListDataTemplateSelector : DataTemplateSelector
    {
        public static DataTemplate dialogtemplate;
        public static DataTemplate answertemplate;

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            return item is TDialog ? dialogtemplate : answertemplate;
        }
    }
}
