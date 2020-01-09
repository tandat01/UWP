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
using T1809E_HelloUWP.Models;
using T1809E_HelloUWP.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1809E_HelloUWP.Pages
{
    
    public sealed partial class MemberInformation : Page
    {
        private MemberService _memberService = new MemberService();
        public MemberInformation()
        {
            this.InitializeComponent();
            LoadMemberInformation();
        }

        private async void LoadMemberInformation()
        {
            Student student = await this._memberService.GetMemberInformation(LogInPage.Token);
           /* MemberName.Text = student.email;*/
            MemberPhone.Text = student.phone;
            MemberAddress.Text = student.address;
            MemberBirthday.Text = student.birthday;
           
        }
    }
}
