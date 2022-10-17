using Notes.ViewModel;

namespace Notes
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage(DetailViewModel detailViewModel)
		{
			InitializeComponent();
			BindingContext = detailViewModel;
		}
	}
}