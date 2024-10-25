using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float rotation = 0;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        circlemovement();
        if (Input.GetKey(KeyCode.E))
        {
            movement();
            //gameObject.transform.Rotate(0f, 0f, 10f * Time.deltaTime * 10f);
            Debug.Log("cambio de direccion");
        }
    }

    void circlemovement()
    {
        rotation = rotation + 200 * Time.deltaTime;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
        gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
    }
    void movement()
    {
        rotation = -rotation;
    }

}
