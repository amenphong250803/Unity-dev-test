using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public GameObject confettiEffect;

    private void OnTriggerEnter(Collider other)
    {
        BallKick ball = other.GetComponent<BallKick>();

        if (ball != null)
        {
            Instantiate(
                confettiEffect,
                transform.position + Vector3.up,
                Quaternion.identity
            );

            ball.StopInGoal();
        }
    }

}
