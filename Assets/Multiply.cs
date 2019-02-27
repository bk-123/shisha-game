using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour {

    public GameObject fruit;
    GameObject fruitClone;

    private void Start()
    {
        fruitClone = Instantiate(fruit.transform.position) as GameObject;
    }

    private GameObject Instantiate(object identity)
    {
        throw new NotImplementedException();
    }
}
