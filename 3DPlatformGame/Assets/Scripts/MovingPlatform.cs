using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player;
    public Transform startPosition;
    public Transform targetPosition;
    public float speed;
    public float t;
    // note: higher speed values translates to slower speed movement
    // and slower speed value translates to faster speed movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 start = startPosition.position;
        Vector3 end = targetPosition.position;
        transform.position = Vector3.Lerp(start, end, Mathf.PingPong(Time.time / speed, 1));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
