using UnityEngine;
using System.Collections;

public class BallKick : MonoBehaviour
{
    public float kickForce = 15f;

    public Rigidbody rb;
    private bool isStopped = false;

    public bool isGoal = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Kick(Vector3 targetPosition)
    {
        Vector3 direction =
            (targetPosition - transform.position).normalized;

        rb.AddForce(direction * kickForce, ForceMode.Impulse);
    }
    
    public void StopInGoal()
    {
        if (isStopped) return;

        isStopped = true;
        isGoal = true;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.isKinematic = true;

        StartCoroutine(ReturnCamera());
    }

    IEnumerator ReturnCamera()
    {
        yield return new WaitForSeconds(2f);

        KickManager.instance.virtualCam.Follow = KickManager.instance.player;
    }
}