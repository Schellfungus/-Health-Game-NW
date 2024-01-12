using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HG_Neues_PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float jumpCooldown = 2f; // Zeit zwischen den Sprüngen

    private Rigidbody rb;
    private bool isGrounded;
    private bool canJump = true;

     [SerializeField] private GameObject footsteps;

    void Start()
    {
        Physics.gravity = new Vector3(0, -30, 0);
        rb = GetComponent<Rigidbody>();
        //  moveOnStart();
        footsteps = GameObject.FindWithTag("Footsteps");
        footsteps.SetActive(false);
    }

    void moveOnStart()
    {
        transform.position = new Vector3(-6, 40, 10);
    }

    void Update()
    {
        // Bewegung
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 moveVelocity = moveDirection * moveSpeed;
        rb.velocity = new Vector3(-moveVelocity.x, rb.velocity.y, -moveVelocity.z);

        // Springen
        if (canJump && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
            StartCoroutine(JumpCooldown());
        }
        if(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            ActiveFootsteos();
        }
        if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d"))
        {
            DeaktiveFootsteps();
        }


    }

    IEnumerator ActiveFootsteos()
    {
        yield return new WaitForSeconds(2);
        footsteps.SetActive(true);
    }
    private void DeaktiveFootsteps()
    {
        footsteps.SetActive(false); 
    }
    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(jumpCooldown);
        canJump = true;
    }
}
