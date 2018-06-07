using UnityEngine;
using System.Collections;
using Fungus;//記得引用Fungus

public class Talkable : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Flowchart.BroadcastFungusMessage("對話1");
    }
}
