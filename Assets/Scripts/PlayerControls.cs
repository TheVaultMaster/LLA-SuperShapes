using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //movement speed
    [Header("Default Movement Speed")]
    public float moveSpeed = 200;
    //movement float
    float movement = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Timescale is the speed the game runs at
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement equal to Left and Right input
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        //Object transformation rotates around
        //an object using the settings.
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Set the game speed to 0
        Time.timeScale = 0;
    }
}
