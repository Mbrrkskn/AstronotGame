using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziplama : MonoBehaviour
{
    private Rigidbody2D rgb;
    [SerializeField] float ZiplamaKuvveti;
    [SerializeField] Transform feetKonum;
    [SerializeField] float radius;
    [SerializeField] LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && YerdeMiyiz())
        {
            rgb.AddForce(Vector2.up * ZiplamaKuvveti, ForceMode2D.Impulse);  //bir kereye mahsus zýplama yapsýn (Impulse)

        }
    }
    bool YerdeMiyiz()
    {
        return Physics2D.OverlapCircle(feetKonum.position, radius, layer);


    }

}
