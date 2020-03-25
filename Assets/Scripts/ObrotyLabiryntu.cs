using UnityEngine;

public class ObrotyLabiryntu : MonoBehaviour
{
    public float SilaObrotowa = 5f;
    float b;

    private void Start()
    {
        b = 0.13f * SilaObrotowa;
    }

    void FixedUpdate()
    {
        if(Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, 0 ,SilaObrotowa));
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 0, -SilaObrotowa));
        }
        if (Input.GetKey("w"))
        {
            transform.Rotate(new Vector3(SilaObrotowa, 0, 0));
        }
        if (Input.GetKey("s"))
        {
            transform.Rotate(new Vector3(-SilaObrotowa, 0,0));
        }

        transform.Rotate(new Vector3(0, 0, b - SilaObrotowa * transform.rotation.z));
        transform.Rotate(new Vector3(0, 0, -SilaObrotowa * transform.rotation.z - b));
        transform.Rotate(new Vector3(b - SilaObrotowa * transform.rotation.x, 0, 0));
        transform.Rotate(new Vector3(-SilaObrotowa * transform.rotation.x - b, 0, 0));

    }
}
