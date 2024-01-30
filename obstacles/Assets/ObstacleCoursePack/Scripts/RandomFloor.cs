using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomFloor : MonoBehaviour
{
    [SerializeField] private Transform objectParent;
    // Start is called before the first frame update
    void Start()
    {
        Transform[] childs = objectParent.GetComponentsInChildren<Transform>(true);
        childs = Array.FindAll(childs, child => child != objectParent);

        Transform selectedChild = childs[Random.Range(0, childs.Length)];
        Rigidbody selectedRigidbody = selectedChild.GetComponent<Rigidbody>();

        selectedChild.gameObject.AddComponent<Rigidbody>().useGravity = false;


    }
}
