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

namespace Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected QuizManager _quizManager;

        public MainWindow()
        {
            InitializeComponent();
            _quizManager = FindResource("QuizManager") as QuizManager;
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (_quizManager.AddUser(userNameTextBox.Text))
            {
                confirmedTextBlock.Text = "Added";
                confirmedTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                
                confirmedTextBlock.Text = "Empty box or name exist";
                confirmedTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void UIElement_OnDrop(object sender, DragEventArgs e)
        {
            
        }
    }
}
