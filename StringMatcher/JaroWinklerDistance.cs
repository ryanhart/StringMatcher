using System;

namespace StringMatcher
{
    public class JaroWinklerDistance : IJaroWinklerDistance
    {
        private readonly double weightThreshold = 1;
        
        private readonly int prefixLength = 1;

        public double Distance(string CandidateString, string ComparisonString)
        {
            throw new NotImplementedException();
        }
        
        public double Proximity(string CandidateString, string ComparisonString)
        {
            throw new NotImplementedException();
        }
    }
}
