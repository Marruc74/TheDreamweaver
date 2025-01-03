using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DreamBuilderManager : MonoBehaviour
{
    public GameObject zones;

    public GameObject modulePrefab;

    public List<ZoneModule> zoneModules;

    public GameObject dreamModules;

    // Start is called before the first frame update
    void Start()
    {
        zoneModules = new List<ZoneModule>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantiateModules()
    {
        GameManager gameManager = GetComponent<GameManager>();
        if (gameManager == null)
        {
            Debug.LogError("GameManager component not found on the same GameObject.");
            return;
        }

        Transform modulesTransform = zones.transform.Find("Modules");
        if (modulesTransform == null)
        {
            Debug.LogError("Modules child not found in zones.");
            return;
        }

        foreach (var zone in gameManager.availableZones)
        {
            GameObject moduleInstance = Instantiate(modulePrefab, modulesTransform);
            Image imageComponent = moduleInstance.transform.Find("Image").GetComponent<Image>();
            if (imageComponent != null)
            {

                if (zone.icon != null)
                {
                    imageComponent.sprite = zone.icon;
                }
            }

            moduleInstance.GetComponent<ModuleButton>().zoneModule = zone;
        }
    }

    public void UpdateDream()
    {
        // Clear existing modules
        foreach (Transform child in dreamModules.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (var zone in zoneModules)
        {
            GameObject moduleInstance = Instantiate(modulePrefab, dreamModules.transform);
            Image imageComponent = moduleInstance.transform.Find("Image").GetComponent<Image>();
            if (imageComponent != null)
            {

                if (zone.icon != null)
                {
                    imageComponent.sprite = zone.icon;
                }
            }

            moduleInstance.GetComponent<ModuleButton>().zoneModule = zone;
        }
    }

    public void ToggleZone(ZoneModule module)
    {
        if (zoneModules.Contains(module))
        {
            zoneModules.Remove(module);
        }
        else
        {
            zoneModules.Add(module);
        }

        UpdateDream();
    }
}
