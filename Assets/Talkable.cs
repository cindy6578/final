using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fungus;//記得引用Fungus

public class Talkable : MonoBehaviour
{
    private HeadLookController headController;
    private GameObject FPSController;

    void Start()
    {
        headController = GetComponent<HeadLookController>();
        FPSController = GameObject.Find("FPSController");
    }

    void Update()
    {
        headController.target = FPSController.transform.position + new Vector3(0,0,1.5f);
    }

    void OnTriggerEnter()
    {
        Flowchart.BroadcastFungusMessage("對話1");
    }
}
