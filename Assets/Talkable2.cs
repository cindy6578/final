using UnityEngine;
using System.Collections;
using Fungus;

public class Talkable2 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Flowchart.BroadcastFungusMessage("doctor");
    }
}

