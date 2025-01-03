using UnityEngine;

public class ModuleButton : MonoBehaviour
{
    public ZoneModule zoneModule;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleZoneModule()
    {
        GameObject managers = GameObject.Find("Managers");
        //Client client = GetComponentInParent<DreamBuilderManager>();
        managers.GetComponentInParent<DreamBuilderManager>().ToggleZone(zoneModule);

    }
}
