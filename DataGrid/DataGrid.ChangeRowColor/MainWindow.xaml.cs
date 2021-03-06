﻿using System.Collections.Generic;
using System.Windows;
using TestData;

namespace DataGrid.ChangeRowColor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<Person> People { get; }

        public MainWindow()
        {
            People = Data.GeneratePeople(300);

            InitializeComponent();
        }
    }
}
