using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float speed = new Vector2(horizontal, vertical).magnitude;

        animator.SetFloat("Speed", speed);
        animator.SetBool("IsGrounded", controller.isGrounded);

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            animator.SetTrigger("JumpTrigger");
        }
    }
}