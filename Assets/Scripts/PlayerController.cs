using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 5f;

    public InputActionReference moveAction;

    private CharacterController controller;

    private Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    void OnEnable()
    {
        moveAction.action.Enable();
    }

    void OnDisable()
    {
        moveAction.action.Disable();
    }

    void Update()
    {
        Move();
    }

    void Move()
{
    Vector2 input = moveAction.action.ReadValue<Vector2>();

    Vector3 move = new Vector3(-input.y, 0, input.x);

    bool isMoving = move.magnitude > 0.1f;

    animator.SetBool("isRunning", isMoving);

    if (isMoving)
    {
        controller.Move(move.normalized * moveSpeed * Time.deltaTime);

        Quaternion targetRotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(move),
            rotateSpeed * Time.deltaTime
        );

        transform.rotation = targetRotation;
    }
}
}