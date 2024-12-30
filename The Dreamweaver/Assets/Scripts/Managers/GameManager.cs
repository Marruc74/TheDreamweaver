using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState { DayStart, Crafting, Nightmare, DayEnd }
    public GameState currentState;

    public int clientsPerDay = 3;  // Number of new clients to generate each day
    public ClientManager clientManager;  // Reference to the ClientManager to access the client list

    private int currentDay = 1;  // Track the current day


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
        Debug.Log("Starting a new day...");
        clientManager.GenerateClients(clientsPerDay);
        currentState = GameState.Crafting;
        StartCrafting();
    }

    void StartCrafting()
    {
        Debug.Log("Crafting dreams...");
        // Logic for dream crafting goes here
        Invoke(nameof(StartNightmare), 5f); // Simulate crafting for 5 seconds
    }

    void StartNightmare()
    {
        Debug.Log("Nightmare encountered...");
        currentState = GameState.Nightmare;
        // Logic for nightmare challenges
        Invoke(nameof(EndDay), 5f); // Simulate nightmare for 5 seconds
    }

    void EndDay()
    {
        Debug.Log("Ending the day...");
        currentState = GameState.DayEnd;
        // Calculate rewards
        Invoke(nameof(StartDay), 2f); // Transition to the next day after 2 seconds
    }
}