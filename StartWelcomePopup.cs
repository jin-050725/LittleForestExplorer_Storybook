using UnityEngine;
using UnityEngine.UI;

public class StartWelcomePopup : MonoBehaviour
{
    public GameObject welcomePanel;

    public void ShowWelcomeText()
    {
        if(welcomePanel != null)
        {
            welcomePanel.SetActive(!welcomePanel.activeSelf);
        }
    }
}
