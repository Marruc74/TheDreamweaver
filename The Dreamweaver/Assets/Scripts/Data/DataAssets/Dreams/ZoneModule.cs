using UnityEngine;

[CreateAssetMenu(fileName = "NewZoneModule", menuName = "DreamModules/Zone")]
public class ZoneModule : ScriptableObject
{
    public string zoneName;
    public string description;
    public string idealClients;
    public Sprite icon;
    public int baseCost;
    public float emotionalImpact; // Influence on Emotional Fulfillment
    public float balanceImpact;   // Influence on Balance Psychological
}