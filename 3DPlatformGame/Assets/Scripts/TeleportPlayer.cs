using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] GameObject Teleport01;

    Vector3 TPLocation01;

    // Start is called before the first frame update
    void Start()
    {
        TPLocation01 = Teleport01.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lava")
        {
            TeleportOurPlayer(TPLocation01);
        }
    }

    void TeleportOurPlayer(Vector3 TPLocation)
    {
        gameObject.transform.position = TPLocation;
        Debug.Log(TPLocation + "TELEPORT!");
    }
}
