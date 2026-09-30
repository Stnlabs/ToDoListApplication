using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApplication
{
    class Activitys
    {
        public string Name {  get; set; }

        public string Description { get; set; }   
        public DateTime Start { get; set; }
        public DateTime Ende { get; set; }
        public TimeSpan Dauer { get; set; }
        public List<string> NamenDerAktivitäten = new List<string>();
    }
}
