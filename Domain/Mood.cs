using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Mood
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MoodType { get; set; }
        public int MoodQuantity { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
