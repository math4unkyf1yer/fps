using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class HaveDoor : MonoBehaviour
{
    public bool hasKey;
    private float range = 4f;
    public GameObject player;
    public Animator doorAnimation;
    public GameObject effectDoor;

    private void Update()
    {
        float distance = Vector3.Distance(this.transform.position, player.transform.position);

        if (range > distance && hasKey == true)
        {
            hasKey = false;
            effectDoor.gameObject.SetActive(true);
            doorAnimation.SetBool("MoveDoor", true);
            StartCoroutine(waitForDestroy());
        }
    }
    IEnumerator waitForDestroy()
    {
        yield return new WaitForSeconds(1.4f);
        effectDoor.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
