using UnityEngine;
using System.Collections;


public class NewBehaviourScript : MonoBehaviour
{

    Vector3 startPos;

    private Vector3 offset;
    private Vector3 oldPos;

    void OnMouseDown()
    {

        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }

    void OnMouseUp()
    {
        transform.position = oldPos;
    }

}
