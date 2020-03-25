using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchKamery : MonoBehaviour
{
    public Transform PilkaGracza;
    public float CzuloscKamery = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PilkaGracza.position.x * CzuloscKamery, 30, PilkaGracza.position.z * CzuloscKamery);
    }
}
