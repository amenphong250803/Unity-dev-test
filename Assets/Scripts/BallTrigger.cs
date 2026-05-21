using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    public GameObject kickButton;

    private BallKick ballKick;

    private void Start()
    {
        ballKick = GetComponent<BallKick>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kickButton.SetActive(true);

            KickManager.instance.SetCurrentBall(ballKick);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kickButton.SetActive(false);

            KickManager.instance.SetCurrentBall(null);
        }
    }
}