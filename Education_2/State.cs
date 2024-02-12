namespace Education_2;

public class State
{
    public decimal Population { get; set; } // население
    public decimal Area { get; set; }       // территория
 
    public static State operator +(State s1, State s2)
    {
        return new State
        {
            Population = s1.Population + s2.Population,
            Area = s1.Area + s2.Area
        };
    }
     
    public static bool operator >(State s1, State s2)
    {
        return s1.Area > s2.Area;
    }
    public static bool operator <(State s1, State s2)
    {
        return s1.Area < s2.Area;
    }
}