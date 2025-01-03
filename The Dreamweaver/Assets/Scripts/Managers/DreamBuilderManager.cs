using UnityEngine;
using UnityEngine.UI;

public class DreamBuilderManager : MonoBehaviour
{
    public GameObject zones;

    public GameObject modulePrefab;

    public GameObject dreamModules;

    public int clientIndex;

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantiateModules(int clientIndexToUse)
    {
        clientIndex = clientIndexToUse;
        GameManager gameManager = GetComponent<GameManager>();
        Transform modulesTransform = zones.transform.Find("Modules");

        foreach (Transform child in modulesTransform.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Transform child in dreamModules.transform)
        {
            Destroy(child.gameObject);
        }

        if (gameManager == null)
        {
            Debug.LogError("GameManager component not found on the same GameObject.");
            return;
        }


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

        UpdateDream();
    }

    public void UpdateDream()
    {
        var client = GetComponent<ClientManager>().currentClients[clientIndex];
        // Clear existing modules
        foreach (Transform child in dreamModules.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (var zone in client.zoneModules)
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
        var client = GetComponent<ClientManager>().currentClients[clientIndex];
        if (client.zoneModules.Contains(module))
        {
            client.zoneModules.Remove(module);
        }
        else
        {
            client.zoneModules.Add(module);
        }

        UpdateDream();
    }
}
