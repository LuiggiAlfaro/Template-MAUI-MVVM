using Timer.UI.ViewModels;

namespace Timer.UI.Views
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
            this.BindingContext = new MainViewModel();
        }
  }

}
