using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    /// <summary>
    /// Provides functionality to sort names by last name and then by given names.
    /// </summary>
    public static class NameSorterService
    {
        /// <summary>
        /// Sorts a list of names. Sorting is performed first by last name, then by given names.
        /// </summary>
        /// <param name="names">A list of full names.</param>
        /// <returns>A sorted list of names.</returns>
        public static List<string> SortNames(List<string> names)
        {
            return names.OrderBy(name => name.Split(" ").Last())
                         .ThenBy(name => string.Join(" ", name.Split(" ").SkipLast(1)))
                         .ToList();
        }
    }
}