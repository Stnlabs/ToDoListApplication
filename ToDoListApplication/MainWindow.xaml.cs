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
using System.IO;
using System;


namespace ToDoListApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
            IsThereAnyDataASFilesOrFolders();
            IsThereAnyDate();
            DifferenceBetweenDateAndTime();
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {

            //Schreibt die Activitys
            if (Input1.Text == "" && Input2.Text == "" && Input3.Text == "" && Input4.Text == "" && Input5.Text == "" && Input6.Text == "" && Input7.Text == "")
            {
                MessageBox.Show("Bitte alle Daten angeben");
                return;
            }

            string pathtoWrite = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication", "ToDoList.txt");
            StreamWriter sw = new StreamWriter(pathtoWrite);
            sw.WriteLine(Input1.Text);
            sw.WriteLine(Input2.Text);
            sw.WriteLine(Input3.Text);
            sw.WriteLine(Input4.Text);
            sw.WriteLine(Input5.Text);
            sw.WriteLine(Input6.Text);
            sw.WriteLine(Input7.Text);
            sw.Close();
            //Schreibt die Dates
            if (Datepicker1.Text == "" && Datepicker2.Text == "" && Datepicker3.Text == "" && Datepicker4.Text == "" && Datepicker5.Text == "" && Datepicker6.Text == "" && Datepicker7.Text == "")
            {
                MessageBox.Show("Bitte alle Daten Angeben");
                return;
            }

            string datepathtowrite = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication", "Date.txt");
            StreamWriter datesw = new StreamWriter(datepathtowrite);
            datesw.WriteLine(Datepicker1.Text);
            datesw.WriteLine(Datepicker2.Text);
            datesw.WriteLine(Datepicker3.Text);
            datesw.WriteLine(Datepicker4.Text);
            datesw.WriteLine(Datepicker5.Text);
            datesw.WriteLine(Datepicker6.Text);
            datesw.WriteLine(Datepicker7.Text);
            datesw.Close();
        }



        public void IsThereAnyDataASFilesOrFolders()
        {
            if (Directory.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication")))
            {

            }
            if (File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication", "ToDoList.txt")))
            {

                //Lade die Daten aus der Datei in mein ui Check.
                string pathToRead = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication", "ToDoList.txt");
                StreamReader sr = new StreamReader(pathToRead);
                Input1.Text = sr.ReadLine();
                Input2.Text = sr.ReadLine();
                Input3.Text = sr.ReadLine();
                Input4.Text = sr.ReadLine();
                Input5.Text = sr.ReadLine();
                Input6.Text = sr.ReadLine();
                Input7.Text = sr.ReadLine();
                sr.Close();
                MessageBox.Show("Datei existiert bereits Daten wurden geladen !!!!.");
                return;
            }
            else
            {
                string basisPfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string pfad = System.IO.Path.Combine(basisPfad, "ToDoListApplication");
                Directory.CreateDirectory(pfad);
                string DateiPfad = System.IO.Path.Combine(pfad, "ToDoList.txt");
                File.WriteAllText(DateiPfad, "");
                MessageBox.Show("Datei wurde erstellt.");
            }

        }

        private void Input1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public void IsThereAnyDate()
        {
            if (Directory.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication")))
            {

            }
            if (File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication", "Date.txt")))
            {

                //Lade die Daten aus der Datei in mein ui Check.
                string pathToRead = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoListApplication", "Date.txt");
                StreamReader sr = new StreamReader(pathToRead);
                Date1.Text = sr.ReadLine();
                Date2.Text = sr.ReadLine();
                Date3.Text = sr.ReadLine();
                Date4.Text = sr.ReadLine();
                Date5.Text = sr.ReadLine();
                Date6.Text = sr.ReadLine();
                Date7.Text = sr.ReadLine();
                sr.Close();
                MessageBox.Show("Date.txt existiert");
                return;
            }
            else
            {
                string basisPfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string pfad = System.IO.Path.Combine(basisPfad, "ToDoListApplication");
                Directory.CreateDirectory(pfad);
                string DateiPfad = System.IO.Path.Combine(pfad, "Date.txt");
                File.WriteAllText(DateiPfad, "");
                MessageBox.Show("Datei wurde erstellt.");
            }

        }
        public void DifferenceBetweenDateAndTime()
        {
            //
            if (DateTime.TryParse(Date1.Text, out DateTime date1))
            {
                Time1.Text = (date1 - DateTime.Now).TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                Time1.Text = "Kein Datum";
            }

            if (DateTime.TryParse(Date2.Text, out DateTime date2))
            {
                Time2.Text = (date2 - DateTime.Now).TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                Time2.Text = "Kein Datum";
            }

            if (DateTime.TryParse(Date3.Text, out DateTime date3))
            {
                Time3.Text = (date3 - DateTime.Now).TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                Time3.Text = "Kein Datum";
            }

            if (DateTime.TryParse(Date4.Text, out DateTime date4))
            {
                Time4.Text = (date4 - DateTime.Now).TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                Time4.Text = "Kein Datum";
            }

            if (DateTime.TryParse(Date5.Text, out DateTime date5))
            {
                Time5.Text = (date5 - DateTime.Now).TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                Time5.Text = "Kein Datum";
            }

            if (DateTime.TryParse(Date6.Text, out DateTime date6))
            {
                Time6.Text = (date6 - DateTime.Now).TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                Time6.Text = "Kein Datum";
            }

            if (DateTime.TryParse(Date7.Text, out DateTime date7))
            {
                Time7.Text = (date7 - DateTime.Now).TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                Time7.Text = "Kein Datum";
            }
        }

    }
}
