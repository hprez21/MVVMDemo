using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
		  BindingContext = new ConvertersViewModel();
	}
}