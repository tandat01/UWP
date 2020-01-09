using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using T1809E_HelloUWP.Models;
using T1809E_HelloUWP.Services;
using HtmlAgilityPack;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1809E_HelloUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentForm : Page
    {
        private IStudentService _service;
        //private int linkCount = 0;

        public StudentForm()
        {
            this.InitializeComponent();
            //this._service = new InmemoryStudentService();
            this._service = new ApiStudentService();
        }

        private async void Create_Student(object sender, RoutedEventArgs e)
        {
            // lấy dữ liệu từ form, chuyển thành đối tượng member với các trường tương ứng.
            var member = new Student()
            {
                firstName = TxtFirstName.Text,
                lastName = TxtLastName.Text,
                password = PwdPassword.Password,
                address = TxtAddress.Text,
                phone = TxtPhone.Text,
                avatar = TxtAvatar.Text,
                gender = Convert.ToInt32(TxtGender.Text),
                email = TxtEmail.Text,
                birthday = TxtBirthday.Text
            };
            // Validate dữ liệu
            var errors = member.CheckValidate();
            if (errors.Count > 0)
            {
                // thông báo lỗi nếu có.
            }
            Student student = await this._service.Create(member);
            Debug.WriteLine("Create success! "  + student.id);
            //_service.Create(student);
        }

        //private async void Async_OnClick(object sender, RoutedEventArgs e)
        //{
        //     Debug.WriteLine("Start");
        //     string task = await WaitForMe();
        //     Debug.WriteLine(task);
        //     Debug.WriteLine("End");
        //}

        //private async void Async_OnClick(object sender, RoutedEventArgs e)
        //{
        //    var watch = System.Diagnostics.Stopwatch.StartNew();
        //    //await WaitForLinkContent("https://vnexpress.net/bong-da/barca-thay-doi-the-nao-sau-cu-an-sau-10-nam-truoc-4030429.html");
        //    //await WaitForLinkContent("https://vnexpress.net/longform/tottenham-chelsea-va-nhung-tran-cau-dinh-tuan-nay-4030645.html");
        //    //await WaitForLinkContent("https://vnexpress.net/oto-xe-may/superbike-bmw-s1000rr-gia-1-1-ty-cap-ben-viet-nam-4030806.html");

        //    List<string> links = DemoGetLink();

        //    Debug.WriteLine("Link size: " + links.Count);

        //    linkCount = links.Count;
        //    foreach (var link in links)
        //    {
        //       WaitForLinkContent(link);
        //    }

        //    while (linkCount!=0)
        //    {
        //        await Task.Delay(2 * 1000);
        //    }
        //    watch.Stop();
        //    var elapsedMs = watch.ElapsedMilliseconds;
        //    Debug.WriteLine("Finish after: " +elapsedMs);
        //}

        //private List<string> DemoGetLink()
        //{
        //    List<string> list = new List<string>();
        //    WebClient wc = new WebClient();
        //    HtmlDocument doc = new HtmlDocument();
        //    doc.Load(wc.OpenRead("https://vnexpress.net/"));
        //    HtmlNodeCollection collection = doc.DocumentNode.SelectNodes("//a[@href]");
        //    foreach (HtmlNode node in collection)
        //    {
        //        var href = node.Attributes["href"].Value;
        //        if (!string.IsNullOrEmpty(href) && href.Contains("https://vnexpress.net"))
        //        {
        //            list.Add(href);
        //        }
        //    }
        //    return list;
        //}

        //private async Task WaitForLinkContent(string url)
        //{
        //    var httpClient = new HttpClient();
        //    var response =  await httpClient.GetAsync(url);
        //    var contentResponse = await response.Content.ReadAsStringAsync();
        //    Debug.WriteLine(url + ": get content finish!");
        //    linkCount--;
        //}


        //private async Task<string> WaitForMe()
        //{
        //    await Task.Delay(10 * 1000);
        //    Debug.WriteLine("I am back.");
        //    return "I am back.";
        //}



        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ListStudent));
        }

       
    }
}
