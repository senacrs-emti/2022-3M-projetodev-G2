using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{

    [SerializeField] float Speed;
    [SerializeField] float MaxDistance = 10;
    [SerializeField] int Damage = 5;

    private Rigidbody2D rb2d;
    private float conquaredDistance = 0; 

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colliderd " + collision.name);
        Destroy(gameObject);
    }
}
