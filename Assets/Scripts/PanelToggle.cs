using UnityEngine;

public class PanelToggle : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false); 
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }
}