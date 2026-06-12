using Unity;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 20f;

    public InputAction moveAction;
    private Vector2 moveInput;

    public InputAction switchCameraAction;
    public FollowPlayer followPlayerScript;
    private bool isSwitched;

    void OnEnable()
    {
        moveAction.Enable();
        switchCameraAction.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        followPlayerScript = GameObject.Find("Main Camera").GetComponent<FollowPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the vehicle forward/backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // Rotate the vehicle left/right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);

        if (switchCameraAction.triggered)
        {
            followPlayerScript.offset = !isSwitched ? new Vector3(0f, 3f, 3.5f) : new Vector3(0, 5, -10);
            isSwitched = !isSwitched;
        }
    }

    void OnDisable()
    {
        moveAction.Disable();
        switchCameraAction.Disable();
    }
}
