using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace EventPulse_v1;

public partial class App : Application
{
	public App()
	{
		try
		{
			InitializeComponent();
		}
		catch (Exception ex)
		{
			// Show the error in the UI
			MainPage = new ContentPage
			{
				Content = new Label { Text = $"Error: {ex.Message}\n\n{ex.StackTrace}" }
			};
		}
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}