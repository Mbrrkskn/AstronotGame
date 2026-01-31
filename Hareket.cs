using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    // Start is called before the first frame update
    public float k = 0.1f; //kat sayı için 
    int saglik;
    public bool sagabakalim = true;

    void Start()
    {
        saglik = 100;
        Debug.Log("Saglık degeri: " + saglik);
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");

        // Debug.Log(yatay);
        transform.position += new Vector3(yatay * k * Time.deltaTime, 0, 0);
        //Debug.Log(Time.deltaTime);

        float dikey = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, dikey * k * Time.deltaTime, 0);



        if ((yatay > 0) && sagabakalim == false) //sağ ok tuşuna basılmışsa
        {
            Donus();
        }
        if ((yatay < 0) && sagabakalim == true)
        {
            Donus();
        }

    }
    void Donus()
    {
        sagabakalim = !sagabakalim;
        transform.Rotate(0, 180, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spike") //Spike sağlık azaltsın -50 olsun
        {

            saglik -= 20;
            Debug.Log("Spike " + saglik);
        }
        if (collision.tag == "Cakil") //Cakil  sağlık azaltsın -10 olsun
        {
            saglik -= 10;
            Debug.Log("Cakil " + saglik);
        }
        if (collision.tag == "Kristal") //Kristal  sağlık attırsın +10 olsun
        {
            Destroy(collision.gameObject); //Kristale değince kristal yok oluyor
            saglik += 10;
            Debug.Log("Kristal " + saglik);
        }
        if (collision.tag == "Agac")
        {
            Destroy(collision.gameObject); //Ağaca değince ağaç yok oluyor
            saglik += 50;
            Debug.Log("Agac " + saglik);  //Agac sağlık attırsın +50 olsun
        }
        if (collision.tag == "Dusman") //Spike sağlık azaltsın -50 olsun
        {
            Destroy(collision.gameObject);
            Destroy(gameObject); //Spike deyince astronot yok oluyor

        }

    }
}
