using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI phaseText;
    public GameObject craftingPanel;
    public enum GameState { DayStart, Crafting, Dream, DayEnd }
    public GameState currentState;

    public int clientsPerDay = 3;  // Number of new clients to generate each day

    private int currentDay = 0;  // Track the current day


    void Start()
    {
        currentState = GameState.DayStart;
        StartDay();
    }

    void Update()
    {
        // Handle state transitions (if necessary)
    }

    void StartDay()
    {
        currentDay++;
        phaseText.enabled = true;
        phaseText.text = $"Starting day {currentDay}!";
        GetComponent<ClientManager>().GenerateClients(clientsPerDay);
        currentState = GameState.Crafting;
        Invoke(nameof(StartCrafting), 3f);
    }

    void StartCrafting()
    {
        //phaseText.text = $"Crafting dreams...!";
        Debug.Log("Crafting dreams...");
        phaseText.enabled = false;
        //// Logic for dream crafting goes here
        //Invoke(nameof(StartNightmare), 2f); // Simulate crafting for 5 seconds
        craftingPanel.SetActive(true);
    }

    public void StartDreamPhase()
    {
        craftingPanel.SetActive(false);
        phaseText.enabled = true;
        phaseText.text = "Dreams encountered...";
        Debug.Log("Dreams encountered...");
        currentState = GameState.Dream;
        // Logic for nightmare challenges
        Invoke(nameof(EndDay), 2f); // Simulate nightmare for 5 seconds
    }

    void EndDay()
    {
        phaseText.text = "Ending the day...";
        Debug.Log("Ending the day...");
        currentState = GameState.DayEnd;
        // Calculate rewards
        Invoke(nameof(StartDay), 2f); // Transition to the next day after 2 seconds
    }
}