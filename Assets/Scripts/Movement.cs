using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public float speed;
    public float sensivity;
    public float t;

    private float xRotation = 0;
    private float yRotation = 0;

    void Update()
    {


        float mouseX = Input.GetAxis("Mouse X") * sensivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensivity;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);


        if (Input.GetKey(KeyCode.Z))
            transform.Translate(new Vector3(0, 0, speed*Time.deltaTime));


        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0, 0, (-1)* speed * Time.deltaTime));

        if (Input.GetKey(KeyCode.Q))
            transform.Translate(new Vector3((-1) * speed * Time.deltaTime, 0, 0));


        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));


        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector3(0, (-1)* speed * Time.deltaTime, 0));

    }
}
