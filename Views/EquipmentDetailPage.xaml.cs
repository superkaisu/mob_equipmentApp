namespace mob_equipmentApp.Views;

public partial class EquipmentDetailPage : ContentPage
{
	public EquipmentDetailPage()
	{
		InitializeComponent();

        BindingContext = App.MainViewModel.SelectedEquipment;
    }
}