using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        speed = 3.0f;

        //Player Movement Code
        //read the input of the horizontal and vertical, store them in a variable
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log("The vertical is " + verticalInput + " and the horizontal is " + horizontalInput);
        Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);

        //move the player based on the values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);
    }
}
