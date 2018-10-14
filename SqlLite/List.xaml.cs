using DEMO_SQLLite.entity;
using SqlLite.entity;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DEMO_SQLLite.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class List : Page
    {
        private List<SqlLite.entity.Song> listSong;
        public List()
        {
            this.InitializeComponent();
            List_Song();
        }

        internal List<Song> ListSong { get => ListSong; set => ListSong = value; }

        private void List_Song()
        {
            listSong = SongModel.GetData();
            foreach (var item in listSong)
            {
                new Song()
                {
                    name = item.name,
                    thumbnail = item.thumbnail
                };
            }
        }
    }
}
