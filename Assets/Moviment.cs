using UnityEngine;

public class Moviment : MonoBehaviour
{
    int numero = 1;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-0.05f, 0, 0);

        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0.05f, 0);

        }
        Physics.CheckSphere(transform.position, 1f);
    }
}