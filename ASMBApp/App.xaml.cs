using CommunityToolkit.Mvvm.DependencyInjection;
using Magic.MAUI;

namespace ASMBApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new login();
            MainPage = new AppShell();


        }

        public void ConfigureServices()
        {
            Ioc.Default.ConfigureServices(
                    new ServiceCollection()
                    .AddSingleton<ViewModels.MyWallet>() //Services
                    .AddSingleton<IDataProvider<Models.Account>,DataPravider.AccountDatapravider>()
                    .AddSingleton<ViewModels.AccountViewModels>()
                    //.AddSingleton<IFilesService, FilesService>()
                    //.AddSingleton<ISettingsService, SettingsService>()
                    //.AddSingleton(RestService.For<IRedditService>("https://www.reddit.com/"))
                    //.AddSingleton(RestService.For<IContactsService>("https://randomuser.me/"))
                    //.AddTransient<PostWidgetViewModel>() //ViewModels
                    //.AddTransient<SubredditWidgetViewModel>()
                    //.AddTransient<ContactsListWidgetViewModel>()
                    //.AddTransient<AsyncRelayCommandPageViewModel>()
                    //.AddTransient<IocPageViewModel>()
                    //.AddTransient<MessengerPageViewModel>()
                    //.AddTransient<ObservableObjectPageViewModel>()
                    //.AddTransient<ObservableValidatorPageViewModel>()
                    //.AddTransient<ValidationFormWidgetViewModel>()
                    //.AddTransient<RelayCommandPageViewModel>()
                    //.AddTransient<CollectionsPageViewModel>()
                    //.AddTransient<SamplePageViewModel>()
                    .BuildServiceProvider());

        }
        /// <inheritdoc/>

        //protected async override void OnStart()
        //{
        //    base.OnStart();
        //    ASMBApp.Views.Pwd pwd = new ASMBApp.Views.Pwd(true);
        //    //pwd.ac
        //    string paswd = (string)(await this.ShowPopupAsync(pwd));


        //    if (ASMBApp.ViewModels.MyWallet.GetWallet(paswd) == null)
        //    {
        //       // await DisplayAlert("", "钱包密码错误", "确定");
        //    }
        //}

    }
}