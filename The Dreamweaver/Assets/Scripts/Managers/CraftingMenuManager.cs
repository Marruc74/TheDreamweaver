using UnityEngine;

public class CraftingMenuManager : MonoBehaviour
{
    // Reference to the panels
    public GameObject storePanel;
    public GameObject clientsPanel;

    public GameObject craftingPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowClientPanel()
    {
        clientsPanel.SetActive(true);
        craftingPanel.SetActive(false);
        GetComponent<ClientPanelManager>().PopulateClientList();
    }

    public void HideClientPanel()
    {
        clientsPanel.SetActive(false);
        craftingPanel.SetActive(true);
    }


}
