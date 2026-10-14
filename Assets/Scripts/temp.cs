using UnityEngine;

public class CanvasActivator : MonoBehaviour
{
    public GameObject settingsCanvas;
    public GameObject button;

    public void ShowSettings()
    {
        settingsCanvas.SetActive(true);
        button.SetActive(false);
    }

    public void HideSettings()
    {
        settingsCanvas.SetActive(false);
    }

    public void ToggleSettings()
    {
        settingsCanvas.SetActive(!settingsCanvas.activeSelf);
    }
}