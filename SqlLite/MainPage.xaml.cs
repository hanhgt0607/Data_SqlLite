
using SqlLite.entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DEMO_SQLLite.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoWithListView : Page
    {
        private ObservableCollection<Song> listSong;
        internal ObservableCollection<Song> ListSong { get => listSong; set => listSong = value; }


        public DemoWithListView()
        {
            this.ListSong = new ObservableCollection<Song>();
            this.ListSong.Add(new Song()
            {
                name = "Chiều hôm ấy",
                thumbnail = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTyg_hnaLSRN9Uk7TBdl5AwZCTD0b3ADvCB7r7OuJfMrAndbjRseg"

            });
            this.ListSong.Add(new Song()
            {
                name = "Đường một chiều",
                thumbnail = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQnr7-LqBLZwGvS_P0QH05YFSH_OozJseEWw4P2XdRiYo_C3avE-g"

            });
            this.ListSong.Add(new Song()
            {
                name = "Lạ lùng",
                thumbnail = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQp67R-Ee5BkE0ao68Duh53VJpdrKY-0Z1Sg4MXIAXMQjRMWhMw"

            });
            this.ListSong.Add(new Song()
            {
                name = "Hong khong 1",
                thumbnail = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSRrGMRcmUVzcFdA0jJze-N9wN3xjvW7ZvXJ7CWEMWGEb9my4Z8"

            });

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Song song = new Song()
            {
                name = this.SongName.Text,
                thumbnail = this.Thumbnail.Text
            };
            this.ListSong.Add(song);
            this.SongName.Text = string.Empty;
            this.Thumbnail.Text = string.Empty;
            SongModel.Add(song);
        }
    }
}

