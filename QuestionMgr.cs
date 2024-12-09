// 12/2/2024 Andrew Pfeiffer
// Built ChatGPT and me
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem.HID;
using UnityEngine.SceneManagement;

public class ButtonClickWithConditions : MonoBehaviour
{
    // Assign these buttons in the Unity Inspector
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;

    private void Start()
    {
        // Add listeners for the buttons
        button1.onClick.AddListener(() => OnButtonClicked(1));
        button2.onClick.AddListener(() => OnButtonClicked(2));
        button3.onClick.AddListener(() => OnButtonClicked(3));
        button4.onClick.AddListener(() => OnButtonClicked(4));
    }

    private void OnButtonClicked(int buttonNumber)
    {
        // Check which button was clicked
        if (buttonNumber == 1)
        {
            Debug.Log("Button 1 was clicked. Perform action for Button 1.");
            // Add your logic for Button 1 here
        }
        else if (buttonNumber == 2)
        {
            Debug.Log("Button 2 was clicked. Perform action for Button 2.");
            // Add your logic for Button 2 here
        }
        else if (buttonNumber == 3)
        {
            Debug.Log("Button 3 was clicked. Perform action for Button 3.");
            // Add your logic for Button 3 here
        }
        else if (buttonNumber == 4)
        {
            Debug.Log("Button 4 was clicked. Perform action for Button 4.");
            // Add your logic for Button 4 here
        }
    }
}
