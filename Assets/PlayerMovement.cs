using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public Rigidbody2D rigid;
    public bool jump;

    // Use this for initialization
    void Start()
    {
        Rigidbody2D rigid = Player.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        jump = true;
        print("worked");
    }

    // Update is called once per frame
    void Update()
    {
        float move = 1 * Time.deltaTime;
        if (Input.GetKey("d"))
        {
            transform.Translate(move, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-1 * move, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            if (jump == true)
            {
                rigid.AddForce(Vector2.up * 200);
                jump = false;
            }
        }
    }
}
