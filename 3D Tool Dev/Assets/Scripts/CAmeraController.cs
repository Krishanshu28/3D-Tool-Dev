using UnityEngine;

public class CAmeraController : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float rotateSpeed = 2f;
    public float panSpeed = 0.1f;  
    public Transform targetObject;

    private Vector3 lastMousePos;
    
    private bool isPanning = false;

    void Update()
    {
        HandleZoom();
        HandleRotation();
        HandlePanning();
        HandleFocus();
    }

    void HandleZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0f)
        {
            transform.position += transform.forward * scroll * zoomSpeed;
        }
    }

    void HandleRotation()
    {
        if (Input.GetMouseButton(1)) 
        {
            Vector3 delta = Input.mousePosition - lastMousePos;
            float posX = delta.x * rotateSpeed;
            float posY = -delta.y * rotateSpeed;

            transform.RotateAround(transform.position, Vector3.up, posX);
            transform.RotateAround(transform.position, transform.right, posY);
        }
        lastMousePos = Input.mousePosition;
    }

    void HandlePanning()
    {
        if (Input.GetMouseButtonDown(2)) 
        {
            isPanning = true;
            lastMousePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(2) && isPanning) 
        {
            float moveX = -Input.GetAxis("Mouse X") * panSpeed * 10f;
            float moveY = -Input.GetAxis("Mouse Y") * panSpeed * 10f;
            transform.Translate(new Vector3(moveX, moveY, 0), Space.Self);
        }

        if (Input.GetMouseButtonUp(2)) 
        {
            isPanning = false;
        }


    }
    

    void HandleFocus()
    {
        if (Input.GetKeyDown(KeyCode.L) && targetObject != null)
        {
            transform.position = targetObject.position + new Vector3(0, 2, -5);
            transform.LookAt(targetObject);
        }
    }

    public void SetFocusObject(Transform obj)
    {
        targetObject = obj;
    }
}
