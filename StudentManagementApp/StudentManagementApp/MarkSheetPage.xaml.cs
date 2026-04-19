namespace StudentManagementApp;

public partial class MarkSheetPage : ContentPage
{
	public MarkSheetPage()
	{
		InitializeComponent();
	}

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        int math = int.Parse(txtMath.Text);
        int science = int.Parse(txtScience.Text);
        int english = int.Parse(txtEnglish.Text);

        int total = math + science + english;
        double average = total / 3.0;

        lblResult.Text = $"Total: {total} \nAverage: {average}";
    }
}