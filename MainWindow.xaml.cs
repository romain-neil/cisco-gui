using System.Windows;
using CiscoGui.util;

namespace CiscoGui
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		private Router _router;
		
		public MainWindow()
		{
			InitializeComponent();

			_router = new Router();

			Title = "";
		}
	}
}