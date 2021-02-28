using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
	public partial class MainWindow : Window
	{
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			WpfApp1.Funcs f = new Funcs();
			ResultBox.Content = "Ответ :";
			string arrayString = EntryBox.Text;
			int[] nums = f.getNumsArray(arrayString);
			if (nums == null) {
				ResultBox.Content = ResultBox.Content + " Числа введены неверно!";
			} else {
				EntryBox.Text = string.Join(" ", nums);
				int count = f.countCondNums(nums);
				if (count != 0) ResultBox.Content = ResultBox.Content + " " + count.ToString();
				else ResultBox.Content = ResultBox.Content + " Нет чисел, удовлетворяющих заданию";
			}
		}

		private void EntryBox_GotFocus(object sender, RoutedEventArgs e) {
			if (EntryBox.Text == "Поле ввода") {
				EntryBox.Text = "";
				EntryBox.Foreground = new SolidColorBrush(Color.FromRgb(0x0, 0x0, 0x0));
			}
		}

		private void EntryBox_LostFocus(object sender, RoutedEventArgs e) {
			if (EntryBox.Text == "") { 
				EntryBox.Text = "Поле ввода";
				EntryBox.Foreground = new SolidColorBrush(Color.FromRgb(0x97, 0x97, 0x87));
			}
		}
	}
}