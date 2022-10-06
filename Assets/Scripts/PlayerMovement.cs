using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField, Range(0, 10)] private float xMovementRange;
    [SerializeField, Range(0, 5)] private float yMovementRange;

    [SerializeField] private float xRotateSpeed;
    [SerializeField] private float zRotateSpeed;


    private Vector2 movementInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float nextXPos = Mathf.Clamp(transform.localPosition.x + movementInput.x * Time.deltaTime, -xMovementRange, xMovementRange);
        float nextYPos = Mathf.Clamp(transform.localPosition.y + movementInput.y * Time.deltaTime, -yMovementRange, yMovementRange);

        transform.localPosition = new Vector3(nextXPos, nextYPos, transform.localPosition.z);

        float nextXRot = transform.localPosition.y * xRotateSpeed;
        float nextZRot = transform.localPosition.x * zRotateSpeed;

        transform.localRotation = Quaternion.Euler(nextXRot, 0f, nextZRot);
    }

    void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>() * movementSpeed;
    }
}
