using UnityEngine;
using System.Collections;
using System;

public class IngredientsController : MonoBehaviour
{

    public GameObject[] ingredientsArray;
    public int factoryID;
    public bool needsProcess = false;      
    public string processorTag = "";       


    private float delayTime;               
    private bool canCreate = true;          

    public static bool itemIsInHand;       
                                            

    void Awake()
    {
        delayTime = 1.0f;
        itemIsInHand = false;
    }

    void Update()
    {
        managePlayerDrag();

        if (Input.touches.Length < 1 && !Input.GetMouseButton(0))
        {
            itemIsInHand = false;
        }

       
    }

    private RaycastHit hitInfo;
    private Ray ray;
    void managePlayerDrag()
    {
        
        if (Input.touches.Length > 0 && Input.touches[0].phase == TouchPhase.Moved)
            ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
        else if (Input.GetMouseButtonDown(0))
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        else
            return;

        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject objectHit = hitInfo.transform.gameObject;       
            }
        }
    }

