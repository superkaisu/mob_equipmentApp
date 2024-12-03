namespace mob_equipmentApp
{
    public partial class App : Application
    {
        public static ViewModels.EquipmentListViewModel MainViewModel { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            MainViewModel = new();
            MainViewModel.RefreshEquipment();

        }
    }
}
