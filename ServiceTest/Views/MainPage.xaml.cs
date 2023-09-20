
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

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

