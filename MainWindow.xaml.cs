using System.Windows;
using System.Windows.Media;
using MotorDashboard.Views;

namespace MotorDashboard
{
    public partial class MainWindow : Window
    {
        private readonly Brush _activeBrush = new SolidColorBrush(Color.FromRgb(0, 120, 215)); // #0078D7
        private readonly Brush _inactiveBrush = new SolidColorBrush(Color.FromRgb(51, 51, 51)); // #333333

        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Navigate(new RealTimePage());
            UpdateNavState(isRealTimeActive: true);
        }

        private void BtnRealTime_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new RealTimePage());
            UpdateNavState(isRealTimeActive: true);
        }

        private void BtnAnalytics_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AnalyticsPage());
            UpdateNavState(isRealTimeActive: false);
        }

        private void UpdateNavState(bool isRealTimeActive)
        {
            if (BtnRealTime == null || BtnAnalytics == null) return;

            BtnRealTime.Background = isRealTimeActive ? _activeBrush : _inactiveBrush;
            BtnAnalytics.Background = isRealTimeActive ? _inactiveBrush : _activeBrush;
        }
    }
}
