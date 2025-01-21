using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Iterator
{
    public class Playlist : IEnumerable<string>
    {
        private List<string> _songs = new();
        private bool _randomOrder = false;
        public void Add(string song) { _songs.Add(song); }
        public void SetRandomOrder(bool randomOrder) { _randomOrder = randomOrder; }
        public IEnumerator<string> GetEnumerator() => _randomOrder ? _songs.OrderBy(x => Guid.NewGuid()).GetEnumerator() : _songs.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
