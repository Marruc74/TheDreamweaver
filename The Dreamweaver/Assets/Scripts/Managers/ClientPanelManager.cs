using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClientPanelManager : MonoBehaviour
{
    public GameObject clientPrefab;
    public Transform clientListParent;
    public GameObject managers;

    public Client[] clients;

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
        clients = managers.GetComponent<ClientManager>().currentClients;

        // Clear the list of clients already displayed in the panel
        foreach (Transform child in clientListParent)
        {
            Destroy(child.gameObject);
        }

        // Loop through all clients and create a UI entry for each one
        foreach (var client in clients)
        {
            // Instantiate a new client UI prefab
            GameObject clientObj = Instantiate(clientPrefab, clientListParent);

            TextMeshProUGUI clientNameText = clientObj.GetComponentInChildren<TextMeshProUGUI>();

            //clientNameText.text = client.firstName + " " + client.lastName + " - " + client.country + " - " + client.age + " years old";
            clientNameText.text = $"Client: {client.firstName} {client.lastName}, Age: {client.age}, Gender: {client.gender}, Country: {client.country}, Satisfaction: {client.satisfactionLevel}%";

            Image portrait = clientObj.GetComponentInChildren<Image>();
            portrait.sprite = client.clientPortrait;
            // Set the client's details on the UI prefab
            //ClientUI clientUI = clientObj.GetComponent<ClientUI>();
            //clientUI.SetClientDetails(client);  // Pass the client data to the UI script

            //// You can also hook up the button functionality here
            //Button clientButton = clientObj.GetComponentInChildren<Button>();
            //clientButton.onClick.AddListener(() => OnClientButtonClicked(client));
        }
    }
}
