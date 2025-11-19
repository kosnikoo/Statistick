using Domain;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Inmemory
{
    public class MoodRepository : IMoodRepository
    {
        private readonly List<Mood> _mood= new();
        public List<Mood> GetAll(MoodFilter filter)
        {
            var result = _mood.AsEnumerable();
            if (filter.StartDate.HasValue)
                result = result.Where(r => r.EntryDate >= filter.StartDate.Value);
            if (filter.EndDate.HasValue)
                result = result.Where(r => r.EntryDate <= filter.EndDate.Value);
            return result.ToList();
        }
    }
}
