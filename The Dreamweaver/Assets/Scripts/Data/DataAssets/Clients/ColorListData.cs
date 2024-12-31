using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorListData", menuName = "Client/ColorList")]
[Serializable]
public class ColorListData : ScriptableObject
{
    public int id;
    public string colorListName;
    public List<ColorInfo> Colors;
}