using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewZoneModule", menuName = "DreamModules/Zone")]
public class ZoneModule : ScriptableObject
{
    public string zoneName;
    public string description;
    public ZoneType type; // Enum for Zone Type
    public ZoneTier tier; // Enum for Tier
    public List<ZoneModule> prerequisites; // List of prerequisite ZoneModules
    public string idealClients;

    public Sprite icon;

    public int baseCost;
    public float emotionalImpact; // Influence on Emotional Fulfillment
    public float balanceImpact;   // Influence on Balance Psychological
}

public enum ZoneType
{
    Nature,
    Structured,
    Adventure,
    Discovery,
    Fantasy,
    Competitive,
    Luxurious,
    Transcendent,
    Abstract
}

public enum ZoneTier
{
    Starter,
    Basic,
    Advanced,
    Premium
}