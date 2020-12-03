using System;

namespace RandomDataGenerator
{
    public static class RandomDateGenerator
    {
        public static DateTime GetRandomDate(DateTime? before, DateTime? after, int? seed)
        {
            if (before == null) before = DateTime.Now;//What the Hell am I lookin’ at? When does this happen in the movie?
            var now = before.GetValueOrDefault();//Now. Whatever you’re looking at now, is happening now.
            var then = new DateTime();//Well, what happened to then?
            if (after == null)
            {
                then = new DateTime(0); //We just passed it.
            }
            if (seed == null) //When?
            {
                seed = now.Millisecond;//Just now.
            }
            var random = new Random(seed.GetValueOrDefault());//[confused look]
            var timeSpan = now - then;//Well, go back to then.
            var newSpan = new TimeSpan(random.Next(0, (int)timeSpan.TotalHours), random.Next(0, 13), random.Next(0, 37));//We can’t.
            if (now - then < newSpan)// Why not?
            {
                newSpan = then - now; //We already passed it.
            }
            var when = then + newSpan;//When will then be now?
            return when;//Soon.
        }
    }
}
