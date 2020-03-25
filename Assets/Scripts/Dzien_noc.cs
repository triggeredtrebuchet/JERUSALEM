using UnityEngine;
using UnityEngine.UI;

public class Dzien_noc : MonoBehaviour
{
    public float szybkosc_slonca;

    void Update()
    {
        transform.Rotate(szybkosc_slonca * Time.deltaTime, 0, 0);
    }
}