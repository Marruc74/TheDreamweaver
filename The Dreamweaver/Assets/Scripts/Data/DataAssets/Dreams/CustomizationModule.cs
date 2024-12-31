using UnityEngine;

[CreateAssetMenu(fileName = "NewCustomizationModule", menuName = "DreamModules/Customization")]
public class CustomizationModule : ScriptableObject
{
    public string customizationName;
    public string description;
    public string idealClients;
    public Sprite icon;
    public int baseCost;
    public float bonusMultiplier; // Multiplier for overall dream satisfaction
}