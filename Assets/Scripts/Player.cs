using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TG
{

public class Player : MonoBehaviour
{
    public float playerSpeedX;
    public float playerSpeedY;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(directionX,directionY).normalized;


        


    }
    void FixedUpdate() 
    {
        rb.velocity = new Vector2(playerDirection.x * playerSpeedX, playerDirection.y * playerSpeedY);
     
    }
}

}

