using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PropertyPanelController : MonoBehaviour
{
    //public InputField inputX, inputY, inputZ;
    public TMP_InputField inputX, inputY, inputZ;
    public Button applyButton;
    private GameObject selectedObject;
    public bool isEditing = false;  

    void Start()
    {
        applyButton.onClick.AddListener(UpdatePosition);
    }

    void Update()
    {
        if (selectedObject != null && !isEditing) // Updated value from UI 
        {
            Vector3 pos = selectedObject.transform.position;
            inputX.text = pos.x.ToString("F2");
            inputY.text = pos.y.ToString("F2");
            inputZ.text = pos.z.ToString("F2");
        }
    }

    public void SetSelectedObject(GameObject obj)
    {
        selectedObject = obj;
        isEditing = false;  
    }

    public void UpdatePosition()
    {
        if (selectedObject != null)
        {
            //print("update");
            float x, y, z;
            if (float.TryParse(inputX.text, out x) &&
                float.TryParse(inputY.text, out y) &&
                float.TryParse(inputZ.text, out z))
            {
                
                selectedObject.transform.position = new Vector3(x, y, z);
                isEditing = false;  
            }
        }
    }

    public void StartEditing()
    {
        isEditing = true;  
    }
}
