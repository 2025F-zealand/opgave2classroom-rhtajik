using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            StudentList = new List<Student>();
        }

        public void CountBirthdaysBySeason()
        {
            var seasonCounts = StudentList
                .GroupBy(student => student.GetSeason())
                .Select(group => new { Season = group.Key, Count = group.Count() })
                .ToList();

            foreach (var seasonCount in seasonCounts)
            {
                Console.WriteLine($"{seasonCount.Season}: {seasonCount.Count} student(s) with birthday.");
            }
        }
    }
}

