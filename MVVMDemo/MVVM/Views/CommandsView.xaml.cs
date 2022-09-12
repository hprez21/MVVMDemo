using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		  BindingContext = new CommandsViewModel();
	}

  
}