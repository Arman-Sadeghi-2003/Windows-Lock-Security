using System.Collections.ObjectModel;
using System.Windows;

namespace WindowsLockSecurity.Settings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Keys { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            initializeProperties();
            DataContext = this;
        }

        private void initializeProperties()
        {
            for (char c = 'A'; c <= 'Z'; c++)
                Keys.Add(c.ToString());
            for (char c = '0'; c <= '0'; c++)
                Keys.Add(c.ToString());

        }
    }
}