namespace Power_Mk2;

public class SolarPlant
{
    public readonly int EfficiencyDaily = 2;
    
    public int EnergyProductionPerGivenDaysDefault30(int qtyPlant, int days = 30)
        => EfficiencyDaily * qtyPlant * days;
    
}