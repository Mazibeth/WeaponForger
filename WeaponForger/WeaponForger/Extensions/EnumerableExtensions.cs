// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/04/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.Collections;

namespace WeaponForger.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Returns the index of the specified object in the collection.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="obj">The object.</param>
        /// <returns>If found returns index otherwise -1</returns>
        public static int IndexOf(this IEnumerable self, object obj)
        {
            var index = -1;

            var enumerator = self.GetEnumerator();
            enumerator.Reset();
            var i = 0;
            while (enumerator.MoveNext())
            {
                if (enumerator.Current == obj)
                {
                    index = i;
                    break;
                }

                i++;
            }

            return index;
        }
    }
}