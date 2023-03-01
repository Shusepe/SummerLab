using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ketchup : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("HotDog"))
        {
            Destroy(gameObject);
        }
    }
}
