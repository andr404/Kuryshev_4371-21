using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    class ConferenceWithTopic
    {
        conf conf;
        string topic;
        public ConferenceWithTopic(conf conf, string topic)
        {
            this.conf = conf;
            this.topic = topic;
        }
        public int ConfId { get => conf.conf_id; }
        public string Name { get => conf.name; }
        public string Subject { get => conf.subject; }
        public DateTime Date { get => conf.data; }
        public string Place { get => conf.place; }
        public int CountSpeakers { get => conf.count_speakers; }
        public int CountGuests { get => conf.count_guests; }
        public TimeSpan Time { get => conf.starttime; }
        public string Topic { get => topic; }
    }
}
