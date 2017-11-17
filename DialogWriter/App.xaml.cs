using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace DialogWriter
{
    public partial class App : Application
    {
        public static Style normaltext;
        public static Style errortext;

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
