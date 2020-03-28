using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace collectWords3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShowWordsPage : ContentPage
	{
        public ShowWordsPage(IList<string> words)
        {
            InitializeComponent();
            string wordsStr = string.Join(", ", words);
            ShowLabel.Text = wordsStr;

            BackButton.Clicked += async (sender, args) =>
            {
                //MessageLabel.Text = "Words: " + string.Join(",", _words);
                // result.Name = "Anders";
                // https://xamarinhelp.com/passing-data-navigation-xamarin-forms/
                await Navigation.PopAsync();
            };
        }
    }
}