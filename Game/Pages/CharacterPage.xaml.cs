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
    public partial class CharacterPage //Cоздается ВОИН WARRIOR
    {
        public CharacterPage()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int strength = Convert.ToInt32(StrengthTb.Text);
            int intelegence = Convert.ToInt32(IntelegenceTb.Text);
            int dexterity = Convert.ToInt32(DexterityTb.Text);
            int vitality = Convert.ToInt32(VitalityTb.Text);
            CRUD.CreateCharacterWarrior(new Character(name, strength, 250, dexterity, 80, intelegence, 50, vitality, 100, 0, 0, 0, 0, 0, 0, 0, 0));
            NavigationService.Navigate(new NotBaseStatpointsPage());
        }

    }
}
