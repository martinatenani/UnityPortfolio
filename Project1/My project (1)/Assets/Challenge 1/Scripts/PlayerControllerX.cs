using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
     float speed = 0.5f;

    public GameObject propeller;
    private float propSpeed = 200.0f;
    private int spinProp = 0;

    private float rotationSpeed = 50f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed/10); //Damped a bit the speed

        // tilt the plane up/down based on up/down arrow key
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);

        if (verticalInput != 0){
            spinProp = 0;
        }
        else{
            spinProp = 1;
        }

        //Spinning propeller
        propeller.transform.Rotate(Vector3.forward, propSpeed * Time.deltaTime * spinProp);
   
    }
}
