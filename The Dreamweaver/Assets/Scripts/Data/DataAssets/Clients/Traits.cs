using UnityEngine;

[CreateAssetMenu(fileName = "NewTrait", menuName = "Client/Trait")]
public class Trait : ScriptableObject
{
    public string positiveName;
    public string positiveDescription;

    public string negativeName;
    public string negativeDescription;
}