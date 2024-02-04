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
using Game.Mongodb;

namespace Game.Pages
{
    /// <summary>
    /// Логика взаимодействия для CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage
    {
        public CharacterPage()
        {
            InitializeComponent();           
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CRUD.CreateCharacter(new Character("Warrior 1", 30, 250, 15, 80, 10, 50, 25, 100));
        }
    }
}
