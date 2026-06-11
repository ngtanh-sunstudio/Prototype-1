using Unity;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 20f;

    public InputAction moveAction;
    private Vector2 moveInput;

    void OnEnable()
    {
        moveAction.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the vehicle forward/backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // Rotate the vehicle left/right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }

    void OnDisable()
    {
        moveAction.Disable();
    }
}
