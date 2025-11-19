using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Data.Interfaces
{
    public record MoodFilter
    {
        public static MoodFilter Empty => new();
        public DateTime? StartDate { get; init; }
        public DateTime? EndDate { get; init; }
    }
    public interface IMoodRepository
    {
        List<Mood> GetAll(MoodFilter filter);
    }
}
