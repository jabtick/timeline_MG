using UnityEngine;

public class CameraMouseControl : MonoBehaviour
{
    public float rotationSpeed = 3f;
    public float zoomSpeed = 5f;
    public float minZoom = 1f;
    public float maxZoom = 10f;
    
    

    private float currentZoom = 5f;

    void Update()
    {
        // Rotate while holding LEFT mouse button
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

            transform.Rotate(Vector3.up, mouseX, Space.World);
            transform.Rotate(Vector3.right, -mouseY, Space.Self);
        }

        // Zoom while holding RIGHT mouse button
        if (Input.GetMouseButton(1))
        {
            float scroll = Input.GetAxis("Mouse Y") * zoomSpeed;
            currentZoom -= scroll;
            currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

            transform.localPosition = new Vector3(1.005f, 1.216f, -currentZoom);
        }
    }
}