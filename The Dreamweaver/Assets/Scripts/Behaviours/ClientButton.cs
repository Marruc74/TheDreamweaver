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
        int clientIndex = GetComponentInParent<DisplayClientBasic>().clientIndex;
        managers.GetComponent<ClientPanelManager>().ShowBuildDreamPanel(clientIndex);

    }
}
