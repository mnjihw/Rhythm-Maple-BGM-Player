using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhythm_Maple_BGM_Player
{
    class BGMPlayList
    {
        public ObservableCollection<BGMListItem> Items { get; } = new ObservableCollection<BGMListItem>();
        private int playingIndex = 0;
        public int PlayingIndex
        {
            get => playingIndex;
            set
            {
                if (value < 0 || value > Items.Count)
                    new Exception("index range wrong");
                playingIndex = value;
            }
        } 
        public BGMListItem this[int index] => Items[index];

    }
}
