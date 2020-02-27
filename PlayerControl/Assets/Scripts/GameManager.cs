using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

/*
    Script: GameManager
    Author: Gareth Lockett
    Version: 1.0
    Description:    Main game manager script.
                    Currently keeps track of number of collected coins.
*/

public class GameManager : MonoBehaviour
{
    // Properties
    public static int score;        // The number of coins collected. 
                                    // NOTE the 'static' keyword here. This means it can be accessed from ANY script by calling GameManager.score (Eg see Coin script)
                                    // NOTE: 'static' properties do NOT show in the Inspector.

    public int targetScore = 10;    // The number of coins to collect.

    public Text UIText;
    string currentText;
    // Methods
    private void Update()
    {
        currentText = "Player has collected " + score + " coins!";
        // Check the number of coins that have been collected.
        UIText.text = currentText;
        if (GameManager.score == this.targetScore)
        {
            // Output that the number of target coins have been collected.
            Debug.Log(currentText);
            
            // Deactivate this GameManager component so that it stops checking the score each Update().
            this.gameObject.SetActive(false);
        }
    }
}