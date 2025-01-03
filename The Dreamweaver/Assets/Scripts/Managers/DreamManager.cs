using UnityEngine;

public class DreamManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Dream()
    {
        var clients = GetComponent<ClientManager>().currentClients;
        foreach (Client client in clients)
        {
            Debug.Log($"Client {client.firstName} {client.lastName}  has a dream...");
            // Logic for dream challenges
            // For now, just end the day

        };

        GetComponent<GameManager>().EndDay();
    }

    public void CallDreamWithDelay()
    {
        Invoke("Dream", 2f);
    }
}
