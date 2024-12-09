// 12/2/2024 Andrew Pfeiffer
// Built ChatGPT and me

using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject[] panels; // Array to hold all panels in the canvas
    private int currentPanelIndex = 0; // Keeps track of the current panel

    void Start()
    {
        ShowPanel(currentPanelIndex);
    }

    private void ShowPanel(int panelIndex)
    {
        // Hide all panels and show only the specified panel
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == panelIndex);
        }

        // Add listeners to buttons in the current panel
        Button[] buttons = panels[panelIndex].GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnButtonClicked(button));
        }
    }

    private void OnButtonClicked(Button clickedButton)
    {
        Debug.Log($"Button {clickedButton.name} clicked!");

        // Proceed to the next panel
        NextPanel();
    }

    public void NextPanel()
    {
        // Remove listeners from the current panel
        Button[] buttons = panels[currentPanelIndex].GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.RemoveAllListeners();
        }

        // Show the next panel
        currentPanelIndex++;
        if (currentPanelIndex < panels.Length)
        {
            ShowPanel(currentPanelIndex);
        }
        else
        {
            Debug.Log("All panels are completed!");
        }
    }
}