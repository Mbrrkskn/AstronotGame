using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silah : MonoBehaviour
{
    public Transform AtesNoktasi;
    public GameObject mermi;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AtesEt();
        }
    }
    void AtesEt()
    {
        if (mermi != null && AtesNoktasi != null)
        {
            Instantiate(mermi, AtesNoktasi.position, AtesNoktasi.rotation);
        }
        else
        {
            Debug.LogError("Mermi prefabý veya AtesNoktasý ayarlanmadý");
        }

    }

}
