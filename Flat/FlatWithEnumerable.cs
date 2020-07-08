using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FlatProgram
{
    public class FlatWithEnumerable
    {
        public static IEnumerable<object> Flat(object entry)
        {
            if (!(entry is IEnumerable))
            {
                yield return entry;
            }
            else
            {
                var entries = (List<object>)entry;
                foreach (var item in entries.SelectMany(Flat))
                {
                    yield return item;
                }
            }
        }
    }
}