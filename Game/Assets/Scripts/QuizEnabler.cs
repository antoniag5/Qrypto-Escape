using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizEnabler : MonoBehaviour
{
    public GameObject passwordPanel;
    public Button submitButton;
    public TMP_InputField passwordInputField;
    public GameObject resultPanel;
    // public GameObject GameObject;
    public TMP_Text resultText;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("QuizEnabler: Player entered the trigger zone");
            Time.timeScale = 0;
            // GameObject door = GameObject.Find("Door");
            // if (door != null)
            // {
            //     Destroy(door);
            // }

            // Move the player ten steps back
            other.transform.position -= other.transform.forward * 6;

            passwordPanel.SetActive(true);
            submitButton.GetComponentInChildren<TMP_Text>().text = "Submit";
            submitButton.onClick.AddListener(() => CheckPassword(passwordInputField.text));

        }
    }

    public void CheckPassword(string password)
    {
        Debug.Log("QuizEnabler: Password entered: " + password);
        passwordPanel.SetActive(false);
        Time.timeScale = 1;
        if (password == "1001101")
        {
            Debug.Log("QuizEnabler: Correct password entered");
            GameObject door = GameObject.Find("DoorMain");
            if (door != null)
            {
                Destroy(door);
            }
            ShowResult("Success");
            // GameObject.SetActive(false);

            // gameObject.SetActive(false);


            passwordPanel.SetActive(false);
        }
        else
        {
            Debug.Log("QuizEnabler: Incorrect password entered");
            ShowResult("Failure");
        }

    }

    private void ShowResult(string message)
    {
        resultPanel.SetActive(true);
        resultText.text = message;
        StartCoroutine(HideResultPanelAfterDelay(3f));
    }

    private IEnumerator HideResultPanelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        resultPanel.SetActive(false);

    }
}
