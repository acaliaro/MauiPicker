using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiPicker
{
	public partial class Outlet : ObservableObject
	{
		[ObservableProperty]
		public string name;
	}
}
