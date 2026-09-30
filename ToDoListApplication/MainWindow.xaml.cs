using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;


namespace ToDoListApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<TextBox> TextBoxes = new List<TextBox>();

        DateTime time;
        public MainWindow()
        {

            InitializeComponent();
        }

        private void SaveBTN_Click_1(object sender, RoutedEventArgs e)
        {
            string AnzahlderAktivität = Counter.Text;

            for (int i = 0; i < Counter.Text.Length; i++)
            {
                Activitys neuesObjektFürJson = new Activitys();
                neuesObjektFürJson.Name = TextBoxes[i].Name;
                neuesObjektFürJson.Description = TextBoxes[i].Text;
                neuesObjektFürJson.Start = DateTime.Now;

                neuesObjektFürJson.Ende = Convert.ToDateTime(Timer.Text);
                neuesObjektFürJson.Dauer = neuesObjektFürJson.Ende - neuesObjektFürJson.Start;
               
                {
                }
                    
                



            }
        }

        private void Activity1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Counter_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxes.Clear();
            DynamicControlsPanel.Children.Clear();
            string text = Counter.Text;
            if (int.TryParse(text, out int number))
            {
                MessageBox.Show($"Ýour activity counter is {number}");
                for (int i = 0; i < number; i++)
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Name = $"Activity{i}";
                    newTextBox.Text = $"Aktivität {i + 1}";
                    newTextBox.Margin = new Thickness(0, 5, 0, 5); // Abstand zwischen den Boxen

                    TextBoxes.Add(newTextBox);
                    // 3. Die TextBox dem StackPanel auf der Oberfläche hinzufügen
                    DynamicControlsPanel.Children.Add(newTextBox);
                }
            }
            else
            {
                // Nur Warnung zeigen, wenn das Feld nicht komplett leer ist
                if (!string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Please insert a number");
                }
            }
        }
    }
}