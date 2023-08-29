using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Start":
                Debug.Log("Start");
                break;

            case "Finish":
                Debug.Log("Finish");
                break;

            case "Fuel":
                Debug.Log("Fuel");
                break;

            default:
                Debug.Log("Collision");
                break;
        }
    }
}
