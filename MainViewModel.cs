using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MauiPicker
{
	public partial class MainViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {

		[ObservableProperty]
		Outlet selectedItemOutlet;

		public MainViewModel()
		{
			LoadResults();
		}

		[RelayCommand]
		async Task LoadResults()
		{

			Outlets = new ObservableRangeCollection<Outlet>
			{
				new Outlet(){Name="Outlet0"},
				new Outlet(){Name="Outlet1"},
				new Outlet(){Name="Outlet2"},

			};

			SelectedItemOutlet = Outlets[1];

			PartAResultLists = new ObservableRangeCollection<PartAResultList>
			{
				new PartAResultList(){OutletIndex = 0, OutletName= new Outlet(){Name="Outlet0" } },
				new PartAResultList(){OutletIndex=1, OutletName= new Outlet(){Name="Outlet1" }},
				new PartAResultList(){OutletIndex = 2, OutletName= new Outlet(){Name="Outlet2" }},
				new PartAResultList(){OutletIndex = 0, OutletName= new Outlet(){Name="Outlet0" }},
				new PartAResultList(){OutletIndex = 2, OutletName= new Outlet(){Name="Outlet2" }}
			};
		}

        partial void OnSelectedItemOutletChanged(Outlet value)
        {
			if(value != null)
				System.Diagnostics.Debug.WriteLine(value.Name, "OnSelectedItemOutletChanged");
			else
                System.Diagnostics.Debug.WriteLine("value = null", "OnSelectedItemOutletChanged");

        }


        [ObservableProperty]
		ObservableRangeCollection<Outlet> outlets;

		[ObservableProperty]
		ObservableRangeCollection<PartAResultList> partAResultLists;
        [RelayCommand]
        async Task OpenPopupAsync()
		{
            var popup = new MyPopupPage();
            var ret = await Application.Current.MainPage.ShowPopupAsync(popup);

        }

    }
}
