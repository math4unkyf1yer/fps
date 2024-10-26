using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject Player;
    private float Range = 3f;
    public HaveDoor haveDoorScript;

    private void Update()
    {
        float distance = Vector3.Distance(this.transform.position, Player.transform.position);

        if(Range > distance)
        {
            haveDoorScript.hasKey = true;
            Destroy(this.gameObject);
        }
    }
}
