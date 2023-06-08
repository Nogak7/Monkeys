using Monkeys.ViewModels;

namespace Monkeys.View;

public partial class MonkeyView : ContentPage
{
	public MonkeyView(MonkeyViewModels vm)
	{
		BindingContext= vm;
		InitializeComponent();
	}
}