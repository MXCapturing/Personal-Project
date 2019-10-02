using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    public float speed;
    public float returnSpeed;
    public float distance;

    private float _distance;
    private bool _back;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        _distance = 0;
        _back = false;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float travel = speed * Time.deltaTime;

        if (!_back)
        {
            transform.Translate(Vector2.right * travel);
            _distance += travel;
            _back = _distance >= distance;
        }
        else
        {
            this.transform.position = Vector2.MoveTowards(transform.position, player.transform.position, travel * returnSpeed);
            if (Vector2.Distance(this.transform.position, player.transform.position) < 0.1f)
            {
                Destroy(gameObject);
            }
        }
    }
}
