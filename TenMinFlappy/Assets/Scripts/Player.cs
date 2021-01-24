using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float forceSpeed;

    public bool isDead;
    public GameObject uyari;
    public Text skorText;
    int skor;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        isDead = false;
        uyari.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        skorText.text = skor.ToString();
        if (!isDead)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Zipla();
            }
        }
        else
        {
            uyari.SetActive(true);
        }
    }
    void Zipla()
    {
        rb.AddForce(Vector2.up * forceSpeed, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boru" || collision.gameObject.tag == "zemin")
        {
            isDead = true;
        }
        if (collision.gameObject.tag == "skorArea")
        {
            skor++;
        }
    }
}
