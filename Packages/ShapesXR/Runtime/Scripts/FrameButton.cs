using UnityEngine;

public class FrameButton : MonoBehaviour
{
    public TimelineManager? timelineManager;
    public int frameIndex; // 0 = Frame 2, 1 = Frame 3, etc.

    void OnMouseDown()
    {
        timelineManager?.ShowFrame(frameIndex);
    }
}