using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicePhysics : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    public Vector3 dicePosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> (); // initalize dice physics into variable
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        // button to drop the dice
        if(Input.GetKeyDown(KeyCode.Space) && diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {

            DiceNumberToText.diceNumber = 0;
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);
            transform.position = new Vector3(4, 10, -5);
            dicePosition = transform.position;
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 500);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
