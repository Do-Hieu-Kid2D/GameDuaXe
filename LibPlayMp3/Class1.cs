using System;
using System.Collections.Generic;
using System.Text;


namespace LibPlayMp3
{

    public class PlayMp3
    {
        String path;
        static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public PlayMp3(String path)
        {
            this.path = path;
        }

        public void lenNhac() {
            path = "@" + path;
            wplayer.URL = path;
            wplayer.controls.play();
        }


    }
}
