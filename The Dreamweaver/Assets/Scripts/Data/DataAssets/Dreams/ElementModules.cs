using UnityEngine;

[CreateAssetMenu(fileName = "NewElementModule", menuName = "DreamModules/Element")]
public class ElementModule : ScriptableObject
{
    public string elementName;
    public string description;
    public string idealClients;
    public Sprite icon;
    public int baseCost;
    public float personalGrowthImpact; // Influence on Personal Growth
    public float fearResistanceImpact; // Influence on Fear Resistance
}