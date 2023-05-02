using CommunityToolkit.Maui.Views;

namespace MauiPicker;

public partial class MyPopupPage : Popup
{
	public MyPopupPage()
	{
		InitializeComponent();
		this.BindingContext = new MyPopupViewModel();
	}

    private void Border_SizeChanged(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Border_SizeChanged width=" + ((Border)sender).Width + " height=" + ((Border)sender).Height);

        double height = ((Border)sender).Height;
        var maxWidth = DeviceDisplay.MainDisplayInfo.Width; // / DeviceDisplay.MainDisplayInfo.Density), 0.6 * (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density));
        var maxHeight = DeviceDisplay.MainDisplayInfo.Height;
        var density = DeviceDisplay.MainDisplayInfo.Density;
        System.Diagnostics.Debug.WriteLine("Border_SizeChanged maxWidth=" + maxWidth + " maxHeight=" + maxHeight + " density=" + density);

        if (((Border)sender).Height > maxHeight / density)
            height = (maxHeight / density) - 100;

        height = (int)height;
        Size = new Size(0.6 * (DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density), height + 20);

    }
}