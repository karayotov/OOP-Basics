using System;
public class Messages
{
    public static string RegisterHarvesterMessage => "Successfully registered {0} Harvester - {1}";//type, id

    public static string RegisterProviderMessage => "Successfully registered {0} Provider - {1}";//type, id//propertyName

    public static string InvalidHarvesterRegistration => "Harvester is not registered, because of it's {0}";//propertyName

    public static string InvalidProviderRegistration => "Provider is not registered, because of it's EnergyOutput";//propertyName

    public static string ModeChanged => "Successfully changed working mode to {0} Mode";//mode

    public static string UnitNotFound => "No element found with id - {0}"; //id

    public static string ToStringHarvester => "{0} Harvester - {1}{2}Ore Output: {3}{4}Energy Requirement: {5}";//type, id , Environment.NewLine, oreOutput, Environment.NewLine, energyRequired

    public static string ToStringProvider => "{0} Provider - {1}{2}Energy Output: {3}";//type, id, Environment.NewLine, energyOutput

    public static string DayHasPassed => "A day has passed.{0}Energy Provided: {1}{2}Plumbus Ore Mined: {3}";//Environment.NewLine, summedEnergyOutput, Environment.NewLine, summedOreOutput

    public static string Shutdouwn => "System Shutdown{0}Total Energy Stored: {1}{2}Total Mined Plumbus Ore: {3}";//Environment.NewLine, totalEnergyStored, Environment.NewLine, totalMinedOre

}