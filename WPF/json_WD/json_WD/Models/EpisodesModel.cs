using System;
using System.Collections.Generic;
using System.Text;

namespace json_WD.Models
{
    public class _links
    {
        public self self { get; set; }
    }

    public class self
    {
        public string href { get; set; }
    }
    public class image
    {
        public string medium { get; set; }
        public string original { get; set; }
    }
    public class EpisodesModel
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public int season { get; set; }
        public int number { get; set; }
        public string type { get; set; }
        public string airdate { get; set; }
        public string airtime { get; set; }
        public string airstamp { get; set; }
        public int runtime { get; set; }
        public image image { get; set; }


        private string _summary;

        public string summary
        {
            get { return _summary; }
            set { _summary = value.Replace("<p>","").Replace("</p>",""); }
        }


        public _links _links { get; set; }
    }
}
