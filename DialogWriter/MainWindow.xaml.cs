using System.IO;
using System.Windows;

namespace DialogWriter
{
    public partial class MainWindow : Window
    {
        string lastpath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            dialogslist.ItemsSource = TDialogNode.dialognodes;
            App.normaltext = FindResource("NormalText") as Style;
            App.errortext = FindResource("ErrorText") as Style;
            ListDataTemplateSelector.dialogtemplate = FindResource("DialogTemplate") as DataTemplate;
            ListDataTemplateSelector.answertemplate = FindResource("AnswerTemplate") as DataTemplate;
        }

        private void AddDialog(object sender, RoutedEventArgs e)
        {
            var dialog = new TDialog();
            TDialogNode.dialognodes.Add(dialog);
            TDialog.dialogs.Add(dialog);
        }

        private void AddAnswer(object sender, RoutedEventArgs e)
        {
            var answer = new TAnswer();
            TDialogNode.dialognodes.Add(answer);
            TAnswer.answers.Add(answer);
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (filename.Text==string.Empty||!Directory.Exists(filename.Text.Substring(0, filename.Text.LastIndexOf('\\'))))
                MessageBox.Show("File name is not valid!");
            TDialog.SaveToFile(filename.Text);
            TAnswer.SaveToFile(filename.Text);

            MessageBox.Show("Saved!");
        }

        private void Load(object sender, RoutedEventArgs e)
        {
        }
    }
}
