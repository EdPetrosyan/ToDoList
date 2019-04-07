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
            TasksListBox.Items.Remove(TasksListBox.SelectedItem);
        }
    }
}
