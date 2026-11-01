class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()=>new int[]{0, 2, 5, 3, 7, 8, 4};

    public int Today()=>birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] = birdsPerDay[birdsPerDay.Length - 1] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in birdsPerDay)
        {
            if(birds == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int a = 0;
        for (int i = 0; i< numberOfDays;i++)
        {
            a+= birdsPerDay[i];
        }
        return a;
    }

    public int BusyDays()
    {
        int a = 0;
        foreach(int birds in birdsPerDay)
        {
            if(birds >= 5)
            {
                a++;
            }
        }
        return a;
    }
}
