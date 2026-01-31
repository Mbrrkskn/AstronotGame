using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    Rigidbody2D rgb;
    public float mermihizi = 5f;
    public float mermiomru = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        rgb.velocity = transform.right * mermihizi;
        Destroy(gameObject, mermiomru);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dusman"))
        {
            Destroy(collision.gameObject);

        }
    }
}


