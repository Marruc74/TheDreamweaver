using UnityEngine;

[CreateAssetMenu(fileName = "NewTrait", menuName = "Dreamweaver/Trait")]
public class Trait : ScriptableObject
{
    public string traitName;            // Name of the trait
    public string description;          // Description of the trait (optional)
}