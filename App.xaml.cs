namespace mob_equipmentApp
{
    public partial class App : Application
    {
        public static ViewModels.EquipmentListViewModel MainViewModel { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            MainViewModel = new ViewModels.EquipmentListViewModel();

            InitializeAsync();

        }

        private async void InitializeAsync()
        {
            await MainViewModel.RefreshEquipment();
        }
    }
}
