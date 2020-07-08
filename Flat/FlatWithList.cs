using System.Collections;
using System.Collections.Generic;

namespace FlatProgram
{
    public class FlatWithList
    {
        public static List<object> Flat(object entry)
        {
            var list = new List<object>();
            FillList(entry, ref list);
            return list;
        }

        private static void FillList(object entry, ref List<object> listToFill)
        {
            if (!(entry is IList))
            {
                listToFill.Add(entry);
            }
            else
            {
                var entryAsList = (List<object>)entry;
                foreach (var item in entryAsList)
                {
                    FillList(item, ref listToFill);
                }
            }
        }
    }
}