﻿using System;
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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> doneTasks = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TaskTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && !TaskTextBox.Text.StartsWith(" "))
            {
                TasksListBox.Items.Add(TaskTextBox.Text);
                TaskTextBox.Text = "";
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListBox.SelectedIndex > -1)
            {
                TasksListBox.Items.Remove(TasksListBox.SelectedItem); 
            }
        }
        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListBox.SelectedIndex > -1)
            {
                doneTasks.Add((TasksListBox.SelectedItem.ToString()));
                DoneTasksListBox.Items.Add(doneTasks.Last());
                TasksListBox.Items.Remove(TasksListBox.SelectedItem);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = DoneTasksListBox.Items.Count-1; i >=0 ; i--)
            {
                DoneTasksListBox.Items.RemoveAt(i);
            }
        }
    }
}
