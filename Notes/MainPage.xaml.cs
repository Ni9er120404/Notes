using Notes.ViewModel;

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