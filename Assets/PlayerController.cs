using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rb.velocity = new Vector2(speed, _rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.velocity = new Vector2(-speed, _rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
    }
}
