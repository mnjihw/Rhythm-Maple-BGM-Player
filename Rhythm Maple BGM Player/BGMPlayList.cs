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
        private int currentIndex = 0;
        public int CurrentIndex
        {
            get => currentIndex;
            set
            {
                if (value < 0 || value > Items.Count)
                    new Exception("index range wrong");
                currentIndex = value;
            }
        } 
        public BGMListItem this[int index]
        {
            get => Items[index];
            set => Items[index] = value;
        }

    }
}
