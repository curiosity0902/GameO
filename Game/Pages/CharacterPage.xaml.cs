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
            txtName.Text = App.SelectedCh.Name;
            int intek = App.SelectedCh.Intelegence;
            int intek1 = App.SelectedCh.Dexterity;
            int intek2 = App.SelectedCh.Vitality;
            int intek3 = App.SelectedCh.Strenght;
            
            StrengthTb.Text = intek3.ToString();           
            IntelegenceTb.Text = intek.ToString();
            DexterityTb.Text = intek1.ToString();
            VitalityTb.Text = intek2.ToString();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CRUD.CreateCharacter(new Character("Warrior 1", 30, 250, 15, 80, 10, 50, 25, 100, 100, 100, 0, 0, 0, 0, 0, 0));
            NavigationService.Navigate(new Characters());
        }
    }
}
