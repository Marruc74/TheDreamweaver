using UnityEngine;
using UnityEngine.SceneManagement;  // For loading scenes
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Button continueButton;  // Reference to Continue button
    public Button loadGameButton;  // Reference to Load Game button

    // Check if a saved game exists and update the button states
    private void Start()
    {
        // Check for a saved game (PlayerPrefs or file-based)
        bool hasSavedGame = CheckForSavedGame();

        // Enable/Disable buttons based on saved game
        continueButton.interactable = hasSavedGame;
        loadGameButton.interactable = hasSavedGame;
    }

    // Function to check if there is a saved game
    private bool CheckForSavedGame()
    {
        // You can use PlayerPrefs or check for a specific save file
        // For simplicity, we'll use PlayerPrefs to check if a key exists

        // Example: Check if "GameSaved" key exists in PlayerPrefs
        return PlayerPrefs.HasKey("GameSaved");
    }

    // This function will start a new game by loading the "GameScene"
    public void StartNewGame()
    {
        Debug.Log("Starting a new game...");
        SceneManager.LoadScene("MainGame");  // Replace with your actual game scene name
    }

    // This function will continue the game by loading the last saved scene
    public void ContinueGame()
    {
        Debug.Log("Continuing game...");
        // Load the scene for continuing the game
        // If using PlayerPrefs or save files, load the specific save here
    }

    // This function will load the game from a saved point
    public void LoadGame()
    {
        Debug.Log("Loading game...");
        // Implement your load game logic here (e.g., load a save file)
    }

    // This function will exit the game
    public void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();  // Exits the application
    }
}
