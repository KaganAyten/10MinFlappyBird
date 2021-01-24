using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boru : MonoBehaviour
{
    //-2.1 to 4.4
    [SerializeField]
    float hareketHizi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -2.1f)
        {
            transform.position = new Vector3(4.4f, transform.position.y, transform.position.z);
        }
        gameObject.transform.Translate(-hareketHizi * Time.deltaTime, 0, 0);

    }
}
