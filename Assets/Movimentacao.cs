using UnityEngine;
using UnityEngine.InputSystem;

public class Movimentacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
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
        if (Input.GetKey("space"))
        {
            transform.Translate(0, 0.05f, 0);
        }

    }
}
