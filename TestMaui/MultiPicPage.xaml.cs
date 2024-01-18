using TestMaui.ViewModel;
using TestMaui.Models;

namespace TestMaui;

public partial class MultiPicPage : ContentPage
{
	public MultiPicPageVM vm = new MultiPicPageVM();
	public MultiPicPage()
	{
		InitializeComponent();
		BindingContext = vm;
	}
	private void AddElement(MultiPic item)
	{
		vm.AddElement(item);
	}
	public void AddButtonClicked(object sender, EventArgs e)
	{
		Console.WriteLine("[MultiPicPage][AddButton][Pressed]");

		Pic p = new Pic();
		MultiPic mp = new MultiPic(p);

        AddElement(mp);
        Console.WriteLine("[MultiPicPage][AddButton][Added]");
    }
}