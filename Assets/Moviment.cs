using UnityEngine;

public class Moviment : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    private float moveSpeed = 20;
    private const float GRAVITY = -9.8f;
    public Vector3 forceApplied;

    void Start()
    {

    }


    void Update()
    {
        Vector3 inputDir = Vector3.zero;
        
        if (Input.GetKey("d"))
        {
            inputDir.x = 1;
        }
        else if (Input.GetKey("a"))
        {
            inputDir.x = -1;
        }
        else
        {
            inputDir.x = 0;
        }
        if (Input.GetKey("space"))
        {
            inputDir.y = 4;

        }
        else
        {
            inputDir.y = 0;
            CalculateGravity();
        }
            float multiplier = Time.deltaTime * moveSpeed;
        characterController.Move((inputDir + forceApplied) * multiplier);
    }
    public void CalculateGravity()
    {
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 1);
        if (isGrounded)
        {
            forceApplied.y = -2f;
        }
        else
        {
            forceApplied.y += GRAVITY;
        }
    }
}