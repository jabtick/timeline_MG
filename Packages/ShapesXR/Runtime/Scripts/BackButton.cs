using UnityEngine;

public class BackButton : MonoBehaviour
{
    public TimelineManager? timelineManager;

    void OnMouseDown()
    {
        timelineManager?.ShowMainMenu();
    }
}