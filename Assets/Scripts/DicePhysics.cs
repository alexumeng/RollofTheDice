using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicePhysics : MonoBehaviour
{
    static Rigidbody rb;
    public Collider diceCol;
    public static Vector3 diceVelocity;
    public Vector3 dicePosition;
    public int pickRoll;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> (); // initalize dice physics into variable
        diceCol = GetComponent<Collider>();
        pickRoll = 0;
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        // button to drop the dice
        if(Input.GetKeyDown(KeyCode.Space) && diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f && pickRoll < 3)
        {
            DiceNumberToText.diceNumber = 0;
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);
            if (diceCol.attachedRigidbody.useGravity == false)
            {
                diceCol.attachedRigidbody.useGravity = true;
                transform.rotation = Quaternion.identity;
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 500);
            }
            //transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
            dicePosition = transform.position;
            transform.rotation = Quaternion.identity;
            //rb.AddForce(transform.up * 500);
            rb.AddTorque(dirX, dirY, dirZ);
            pickRoll++;
        }
        else if (pickRoll > 3)
        {
            // need to fix
            DiceNumberToText.diceOutcome = "Sending to Map...";
        }
    }
}
