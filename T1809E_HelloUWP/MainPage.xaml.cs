using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1809E_HelloUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int _choosedGender = 2;
        private DateTime _birthDay;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var rollNumber = RollNumber.Text;
            var fullName = FullName.Text;
            var gender = _choosedGender;
            var birthday = _birthDay;
            ListStudent.Items.Add(string.Format("{0} - {1} - {2} - {3}",
                rollNumber,
                fullName,
                gender == 2 ? "Other" : (gender == 1 ? "Male" : "Female"), 
                birthday.ToString("MM/dd/yyyy")));
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            RollNumber.Text = "";
        }

        private void Gender_Choose(object sender, RoutedEventArgs e)
        {
           var chooseRadioButton = (RadioButton) sender;
           if (chooseRadioButton == null)
           {
               return;
           }
           switch (chooseRadioButton.Tag)
           {
                case "Male":
                    _choosedGender = 1;
                    break;
                case "Female":
                    _choosedGender = 0;
                    break;
                case "Other":
                    _choosedGender = 2;
                    break;
           }
        }

        private void Birthday_OnDateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            if (sender.Date.HasValue)
            {
                _birthDay = sender.Date.Value.Date;
            }
        }
    }
}
