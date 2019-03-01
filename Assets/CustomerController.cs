using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerController : MonoBehaviour {
    public float customerPatience = 60.0f;
    public int customerNeeds;
    public GameObject productOrderPosition;
    public bool showFlavour = true;
    public int mySeat;                         
    public Vector3 destination;
    public GameObject shishaHead;

    private bool orderFullfilled;
    private bool slot;

    public GameObject[] Flavours;

    private int flavours;
    private int[] flavoursIDs;
    private bool isOnSeat;
    private bool orderIsFullfilled;

    internal float leaveTime;
    private float creationTime;
    private bool isLeaving;
    public GameObject requestBubble;

    private Vector3 startingPosition;

    void Awake()
    {
        requestBubble.SetActive(false);
        orderFullfilled = false;
        leaveTime = 0;
        isLeaving = false;
        creationTime = Time.time;
        startingPosition = transform.position;
        shishaHead = GameObject.FindGameObjectWithTag("Slot");
       
    }

    private GameObject productImage;
    private GameObject[] helperFlavours;

    void Init()
    {
        if (customerNeeds == 0);

        else
        customerNeeds = Random.Range(0, Flavours.Length);
        



    }










}
