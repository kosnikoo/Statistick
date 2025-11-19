using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data.Interfaces;
using Data.Inmemory;
using Domain.Statistics;

namespace Service
{
    internal class StatisticsService
    {
        private MoodRepository _moodRepository;

        public List<StatisticMonth> GetMonthName(MoodFilter filter)
        {
            var mood = _moodRepository.GetAll(filter);
            return mood
            .GroupBy(x => new { x.EntryDate.Year, x.EntryDate.Month})
            .Select(g => new StatisticMonth
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                Count = g.Count()
            })
            .OrderBy(m => m.Year)
            .ThenBy(m => m.Month)
            .ToList();
        }
        public List<StatisticEntity> GetReservationsByMood(MoodFilter filter)
        {
            var mood = _moodRepository.GetAll(filter);
            return mood
            .Where(r => r.MoodQuantity != -1)
            .GroupBy(r => r.MoodType)
            .Select(g => new StatisticEntity
            {
                Mood = g.Key,
                Count = g.Count()
            })
            .OrderByDescending(m => m.Count)
            .ToList();
        }
    }
}