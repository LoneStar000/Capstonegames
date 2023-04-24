using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    Rigidbody2D AsteroidRB;
    public float speed = 1f;

    public float degreesPerSec = 360f;

    // Start is called before the first frame update
    void Start()
    {
        AsteroidRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotAmount = degreesPerSec * Time.deltaTime;
        float curRot = transform.localRotation.eulerAngles.z;


        transform.eulerAngles = Vector3.forward * speed * Time.deltaTime;
        AsteroidRB.velocity = -transform.right * speed;

        if (transform.position.magnitude > 100.0f)
        {
            Destroy(gameObject);

        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
