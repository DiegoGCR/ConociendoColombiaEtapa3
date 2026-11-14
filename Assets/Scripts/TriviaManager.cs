using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Data structure to store trivia questions and cultural information
[System.Serializable]
public class CulturalTrivia
{
    public string regionName;
    [TextArea(2, 4)]
    public string culturalFact; // Cultural info displayed upon collecting elements
    public string questionText;
    public string[] options; // 3 or 4 answer options
    public int correctAnswerIndex; // Index of the correct option (0, 1, 2...)
}

public class TriviaManager : MonoBehaviour
{
    [Header("Cultural Trivia Database")]
    public List<CulturalTrivia> triviaList = new List<CulturalTrivia>();

    [Header("UI Components")]
    public GameObject triviaPanel;
    public TextMeshProUGUI regionText;
    public TextMeshProUGUI factText;
    public TextMeshProUGUI questionText;
    public Button[] optionButtons;

    [Header("Game Flow References")]
    public GameObject winScreen;
    public GameObject loseScreen;

    private CulturalTrivia currentTrivia;

    private void Start()
    {
        // Ensure UI panels are hidden at the start
        if (triviaPanel != null) triviaPanel.SetActive(false);
    }

    // Call this method when all cultural items in the level have been collected
    public void TriggerEndLevelTrivia()
    {
        if (triviaList.Count == 0) return;

        // Pause the game time and show the trivia panel
        Time.timeScale = 0f;
        triviaPanel.SetActive(true);

        // Select a random trivia question from the list
        int randomIndex = Random.Range(0, triviaList.Count);
        currentTrivia = triviaList[randomIndex];

        // Populate the UI fields with cultural data
        regionText.text = currentTrivia.regionName;
        factText.text = currentTrivia.culturalFact;
        questionText.text = currentTrivia.questionText;

        // Set up option buttons dynamically
        for (int i = 0; i < optionButtons.Length; i++)
        {
            if (i < currentTrivia.options.Length)
            {
                optionButtons[i].gameObject.SetActive(true);
                TextMeshProUGUI btnText = optionButtons[i].GetComponentInChildren<TextMeshProUGUI>();
                if (btnText != null) btnText.text = currentTrivia.options[i];

                int selectedIndex = i; // Local copy for listener
                optionButtons[i].onClick.RemoveAllListeners();
                optionButtons[i].onClick.AddListener(() => OnAnswerSelected(selectedIndex));
            }
            else
            {
                optionButtons[i].gameObject.SetActive(false);
            }
        }
    }

    // Handles the user's answer selection
    private void OnAnswerSelected(int index)
    {
        Time.timeScale = 1f; // Reanuda el tiempo
    triviaPanel.SetActive(false);

    if (index == currentTrivia.correctAnswerIndex)
    {
        // Correct answer: Trigger actual victory from GameController
        FindObjectOfType<GameController>().Ganar();
    }
    else
    {
        // Incorrect answer: Trigger defeat/restart condition from GameController
        FindObjectOfType<GameController>().Perder();
    }
    }
}