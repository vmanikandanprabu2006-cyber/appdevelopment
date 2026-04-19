using SampleProject.MVVM.ViewModel;

namespace SampleProject.MVVM.Views;

public partial class StudentRegistrationview : ContentPage
{
	public StudentRegistrationview(StudentRegistrationviewmodel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}