using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public float BoostMultiplier = 1.5f;
    public float BoostSeconds = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.transform.parent.gameObject);
        Debug.Log("Jump boost!");

        PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();
        Player.JumpBoost(BoostMultiplier, BoostSeconds);
    }
}
