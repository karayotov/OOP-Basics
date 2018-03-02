using System;
using System.Collections.Generic;
using System.Text;
public class MoodFactory
{
    private const int AngryTopBorther = -6;
    private const int SadTopBorder = 0;
    private const int HappyTopBorther = 15;

    public static Mood GetMood(int happinessPoints)
    {
        if (happinessPoints <= AngryTopBorther)
        {
            return new Angry(happinessPoints);
        }
        else if (happinessPoints <= SadTopBorder)
        {
            return new Sad(happinessPoints);
        }
        else if (happinessPoints <= HappyTopBorther)
        {
            return new Happy(happinessPoints);
        }
        else
        {
            return new JavaScript(happinessPoints);
        }
    }
}
