﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListSong : Page
    {
        private Song currentSong;
        private SongService _songService;
        private bool _isPlaying = false;

        public ListSong()
        {
            InitializeComponent();
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            _songService = new SongService();
            Songs.ItemsSource = _songService.LoadSongs();
        }

        private void Songs_OnItemClick(object sender, ItemClickEventArgs e)
        {
            currentSong = e.ClickedItem as Song;
            MyPlayer.Source = MediaSource.CreateFromUri(new Uri(currentSong.Link));
            MyPlayer.MediaPlayer.Play();
            PlayButton.Icon = new SymbolIcon(Symbol.Pause);
            _isPlaying = true;
            StatusText.Text = "Now Playing: " + currentSong.Name;
        }

        [Obsolete]
        private void PlayButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (Songs.ItemsSource == null) return;
            if (currentSong == null)
            {
                currentSong = _songService.LoadSongs().FirstOrDefault();
                MyPlayer.Source = MediaSource.CreateFromUri(new Uri(currentSong.Link));
                Songs.SelectedIndex = 0;
            }

            if (_isPlaying)
            {
                MyPlayer.MediaPlayer.Pause();
                PlayButton.Icon = new SymbolIcon(Symbol.Play);
                StatusText.Text = "Paused";
                _isPlaying = false;
            }
            else
            {
                MyPlayer.MediaPlayer.Play();
                PlayButton.Icon = new SymbolIcon(Symbol.Pause);
                StatusText.Text = "Now Playing: " + currentSong.Name;
                _isPlaying = true;
            }
        }

        private void Next_OnClick(object sender, RoutedEventArgs e)
        {
            var currentIndex = Songs.SelectedIndex;
            currentIndex++;
            if (currentIndex >= Songs.Items.Count)
            {
                currentIndex = 0;
            }
            currentSong = Songs.Items[currentIndex] as Song;
            Songs.SelectedIndex = currentIndex;
            MyPlayer.Source = MediaSource.CreateFromUri(new Uri(currentSong.Link));
            MyPlayer.MediaPlayer.Play();
            PlayButton.Icon = new SymbolIcon(Symbol.Pause);
            _isPlaying = true;
            StatusText.Text = "Now Playing: " + currentSong.Name;
        }

        private void Previous_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}