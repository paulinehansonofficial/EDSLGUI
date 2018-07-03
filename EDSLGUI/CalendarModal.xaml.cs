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
        public CalendarModal(List<Round> displayRound)
        {
            InitializeComponent();
            Season_LV.ItemsSource = displayRound;

            PDFWriter writer = new PDFWriter();
            string toWrite = "";
            foreach (var item in displayRound)
            {
               string RoundNumber = item.RoundNumber.ToString();
               string RoundDate = item.RoundDate.ToShortDateString();
                cal.SelectedDates.Add(item.RoundDate);

                toWrite += "Round: "+ RoundNumber + " Date: " + RoundDate + "\n";
            }
            writer.Write(toWrite);

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime blackoutDate;
            //testtext.Text = Season_LV.SelectedItems.ToString();
            //testtext.Text = Season_LV.SelectedValue.ToString();

            Round round = Season_LV.SelectedValue as Round;
            testtext.Text = round.RoundDate.ToString();

           

            //object obj = Season_LV.SelectedValue.GetType();



            //this.Close();
        }

    }

}
