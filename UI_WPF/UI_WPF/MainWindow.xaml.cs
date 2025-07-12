using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace UI_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            load_chart();
        }

        private void load_chart()
        {
            chart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 10),
                        new ObservablePoint(2, 7),
                        new ObservablePoint(5, 8),
                        new ObservablePoint(6, 6),
                        new ObservablePoint(7, 14),
                        new ObservablePoint(10, 7),
                        new ObservablePoint(12, 8),
                        new ObservablePoint(14, 6),
                    },
                    PointGeometrySize = 15
                }
            };

            chart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 10),
                        new ObservablePoint(2, 7),
                        new ObservablePoint(5, 8),
                        new ObservablePoint(7, 6),
                        new ObservablePoint(8, 14),
                        new ObservablePoint(9, 8),
                        new ObservablePoint(11, 6),
                        new ObservablePoint(15, 14)
                    },
                    PointGeometrySize = 15
                }
            };
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.WindowState != WindowState.Minimized)
                {
                    this.WindowState = WindowState.Minimized;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.WindowState != WindowState.Minimized)
                {
                    this.WindowState = WindowState.Minimized;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (this.WindowState != WindowState.Maximized)
                {
                    this.WindowState = WindowState.Maximized;
                    mn.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
                }
                else
                {
                    this.WindowState = WindowState.Normal;
                    mn.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
