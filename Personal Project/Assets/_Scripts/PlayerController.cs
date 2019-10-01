using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 moveDir;
    public Rigidbody2D _rb;

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), 0).normalized;
    }

    private void FixedUpdate()
    {
        Vector2 globalMoveDir = (transform.TransformDirection(moveDir));
        _rb.MovePosition(_rb.position + globalMoveDir * speed * Time.deltaTime);
    }
}
