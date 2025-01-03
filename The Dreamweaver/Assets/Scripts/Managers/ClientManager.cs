using System.Collections.Generic;
using UnityEngine;
using static Names;

public class ClientManager : MonoBehaviour
{
    public Trait[] possibleTraits;  // This will be populated with DataAssets later
    public Client[] currentClients;  // Array to hold the clients for today
    private string[] possibleCountries = {
        "USA", "Canada", "Germany", "Sweden", "Italy",
        "France", "Spain", "UK", "Australia", "Brazil",
        "Japan", "South Korea", "China", "India", "Russia",
        "Mexico", "South Africa", "Argentina", "Egypt", "Nigeria", "Turkey"
    };
    private string[] possibleGenders = { "Male", "Female" };  // Gender options
    private int minAge = 18;
    private int maxAge = 65;

    // Generate a list of clients for the day
    public void GenerateClients(int numberOfClients)
    {
        currentClients = new Client[numberOfClients];

        var countryNames = new CountryNames();

        for (int i = 0; i < numberOfClients; i++)
        {
            string country = possibleCountries[Random.Range(0, possibleCountries.Length)];
            int genderValue = Random.Range(0, possibleGenders.Length);
            string gender = possibleGenders[genderValue]; // Random gender selection

            List<string> firstNames = countryNames.GetNamesForCountry(country, genderValue);
            string firstName = firstNames[Random.Range(0, firstNames.Count - 1)];
            List<string> lastNames = countryNames.GetLastNamesForCountry(country, genderValue);
            string lastName = lastNames[Random.Range(0, lastNames.Count - 1)];

            Requirements randomRequirements = new Requirements()
            {
                emotionalFulfillment = Random.Range(50f, 100f),
                balancePsychological = Random.Range(50f, 100f),
                personalGrowth = Random.Range(50f, 100f),
                fearResistance = Random.Range(50f, 100f)
            };


            int age = Random.Range(minAge, maxAge);  // Random age between 18 and 65

            int budget = Random.Range(100, 1001);  // Random budget between 100 and 1000

            Client newClient = new Client(firstName, lastName, randomRequirements, country, gender, age, budget);

            // Assign 3 unique random traits with either positive or negative effect
            newClient.traits = new List<CharacterTrait>();
            HashSet<Trait> assignedTraits = new HashSet<Trait>();
            while (newClient.traits.Count < 3)
            {
                Trait randomTrait = possibleTraits[Random.Range(0, possibleTraits.Length)];
                if (!assignedTraits.Contains(randomTrait))
                {
                    assignedTraits.Add(randomTrait);
                    bool isPositive = Random.Range(0, 2) == 0; // Randomly choose between positive and negative effect
                    CharacterTrait characterTrait = new CharacterTrait
                    {
                        trait = randomTrait,
                        isPositive = isPositive
                    };
                    newClient.traits.Add(characterTrait);
                }
            }

            // Store the new client in the current clients array
            currentClients[i] = newClient;

            // Optionally, log the client’s information
            newClient.DescribeClient();
        }
    }

}
