using System;
using UnityEngine;

[Serializable]
public class Client
{
    public string firstName;             // Client's first name
    public string lastName;              // Client's last name
    public Requirements requirements;     // Requirements (subobject with various attributes)
    public Trait[] traits;               // Array of traits (DataAssets to be created later)
    public string country;               // Country of origin
    public string gender;                // Gender of the client (e.g., "Male", "Female", "Other")
    public int age;                      // Age of the client
    public int satisfactionLevel;        // Satisfaction level (0-100)
    public int dreamBudget;              // Budget for their dream
    public Sprite clientPortrait;        // Portrait (optional)
    public AudioClip clientAudio;        // Audio clip (optional)

    // Constructor for creating a new client
    public Client(string fName, string lName, Requirements reqs, string country, string gender, int age, int budget)
    {
        firstName = fName;
        lastName = lName;
        requirements = reqs;
        this.country = country;
        this.gender = gender;
        this.age = age;
        satisfactionLevel = UnityEngine.Random.Range(50, 101); // Random satisfaction between 50 and 100
        dreamBudget = budget;
        clientPortrait = new Portrait().CreatePortrait(country, gender, age);
    }

    // Method to display client details
    public void DescribeClient()
    {
        Debug.Log($"Client: {firstName} {lastName}, Age: {age}, Gender: {gender}, Country: {country}, Satisfaction: {satisfactionLevel}%");
        Debug.Log($"Emotional Fulfillment: {requirements.emotionalFulfillment}%");
        Debug.Log($"Balance Psychological: {requirements.balancePsychological}%");
        Debug.Log($"Personal Growth: {requirements.personalGrowth}%");
        Debug.Log($"Fear Resistance: {requirements.fearResistance}%");
    }
}