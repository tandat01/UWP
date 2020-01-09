using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    public class SongService
    {
        public ObservableCollection<Song> LoadSongs()
        {
            ObservableCollection<Song> list = new ObservableCollection<Song>();
            list.Add(new Song()
            {
                Name = "Tình không xót xa",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui829/TinhThoiXotXa-LamTruong-2453487.mp3",
                Likes = 109,
                Description = "Tình thôi xót xa",
                Thumbnail = "https://avatar-nct.nixcdn.com/singer/avatar/2018/06/07/7/2/a/a/1528338325576_600.jpg"
            });
            list.Add(new Song()
            {
                Name = "Đi đu đưa đi",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui988/DiDuDuaDi-BichPhuong-6059493.mp3",
                Likes = 200,
                Description = "Tình chưa xót xa",
                Thumbnail = "http://giadinh.mediacdn.vn/thumb_w/640/2019/9/4/bich-phuong-trong-di-du-dua-difgfdgfdgd-1567596484678552798701.jpg"
            });
            list.Add(new Song()
            {
                Name = "Từng yêu",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui983/TungYeu-PhanDuyAnh-5989256.mp3",
                Likes = 300,
                Description ="Tình chưa xót xa",
                Thumbnail = "https://data.nhacpro.net/data/avatar/5996be9c16a6b7d8557eaa5c30b92264.jpg"
            });
            return list;
        }
    }
}
