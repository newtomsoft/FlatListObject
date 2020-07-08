using FlatProgram;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FlatTest
{
    public class FlatWithEnumerableShould
    {
        [Fact]
        public void Return_FlatList()
        {
            var listTested = new List<object>
            {
                5,
                new List<object>
                {
                    77,
                    14,
                    new List<object>
                    {
                        69, 10, 25
                    },
                    7
                },
                33,
                127
            };
            Assert.Equal(new List<object> { 5, 77, 14, 69, 10, 25, 7, 33, 127 }, FlatWithEnumerable.Flat(listTested).ToList());
        }
    }
}
