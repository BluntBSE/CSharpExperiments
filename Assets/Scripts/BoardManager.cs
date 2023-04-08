using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject selectedObject = null;
    public bool isDragging = false;
    public Vector3 mousePosition;
    public Vector3 selectedObjectLift = new Vector3(0, 0, -1);
    public Vector3 offset;
    public Vector3 lastSelectedPosition;

    public GameObject SelectAnObject()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(
            origin: Camera.main.transform.position,
            //mousePosition is at the same depth as the camera. We need to offset for this Z value, hence the third vector.
            direction: (
                -Camera.main.transform.position
                + mousePosition
                - new Vector3(0, 0, Camera.main.transform.position.z)
            ).normalized,
            maxDistance: 1000f
        );
        Debug.Log(hits.Length);
        //TODO - This is bad. Conditional logic of if it's a valid selectable goes into this foreach loop tho.
        foreach (RaycastHit myhit in hits)
        {
            return myhit.transform.gameObject;
        }
        //If none found
        return null;
    }

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selectedObject = SelectAnObject();
            offset = selectedObject.transform.position - mousePosition;

            Debug.Log(offset);
        }
        //Debug.Log(selectedObject);

        if (selectedObject != null)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedObject.transform.position = mousePosition + offset;


        
        }

        if (Input.GetMouseButtonUp(0)){
            selectedObject.GetComponent<CardObject>().cardScriptToExecute.Execute();
            selectedObject = null;
            //Execute selected object's given script delegate;
        }

    }
}
