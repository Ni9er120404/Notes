using Notes.ViewModel;
using System.Text;

namespace Notes
{
	public partial class MainPage : ContentPage
	{
		public MainPage(MainViewModel mainViewModel)
		{
			InitializeComponent();
			BindingContext = mainViewModel;
		}
	}
}