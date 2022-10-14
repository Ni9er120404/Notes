using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

namespace Notes.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		public MainViewModel()
		{
			Items = new ObservableCollection<string>();
		}

		[ObservableProperty]
		private ObservableCollection<string> _items;

		[ObservableProperty]
		private string text;

		[RelayCommand]
		private void Add()
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			Items.Add(text);
			Text = string.Empty;
		}

		[RelayCommand]
		private void Delete(string s)
		{
			if (Items.Contains(s))
			{
				Items.Remove(s);
			}
		}
		
	}
}