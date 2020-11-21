using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromAttach : MonoBehaviour
{
    public GameObject player;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player) {

            player.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = null;
        }

    }
}
