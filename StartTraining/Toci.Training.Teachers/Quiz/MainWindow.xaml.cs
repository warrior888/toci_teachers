using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly QuizManager _quizManager;

        public MainWindow()
        {
            InitializeComponent();
            _quizManager = FindResource("QuizManager") as QuizManager;
        }


        private void ButtonBase_OnClick(object sender, EventArgs e)
        {
                var pushEnter = (KeyEventArgs) e;

            if (pushEnter.Key == Key.Enter)
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
        }

        private void UIElement_OnDrop(object sender, DragEventArgs e)
        {
            
        }

        private void AddGroupButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_quizManager.CreateGroup(createdGroupPanel.Items, GroupNameTextBox.Text))
            {
                GroupWarringTextBlock.IsEnabled = true;
                GroupWarringTextBlock.Text = "Name already exist. Please change group name.";
            }
            else
            {
                GroupWarringTextBlock.IsEnabled = false;
                createdGroupPanel.Items.Clear();
                AddGroupButton.IsEnabled = false;
            }
        }

        private void UserList_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListView)
            {
                ListView list = (ListView) sender;
                var user = list.SelectedItem as User;
                if (user?.GroupMambership != null || createdGroupPanel.Items.Contains(list.SelectedItem))
                {
                    AllUserWaringTextBlock.Text = "User already has a group";
                    return;
                }
                AllUserWaringTextBlock.Text = "";
                createdGroupPanel.Items.Add(list.SelectedItem);
                AddGroupButton.IsEnabled = true;
            }
        }
    }
}
