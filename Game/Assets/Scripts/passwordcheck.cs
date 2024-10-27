using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class passwordcheck : MonoBehaviour
{
    public GameObject passwordPanel;         
    public TMP_InputField passwordInputField; 
    public TMP_Text resultText;              
    public Button submitButton;              
    public GameObject door; 
    public GameObject note;

    private void Start()
    {
        passwordPanel.SetActive(false);
        resultText.gameObject.SetActive(false);

        submitButton.onClick.AddListener(SubmitPassword);
    }

    public void ShowPasswordPanel()
    {
        passwordPanel.SetActive(true);
    }

    private void SubmitPassword()
    {
        string enteredPassword = passwordInputField.text;

        if (enteredPassword == "0110101")
        {
            resultText.text = "Correct";
            resultText.gameObject.SetActive(true);

            StartCoroutine(ClosePanelAndDestroyDoor());
        }
        else
        {
            resultText.text = "Incorrect";
            resultText.gameObject.SetActive(true);
        }
    }

    private IEnumerator ClosePanelAndDestroyDoor()
    {
        yield return new WaitForSeconds(1f);  

        passwordPanel.SetActive(false);
        resultText.gameObject.SetActive(false);

        if (door != null)
        {
            Destroy(door);
            Destroy(note);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowPasswordPanel();  
        }
    }
}
