namespace TestMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            MultiPicPage mpp = new MultiPicPage();
            App.Current.MainPage.Navigation.PushAsync(mpp);
        }
    }
}