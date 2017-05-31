namespace StringMatcher
{
    public interface IJaroWinklerDistance
    {
        double Distance(string CandidateString, string ComparisonString);

        double Proximity(string CandidateString, string ComparisonString);
    }
}
