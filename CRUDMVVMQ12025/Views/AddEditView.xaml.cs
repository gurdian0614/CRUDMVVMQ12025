using CRUDMVVMQ12025.Models;
using CRUDMVVMQ12025.ViewModels;

namespace CRUDMVVMQ12025.Views;

public partial class AddEditView : ContentPage
{
	private AddEditViewModel viewModel;
	public AddEditView()
	{
		InitializeComponent();
		viewModel = new AddEditViewModel();
		this.BindingContext = viewModel;
	}

	public AddEditView(Empleado Empleado)
	{
		InitializeComponent();
		viewModel = new AddEditViewModel(Empleado);
		this.BindingContext = viewModel;
	}
}