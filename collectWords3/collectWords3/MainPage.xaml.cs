using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace collectWords3
{
    public partial class MainPage : ContentPage
    {
        private readonly IList<string> _words = new List<string>();
        //private readonly Result _result = new Result("my name");

        public MainPage()
        {
            InitializeComponent();
            MessageLabel.Text = "my message";

            ButtonAdd.Clicked += (sender, args) =>
            {
                _words.Add(WordTextInput.Text);
            };

            ButtonClear.Clicked += (sender, args) =>
            {
                _words.Clear();
            };

            ButtonShow.Clicked += async (sender, args) =>
            {
                MessageLabel.Text = "Words: " + string.Join(",", _words);
                // https://xamarinhelp.com/passing-data-navigation-xamarin-forms/
                // MessageLabel.Text = _result.Name;

                ShowWordsPage showPage = new ShowWordsPage(_words/*, _result*/);
                await Navigation.PushAsync(showPage);
                //MessageLabel.Text = _result.Name;
                //MessageLabel.Text = showPage.GetName();       
            };
        }
    }
}
