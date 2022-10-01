using System.Globalization;

namespace cultureinfo_bug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

        //if (count == 1)
        //	CounterBtn.Text = $"Clicked {count} time";
        //else
        //	CounterBtn.Text = $"Clicked {count} times";

        //
        // This will yield the wrong datetime for Norwegian culture info.
        // This has only been tested wrong on iOS 15.4. 
        // It works on Android and Windows.
        //
        // dotnet --version gives me: 6.0.401
        //
        // It should be: 01.10.2022 16:00:28
        // But it is: 10/1/2022 4:00:28 PM
        // (date and time is example only)
        //
        CounterBtn.Text = DateTime.Now.ToString(new CultureInfo("nb-NO"));

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

