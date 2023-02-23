namespace ngaji_ustadzah.Views;

public partial class BacaanPage : ContentPage
{
	public BacaanPage()
	{
		InitializeComponent();
	}
    void OnScroll(Object sender, ScrolledEventArgs e)
    {
        ScrollView scroll = new ScrollView();
        scroll.Scrolled += OnScroll;
    }
}
