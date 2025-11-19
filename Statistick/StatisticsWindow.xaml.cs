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
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для StatisticsWindow.xaml
    /// </summary>
    public partial class StatisticsWindow : Window
    {

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public StatisticsWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            // Загрузка статистики с фильтрацией
        }
        private void ResetFilterButton_Click(object sender, RoutedEventArgs e)
        {
            StartDate = null;
            EndDate = null;
            // Загрузка статистики без фильтров
        }
    }
}
