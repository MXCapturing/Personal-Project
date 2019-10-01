using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    public FauxGravityAttractor attractor;
    private Transform myTransform;
    public Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        _rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        _rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myTransform);
    }
}
