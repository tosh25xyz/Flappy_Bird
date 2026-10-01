using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject startMenuPanel;
    public GameObject mapSelectionPanel;

    public void OpenMapSelection()
    {
        startMenuPanel.SetActive(false);
        mapSelectionPanel.SetActive(true);
    }

    public void BackToStartMenu()
    {
        mapSelectionPanel.SetActive(false);
        startMenuPanel.SetActive(true);
    }
}