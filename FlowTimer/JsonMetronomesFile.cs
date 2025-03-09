using System.Collections.Generic;

namespace FlowTimer
{

    public class JsonMetronomesHeader
    {

        public int Version = FlowTimer.GetCurrentBuild();
        // future use (maybe)
    }

    public class JsonMetronome
    {

        public string Name;
        public string Offsets;
        public string BPM;
        public string BeatsPerBar;
        public string TotalFullBars;
    }

    public class JsonMetronomesFile
    {

        public JsonMetronomesHeader Header;
        public List<JsonMetronome> Timers;

        // Json Constructor
        public JsonMetronomesFile() { }

        public JsonMetronomesFile(JsonMetronomesHeader header, List<JsonMetronome> timers) => (Header, Timers) = (header, timers);

        public JsonMetronome this[int i]
        {
            get { return Timers[i]; }
            set { Timers[i] = value; }
        }
    }
}

