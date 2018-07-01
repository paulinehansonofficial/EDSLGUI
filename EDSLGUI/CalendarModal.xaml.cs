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
using System.Windows.Shapes;

namespace EDSLGUI
{
    /// <summary>
    /// Interaction logic for CalendarModal.xaml
    /// </summary>
    public partial class CalendarModal : Window
    {
        public CalendarModal()
        {
            InitializeComponent();
            GetRoundDates(16, new DateTime(2018, 11, 3));
            cal.DisplayDate = new DateTime(2018, 11, 3);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        public List<Round> GetRoundDates(int rounds, DateTime startDate)
        {
            List<Round> printRounds = new List<Round>();

            for (int count = 1; count == rounds; count++)
            {
                cal.SelectedDates.Add(startDate);
                Round round = new Round(count, startDate);
                printRounds.Add(round);
                startDate = startDate.AddDays(7);
            }
            setupseasonlv.ItemsSource = printRounds;
            return printRounds;
            
        }



        
        
    }

}
