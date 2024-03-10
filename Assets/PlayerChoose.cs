using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissors : MonoBehaviour
{
    public Text resultText;
    public Text player1ChoiceText;
    public Text player2ChoiceText;
    public GameObject playerChoicePanel;
    public GameObject animationPanel;

    private string player1Choice = "";
    private string player2Choice = "";

    // Function to handle player input
    public void PlayerChoice(string choice)
    {
        if (player1Choice == "")
        {
            player1Choice = choice;
            player1ChoiceText.text = "Player 1 chose: " + choice;
        }
        else if (player2Choice == "")
        {
            player2Choice = choice;
            player2ChoiceText.text = "Player 2 chose: " + choice;
        }

        if (player1Choice != "" && player2Choice != "")
        {
            DetermineWinner();
            ShowAnimationPanel();
        }
    }

    // Function to determine the winner
    void DetermineWinner()
    {
        // Your existing DetermineWinner logic here
    }

    // Function to show animation panel and hide player choice panel
    void ShowAnimationPanel()
    {
        playerChoicePanel.SetActive(false);
        animationPanel.SetActive(true);
    }
}
