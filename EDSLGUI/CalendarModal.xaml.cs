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
using EDSLGUI;

namespace EDSLGUI
{
    /// <summary>
    /// Interaction logic for CalendarModal.xaml
    /// </summary>
    public partial class CalendarModal : Window
    {
        public Season season;
        public CalendarModal(Season pseason)
        {
            InitializeComponent();
            season = pseason;
            Season_LV.ItemsSource = pseason.AllRounds;
        }

        public void Blackout_Click(object sender, RoutedEventArgs e)
        {
            DateTime blackoutDate;
            //testtext.Text = Season_LV.SelectedItems.ToString();
            //testtext.Text = Season_LV.SelectedValue.ToString();

            Round round = Season_LV.SelectedValue as Round;
            blackoutDate = round.RoundDate;

            season =  season.RescheduleApplyBlackout(season, blackoutDate);

            Season_LV.ItemsSource = season.AllRounds;
            Blackout_LV.ItemsSource = season.Blackout;
            Season_LV.Items.Refresh();
            Blackout_LV.Items.Refresh();

            //object obj = Season_LV.SelectedValue.GetType();
        }

        public void PDF_Click(Season pseason)
        {
            PDFWriter writer = new PDFWriter();
            string toWrite = "";
            foreach (var item in pseason.AllRounds)
            {
                string RoundNumber = item.RoundNumber.ToString();
                string RoundDate = item.RoundDate.ToShortDateString();

                toWrite += "Round: " + RoundNumber + " Date: " + RoundDate + "\n";
            }
            writer.Write(toWrite);
        }

        public void Confirm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
