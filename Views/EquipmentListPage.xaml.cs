namespace mob_equipmentApp.Views;

public partial class EquipmentListPage : ContentPage
{
	public EquipmentListPage()
	{
		InitializeComponent();       
    }

	private async void ListView_EquipmentTapped(object sender, ItemTappedEventArgs e)
    {
        await Navigation.PushAsync(new Views.EquipmentDetailPage());
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        MenuItem menuItem = (MenuItem)sender;
        ViewModels.EquipmentViewModel equipment = (ViewModels.EquipmentViewModel)menuItem.BindingContext;
        App.MainViewModel.DeleteEquipment(equipment);
    }

    private async void Button_AddEquipmentClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.AddEquipmentPage());
    }

}