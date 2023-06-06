using Monkeys.ViewModels;

namespace Monkeys.View;

public partial class MonkeyView : ContentView
{
	public MonkeyView(MonkeyViewModels vm)
	{
		BindingContext= vm;
		InitializeComponent();
	}
}