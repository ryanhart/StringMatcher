using System.Collections.Generic;
using StringMatcher.Models;

namespace StringMatcher
{
    public class StringMatcherConfiguration
    {
        public List<Synonym> Synonyms { get; set; }

        public int JaroWinklerPrefixLengh { get; set; }
    }
}