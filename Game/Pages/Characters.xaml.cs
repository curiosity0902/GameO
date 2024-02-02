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

namespace Game.Pages
{
    /// <summary>
    /// Логика взаимодействия для Characters.xaml
    /// </summary>
    public partial class Characters : Page
    {
        public Characters()
        {
            InitializeComponent();
        }

        private void WarriorBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Warrior());
        }
    }
}
