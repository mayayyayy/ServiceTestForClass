
using ServiceTest.ViewModels;

namespace ServiceTest.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainPageViewModel vm)
	{
		this.BindingContext = vm;
		InitializeComponent();
	}

}

