using UnityEngine;

public class ArmController : MonoBehaviour {
    private Animator animator;
    public float walkThreshold = 0.1f;

    void Start() {
        animator = GetComponent<Animator>();
    }

    void Update() {
        // Check if player is moving (WASD or joystick input)
        float moveInput = Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"));
        bool isWalking = moveInput > walkThreshold;

        animator.SetBool("IsWalking", isWalking);
        
    }
}