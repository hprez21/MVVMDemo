using MVVMDemo.MVVM.Models;
using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		  
		  BindingContext = new PersonViewModel();
	}
}