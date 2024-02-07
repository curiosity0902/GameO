using MongoDB.Bson;
using MongoDB.Driver;
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

namespace Game.Pages
{
    /// <summary>
    /// Логика взаимодействия для NotBaseStatpointsPage.xaml
    /// </summary>
    public partial class NotBaseStatpointsPage : Page
    {
        public NotBaseStatpointsPage()
        {
            InitializeComponent();
            txtName.Text = App.character.Name;
            StrengthTb.Text = Convert.ToString(App.character.Strenght);
            DexterityTb.Text = Convert.ToString(App.character.Dexterity);
            IntelegenceTb.Text = Convert.ToString(App.character.Intelegence);
            VitalityTb.Text = Convert.ToString(App.character.Vitality);

            HealthTB.Text = Convert.ToString(App.character.Vitality * 2 + (App.character.Strenght));
            MannaTB.Text = Convert.ToString(App.character.Intelegence);

            PDamageTb.Text = Convert.ToString(App.character.Strenght);

            ArmorTb.Text = Convert.ToString(App.character.Dexterity);
            MDamageTb.Text = Convert.ToString(App.character.Intelegence * 0.2);
            MDefenceTb.Text = Convert.ToString(App.character.Intelegence * 0.5);
            CRTChanseTb.Text = Convert.ToString(App.character.Dexterity * 0.2);
            CRTDamageTb.Text = Convert.ToString(App.character.Dexterity);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "")
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("Characters");
                var collection = database.GetCollection<Character>("CharacterCollection");
                var filter = new BsonDocument();
                var result = collection.Find(filter).ToList();
                var pers = result.FirstOrDefault(x => x.Name == App.character.Name); //ФИЛЬТР

                // определяем параметры обновления - обновляем только поле Age

                var updateSettings = new BsonDocument("$set", new BsonDocument(App.character.Name, "xj"));
                // выполняем обновление
                collection.UpdateOneAsync(filter, updateSettings);
                MessageBox.Show("ok");

            }
            else
                MessageBox.Show("!!!");
        }
    }
}
