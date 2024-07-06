using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (CharacterController))]
[AddComponentMenu("Control Script/FPSinput ")]
public class FPSinput : MonoBehaviour
{

    public float speed = 6f;
    public float gravity = -9.8f;
    private CharacterController _charController;
    // Update is called once per frame
    void Start() {
        _charController = GetComponent<CharacterController>();
    }
    void Update()
    {
        //transform.Translate(speed, 0, 0);
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        //transform.Translate(deltaX*Time.deltaTime, 0, deltaZ* Time.deltaTime);
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
    }
}
