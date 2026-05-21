using UnityEngine;
using Cinemachine;


public class KickManager : MonoBehaviour
{
    public static KickManager instance;

    
    public CinemachineVirtualCamera virtualCam;

    public Transform player;
    public Transform leftGoal;
    public Transform rightGoal;

    public BallKick currentBall;
    public BallKick[] allBalls;

    void Awake()
    {
        instance = this;
    }

    public void SetCurrentBall(BallKick ball)
    {
        currentBall = ball;
    }

    public void KickBall()
    {
        if (currentBall != null)
        {
            currentBall.Kick(GetNearestGoal(currentBall.transform).position);

            virtualCam.Follow = currentBall.transform;
        }
    }

    public void AutoKick()
    {
        BallKick farthestBall = null;
        float maxDistance = 0f;

        foreach (BallKick ball in allBalls)
        {
            if (ball.isGoal) continue;
            
            float distance = Vector3.Distance(
                player.position,
                ball.transform.position
            );

            if (distance > maxDistance)
            {
                maxDistance = distance;
                farthestBall = ball;
            }
        }

        if (farthestBall != null)
        {
            farthestBall.Kick(GetNearestGoal(farthestBall.transform).position);
            virtualCam.Follow = farthestBall.transform;
        }
    }

    Transform GetNearestGoal(Transform ball)
    {
        float leftDist = Vector3.Distance(
            ball.position,
            leftGoal.position
        );

        float rightDist = Vector3.Distance(
            ball.position,
            rightGoal.position
        );

        return leftDist < rightDist ? leftGoal : rightGoal;
    }
}