using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    private float horizontalInput;
    private Rigidbody2D playerRB;
    public float moveForce;

    // Start is called before the first frame update
    void Start()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.AddForce(Vector2.right * moveForce, ForceMode2D.Impulse);
    }
}
