using UnityEngine;
using System.Collections;
using Fungus;

public class Talkable1 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Flowchart.BroadcastFungusMessage("對講機");
    }
}
