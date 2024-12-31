using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTrait", menuName = "Client/Trait")]
public class Trait : ScriptableObject
{
    public string traitName;
    public string description;

    // Lists of modules that are ideal or adverse for this trait
    public List<ZoneModule> idealZones;
    public List<ZoneModule> adverseZones;

    public List<ElementModule> idealElements;
    public List<ElementModule> adverseElements;

    public List<CustomizationModule> idealCustomizations;
    public List<CustomizationModule> adverseCustomizations;
}