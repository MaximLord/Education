class Clock
{
    public int Hours { get; set; }
 
    public static implicit operator Clock(int x)
    {
        return new Clock { Hours = x % 24 };
    }
    public static explicit operator int(Clock clock)
    {
        return clock.Hours;
    }
}