using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class buttonpress : MonoBehaviour
{
    public Button myButton;
    public TextMeshProUGUI counterText;
    public TextMeshProUGUI randomDisplay;
    public GameObject targetObject;

    private int counter = 0;
    private int maxPresses = 10;
    private List<string> outcomes = new List<string>();

    public string level3;

    private void Start()
    {
        counterText.gameObject.SetActive(true);
        randomDisplay.gameObject.SetActive(false);
        UpdateCounterText();
        myButton.onClick.AddListener(OnButtonPress);
    }

    private void OnButtonPress()
    {
        counter++;
        UpdateCounterText();
        DisplayAndSaveRandomOutcome();

        if (counter == 2 || counter == 5 || counter == 7)
        {
            targetObject.SetActive(false);
        }
        else if (counter == 3 || counter == 6 || counter == 8)
        {
            targetObject.SetActive(true);
        }

        if (counter >= maxPresses)
        {
            myButton.interactable = false;
            counterText.gameObject.SetActive(false);
            randomDisplay.gameObject.SetActive(false);
            LoadNextScene();
        }
    }

    private void UpdateCounterText()
    {
        int remainingPresses = maxPresses - counter;
        Debug.Log("Remaining Presses: " + remainingPresses);  
        counterText.SetText("Presses left: {0}", remainingPresses);
    }

    private void DisplayAndSaveRandomOutcome()
    {
        if (!randomDisplay.gameObject.activeSelf)
        {
            randomDisplay.gameObject.SetActive(true);
        }

        string outcome = Random.value < 0.5f ? "Base: X" : "Base: +";
        randomDisplay.text = outcome;
        outcomes.Add(outcome);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(level3);
    }
}
