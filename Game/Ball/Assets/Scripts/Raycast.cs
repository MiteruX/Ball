using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Player Player;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Player.isMoving = false;
        }
        else
        {
            Player.isMoving = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Player.isMoving = true;
    }
}
