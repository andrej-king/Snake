﻿using System;
using System.IO;
using WMPLib;

namespace Snake
{
    public class Sounds
    {
        // Media player
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "stardust.mp3";
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true); // loop mode
            
        }

        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            // player.settings.volume = 100;
            player.controls.play();
        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "click.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}