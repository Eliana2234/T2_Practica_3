using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiController : MonoBehaviour
{
    public float velocity = 10f;
    private Rigidbody2D rb;

    private ControlPuntaje PuntajeC;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PuntajeC = FindObjectOfType<ControlPuntaje>();
        Destroy(this.gameObject, 3);
    }

    void Update()
    {
        rb.velocity = new Vector2(velocity, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            PuntajeC.AddPoints(10);
            Debug.Log(PuntajeC.GetPoint());
        }
    }
}
