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

namespace EDSLGUI
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

        public void Create_Button_Click(object sender, RoutedEventArgs e)
        {

            int rounds = string.IsNullOrEmpty(Rounds_Input.Text) ? 0 : int.Parse(Rounds_Input.Text);
            DateTime? date = Start_Date_Picker.SelectedDate;
            DateTime newDate = DateTime.Now;

            if (date == null)
            {
                throw new Exception();
            }

            else
            {
                newDate = date.Value;
            }

            Season season = new Season(rounds, newDate, null);
            List<Round> displayRounds = new List<Round>();
            foreach (var item in season.AllRounds)
            {
                displayRounds.Add(item);
                
            }

            CalendarModal cm = new CalendarModal(displayRounds);
            cm.Show();
        }
    }
}
