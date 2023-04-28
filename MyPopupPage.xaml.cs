using CommunityToolkit.Maui.Views;

namespace MauiPicker;

public partial class MyPopupPage : Popup
{
	public MyPopupPage()
	{
		InitializeComponent();
		this.BindingContext = new MyPopupViewModel();
	}
}