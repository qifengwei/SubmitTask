using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitTask.Saved
{
    public class MapOwnerArea
    {
        public Dictionary<String, String> Owner { get; set; } = new Dictionary<string, string>();
        public Dictionary<String, String> Area { get; set; } = new Dictionary<string, string>();

        private MapOwnerArea mapOwnerArea = new MapOwnerArea();
        private MapOwnerArea() { }
        public MapOwnerArea GetMapOwnerAreaInstance() => mapOwnerArea;
    }
}
