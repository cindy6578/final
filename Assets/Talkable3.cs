using UnityEngine;
using System.Collections;
using Fungus;

public class Talkable3 : MonoBehaviour
{
    void OnTriggerEnter()
    {

        Flowchart.BroadcastFungusMessage("302");

    }
}
