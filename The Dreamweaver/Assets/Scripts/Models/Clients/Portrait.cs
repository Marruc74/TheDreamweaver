using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Portrait
{
    public string FaceShape { get; set; }

    [NonSerialized]
    private Texture2D _faceShape;
    [NonSerialized]
    private EthnicityData _ethnicityData;

    public Sprite CreatePortrait(string country, string gender, int age)
    {
        var etnicity = 1;
        if (country == "Brazil" || country == "Argentina" || country == "Mexico")
        {
            etnicity = 4;
        }
        else if (country == "Japan" || country == "South Korea" || country == "China" || country == "India")
        {
            etnicity = 2;
        }
        else if (country == "South Africa" || country == "Egypt" || country == "Nigeria")
        {
            etnicity = 3;
        }
        else if (country == "Turkey")
        {
            etnicity = 5;
        }

        EthnicityData ethnicityData = Resources.Load<EthnicityData>($"DataAssets/Clients/Ethnicities/{etnicity}");

        _ethnicityData = ethnicityData;
        //PaintAndTattoos = new List<DetailParts>();

        return GetFullImage(country, gender, age, ethnicityData);
    }

    public Sprite GetFullImage(string country, string gender, int age, EthnicityData ethnicityData)
    {

        //if (_faceShape == null)
        //{
        //LoadTextures();
        //}

        //    var skinColor = GetColorInfo(_ethnicityData.skinColorList.Colors, SkinColorInfoId);
        var skinColor = PickRandomValue(ethnicityData.skinColorList.Colors);
        var pupilsColor = PickRandomValue(ethnicityData.pupilsColorList.Colors);
        var hairColor = PickRandomValue(ethnicityData.hairColorList.Colors);
        //    var hairColor = GetColorInfo(_ethnicityData.hairColorList.Colors, HairColorInfoId);

        var tempImage = new Texture2D(128, 128);
        tempImage = ImageHelper.AlphaBlend(tempImage, gender == "Male" ? PickRandomValue(ethnicityData.faceShapesMale) : PickRandomValue(ethnicityData.faceShapesFemale), skinColor);

        //    foreach (var paintAndTattoo in PaintAndTattoos)
        //    {
        //        var paintAndTattooColor = _assetManager.GetPaintAndTattooColors((int)paintAndTattoo.ColorListId).Colors.FirstOrDefault(cd => cd.id == paintAndTattoo.ColorInfoId);
        //        tempImage = ImageHelper.AlphaBlend(tempImage, paintAndTattoo.Texture, paintAndTattooColor ?? null);
        //    }

        //    tempImage = ImageHelper.AlphaBlend(tempImage, _nose, new ColorInfo { color = ChangeColorBrightness(skinColor.color, -0.3f) });
        //    tempImage = ImageHelper.AlphaBlend(tempImage, _mouth);
        //    tempImage = ImageHelper.AlphaBlend(tempImage, _eyes);

        //    foreach (var wound in Wounds)
        //    {
        //        tempImage = ImageHelper.AlphaBlend(tempImage, wound.Texture);
        //    }

        tempImage = ImageHelper.AlphaBlend(tempImage, gender == "Male" ? PickRandomValue(ethnicityData.eyesPartsMale) : PickRandomValue(ethnicityData.eyesPartsFemale), null);
        tempImage = ImageHelper.AlphaBlend(tempImage, gender == "Male" ? PickRandomValue(ethnicityData.pupilsPartsMale) : PickRandomValue(ethnicityData.pupilsPartsFemale), pupilsColor);
        tempImage = ImageHelper.AlphaBlend(tempImage, gender == "Male" ? PickRandomValue(ethnicityData.nosePartsMale) : PickRandomValue(ethnicityData.nosePartsFemale), new ColorInfo { color = ChangeColorBrightness(skinColor.color, -0.3f) });
        tempImage = ImageHelper.AlphaBlend(tempImage, gender == "Male" ? PickRandomValue(ethnicityData.eyeBrowsMale) : PickRandomValue(ethnicityData.eyeBrowsFemale), hairColor);
        tempImage = ImageHelper.AlphaBlend(tempImage, gender == "Male" ? PickRandomValue(ethnicityData.mouthPartsMale) : PickRandomValue(ethnicityData.mouthPartsFemale), null);
        tempImage = ImageHelper.AlphaBlend(tempImage, gender == "Male" ? PickRandomValue(ethnicityData.hairMale) : PickRandomValue(ethnicityData.hairFemale), hairColor);
        if (gender == "Male")
        {
            tempImage = ImageHelper.AlphaBlend(tempImage, PickRandomValue(ethnicityData.facialHairMale), hairColor);
        }
        //    tempImage = ImageHelper.AlphaBlend(tempImage, _eyeBrows, hairColor);
        //    var clothes = wearableItems.FirstOrDefault(w => w.ItemType == WearableItemTypes.Clothes);
        //    if (clothes != null)
        //    {
        //        var clothesColor = _assetManager.GetWearablesColors(clothes.ColorListId).Colors.FirstOrDefault(cd => cd.id == clothes.ColorInfoId);
        //        tempImage = ImageHelper.AlphaBlend(tempImage, clothes.Texture, clothesColor ?? null);
        //    }

        //    var armor = wearableItems.FirstOrDefault(w => w.ItemType == WearableItemTypes.Armor);
        //    if (armor != null)
        //    {
        //        var armorColor = _assetManager.GetWearablesColors(armor.ColorListId).Colors.FirstOrDefault(cd => cd.id == armor.ColorInfoId);
        //        tempImage = ImageHelper.AlphaBlend(tempImage, armor.Texture, armorColor ?? null);
        //    }
        //    var shoulderPads = wearableItems.FirstOrDefault(w => w.ItemType == WearableItemTypes.ShoulderPads);
        //    if (shoulderPads != null)
        //    {
        //        var shoulderPadsColor = _assetManager.GetWearablesColors(shoulderPads.ColorListId).Colors.FirstOrDefault(cd => cd.id == shoulderPads.ColorInfoId);
        //        tempImage = ImageHelper.AlphaBlend(tempImage, shoulderPads.Texture, shoulderPadsColor ?? null);
        //    }
        //    tempImage = ImageHelper.AlphaBlend(tempImage, _faceHair, hairColor);
        //    var mask = wearableItems.FirstOrDefault(w => w.ItemType == WearableItemTypes.Mask);
        //    if (mask != null)
        //    {
        //        var maskColor = _assetManager.GetWearablesColors(mask.ColorListId).Colors.FirstOrDefault(cd => cd.id == mask.ColorInfoId);
        //        tempImage = ImageHelper.AlphaBlend(tempImage, mask.Texture, maskColor ?? null);
        //    }

        //    var helmet = wearableItems.FirstOrDefault(w => w.ItemType == WearableItemTypes.Helmet);
        //    if (helmet != null)
        //    {
        //        var helmetColor = _assetManager.GetWearablesColors(helmet.ColorListId).Colors.FirstOrDefault(cd => cd.id == helmet.ColorInfoId);
        //        tempImage = ImageHelper.AlphaBlend(tempImage, helmet.Texture, helmetColor ?? null);
        //    }

        //    if (helmet == null)
        //    {
        //        tempImage = ImageHelper.AlphaBlend(tempImage, _hair, hairColor);
        //    }

        //}

        var rec = new Rect(0, 0, tempImage.width, tempImage.height);
        return Sprite.Create(tempImage, rec, new Vector2(0.5f, 0.5f), 100);
    }

    public static T PickRandomValue<T>(List<T> list)
    {
        if (list == null || list.Count == 0)
        {
            throw new ArgumentException("List cannot be null or empty.");
        }

        System.Random random = new System.Random();
        int index = random.Next(0, list.Count); // Generates a random index
        return list[index];
    }

    public static int PickRandomIndex<T>(List<T> list)
    {
        if (list == null || list.Count == 0)
        {
            throw new ArgumentException("List cannot be null or empty.");
        }

        System.Random random = new System.Random();
        int index = random.Next(0, list.Count); // Generates a random index
        return index;
    }

    private Color ChangeColorBrightness(Color color, float correctionFactor)
    {
        float red = (float)color.r;
        float green = (float)color.g;
        float blue = (float)color.b;

        if (correctionFactor < 0)
        {
            correctionFactor = 1 + correctionFactor;
            red *= correctionFactor;
            green *= correctionFactor;
            blue *= correctionFactor;
        }
        else
        {
            red = (255 - red) * correctionFactor + red;
            green = (255 - green) * correctionFactor + green;
            blue = (255 - blue) * correctionFactor + blue;
        }

        return new Color(red, green, blue, color.a);
    }
}
