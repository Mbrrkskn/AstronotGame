using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YerKontrol : MonoBehaviour
{
    public LayerMask layer;
    public Rigidbody2D rb2d;
    public bool yerdeyiz;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D carpma = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, layer); //carpma yerinin tanýmlýyourz ,zýplatma olayý (collider'dan da yapýlabiliyor)
        if (carpma.collider != null)
        {
            yerdeyiz = true;
        }
        else
        {
            yerdeyiz = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && yerdeyiz == true)
        {
            rb2d.velocity += new Vector2(0, 7f);
        }
    }
}
