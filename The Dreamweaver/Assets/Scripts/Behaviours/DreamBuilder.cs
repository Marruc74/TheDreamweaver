using System.Collections.Generic;
using UnityEngine;

public class DreamBuilder : MonoBehaviour
{
    // Lists to hold selected modules during gameplay
    public List<ZoneModule> selectedZones;
    public List<ElementModule> selectedElements;
    public List<CustomizationModule> selectedCustomizations;

    // Total cost of the current dream
    public int totalCost;

    // Method to add a module
    public void AddZoneModule(ZoneModule module)
    {
        selectedZones.Add(module);
        UpdateCost();
    }

    public void AddElementModule(ElementModule module)
    {
        selectedElements.Add(module);
        UpdateCost();
    }

    public void AddCustomizationModule(CustomizationModule module)
    {
        selectedCustomizations.Add(module);
        UpdateCost();
    }

    // Remove a module
    public void RemoveZoneModule(ZoneModule module)
    {
        selectedZones.Remove(module);
        UpdateCost();
    }

    public void RemoveElementModule(ElementModule module)
    {
        selectedElements.Remove(module);
        UpdateCost();
    }

    public void RemoveCustomizationModule(CustomizationModule module)
    {
        selectedCustomizations.Remove(module);
        UpdateCost();
    }

    // Update the total cost of the dream
    private void UpdateCost()
    {
        totalCost = 0;

        foreach (var zone in selectedZones)
            totalCost += zone.baseCost;

        foreach (var element in selectedElements)
            totalCost += element.baseCost;

        foreach (var customization in selectedCustomizations)
            totalCost += customization.baseCost;
    }

    // Calculate the dream's overall impacts
    public float CalculateEmotionalImpact()
    {
        float totalImpact = 0;

        foreach (var zone in selectedZones)
            totalImpact += zone.emotionalImpact;

        return totalImpact;
    }

    public float CalculateBalanceImpact()
    {
        float totalImpact = 0;

        foreach (var zone in selectedZones)
            totalImpact += zone.balanceImpact;

        return totalImpact;
    }

    public float CalculatePersonalGrowthImpact()
    {
        float totalImpact = 0;

        foreach (var element in selectedElements)
            totalImpact += element.personalGrowthImpact;

        return totalImpact;
    }

    public float CalculateFearResistanceImpact()
    {
        float totalImpact = 0;

        foreach (var element in selectedElements)
            totalImpact += element.fearResistanceImpact;

        return totalImpact;
    }

    public float CalculateSatisfactionMultiplier()
    {
        float multiplier = 1.0f;

        foreach (var customization in selectedCustomizations)
            multiplier += customization.bonusMultiplier;

        return multiplier;
    }
}