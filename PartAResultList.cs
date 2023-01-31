using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiPicker
{
	public partial class PartAResultList : ObservableObject
	{

        [ObservableProperty]
		public Outlet outletName;

		[ObservableProperty]
		public int outletIndex;

	}
}