using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp6 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        DispatcherTimer timer;
        Ball ball;
        public MainWindow() {
            InitializeComponent();
            ball = new(10,10,MainCanvas);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(16);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e) {
            if (ball.X < 0) {
                //Punkty Myszka
            }
            if (ball.X > 800) {
                //Punkty Klawiatura
            }
            ball.Move();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e) {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e) {

        }
    }
}