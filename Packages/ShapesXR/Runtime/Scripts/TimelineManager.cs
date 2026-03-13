using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public GameObject[] frames = { };
    public GameObject? mainMenu;

    void Start()
    {
        mainMenu?.SetActive(true);
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        foreach (GameObject frame in frames)
            frame.SetActive(false);
        mainMenu?.SetActive(true);
    }

    public void ShowFrame(int frameIndex)
    {
        ShowMainMenu();
        mainMenu?.SetActive(false);
        frames[frameIndex].SetActive(true);
    }
}