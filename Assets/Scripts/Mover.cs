using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField]
    [Tooltip("How many meters per second to move when action is pressed")]
    private float speed = 10;

    private void OnEnable()
    {
        moveRight.Enable();
        moveLeft.Enable();
        moveUp.Enable();
        moveDown.Enable();
    }

    private void OnDisable()
    {
        moveRight.Disable();
        moveLeft.Disable();
        moveUp.Disable();
        moveDown.Disable();
    }

    void Update()
    {
        if (moveRight.IsPressed())
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (moveLeft.IsPressed())
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (moveUp.IsPressed())
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (moveDown.IsPressed())
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}