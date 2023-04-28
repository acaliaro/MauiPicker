using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;

namespace MauiPicker
{
    public partial class MyPopupViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        public MyPopupViewModel()
        {
            LoadResults();
        }

        [ObservableProperty]
        Outlet selectedItemOutlet;

        [ObservableProperty]
        ObservableRangeCollection<Outlet> outlets;

        [ObservableProperty]
        ObservableRangeCollection<PartAResultList> partAResultLists;

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
            if (value != null)
                System.Diagnostics.Debug.WriteLine(value.Name, "OnSelectedItemOutletChanged");
            else
                System.Diagnostics.Debug.WriteLine("value = null", "OnSelectedItemOutletChanged");

        }


    }
}