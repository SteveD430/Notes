using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        private string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(_filename))
            {
                editor.Text = File.ReadAllText(_filename);
            }
        }

        private void OnSaveButtonClicked(object sender, System.EventArgs args)
        {
            File.WriteAllText(_filename, editor.Text);
        }

        private void OnDeleteButtonClicked(object sender, System.EventArgs args)
        {
            if (File.Exists(_filename))
            {
                File.Delete(_filename);
            }
            editor.Text = String.Empty;
        }

    }
}
