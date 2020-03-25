using UnityEngine;

public class ZdarzeniaPlayera : MonoBehaviour
{
    // Update is called once per frame
    public Transform labirynt;
    public Rigidbody rb;
    public float sila_odskoku;

    void Update()
    {
        if (transform.position.y < -20f)
        {
            FindObjectOfType<GameManager>().GameEnd();
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Skocznia"))
        {
            rb.AddForce(labirynt.rotation.z * sila_odskoku * 10, sila_odskoku, labirynt.rotation.x * sila_odskoku);
        }
        else if (collisionInfo.collider.name == "Meta")
        {
            FindObjectOfType<GameManager>().GameWin();
        }
    }
}
