using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectSelection : MonoBehaviour
{
    public PropertyPanelController propertyPanel;
    private GameObject selectedObject;
    private Renderer selectedRenderer;
    private Color originalColor;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.transform.gameObject.name);
                SelectObject(hit.transform.gameObject);
            }
        }
    }

    void SelectObject(GameObject obj)
    {
        // Reset previous object color
        if (selectedRenderer != null)
        {
            selectedRenderer.material.color = originalColor;
        }

        selectedObject = obj;
        propertyPanel.SetSelectedObject(selectedObject);

        // Highlight selected object
        selectedRenderer = selectedObject.GetComponent<Renderer>();
        if (selectedRenderer != null)
        {
            originalColor = selectedRenderer.material.color;
            selectedRenderer.material.color = Color.yellow; 
        }
    }
}

