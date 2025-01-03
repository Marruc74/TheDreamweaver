using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClientPanelManager : MonoBehaviour
{
    public GameObject clientPrefab;
    public Transform clientListParent;
    public GameObject buildDreamPanel;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PopulateClientList()
    {
        var clients = GetComponent<ClientManager>().currentClients;

        // Clear the list of clients already displayed in the panel
        foreach (Transform child in clientListParent)
        {
            Destroy(child.gameObject);
        }

        // Loop through all clients and create a UI entry for each one
        for (int i = 0; i < clients.Length; i++)
        {
            var client = clients[i];

            // Instantiate a new client UI prefab
            GameObject clientObj = Instantiate(clientPrefab, clientListParent);

            clientObj.GetComponent<DisplayClientBasic>().clientIndex = i;

            TextMeshProUGUI clientNameText = clientObj.GetComponentInChildren<TextMeshProUGUI>();

            clientNameText.text = $"Client: {client.firstName} {client.lastName}, Age: {client.age}, Gender: {client.gender}, Country: {client.country}, Satisfaction: {client.satisfactionLevel}%";

            Image portrait = clientObj.GetComponentInChildren<Image>();
            portrait.sprite = client.clientPortrait;
        }
    }

    public void ShowBuildDreamPanel(int clientIndex)
    {
        buildDreamPanel.SetActive(true);
        GetComponent<CraftingMenuManager>().clientsPanel.SetActive(false);
        GetComponent<DreamBuilderManager>().InstantiateModules(clientIndex);
    }

    public void HideBuildDreamPanel()
    {
        buildDreamPanel.SetActive(false);
        GetComponent<CraftingMenuManager>().clientsPanel.SetActive(true);
    }
}
