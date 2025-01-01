using UnityEngine;

public class ClientButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowEditDream()
    {
        Debug.Log("Show Edit Dream");
        GameObject managers = GameObject.Find("Managers");
        Client client = GetComponentInParent<DisplayClientBasic>().client;
        managers.GetComponent<ClientPanelManager>().ShowBuildDreamPanel(client);

    }
}
