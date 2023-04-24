using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private float speed = 15;

    // Start is called before the first frame update
    void Start()
    {
      
}

    // Update is called once per frame
    void Update()
    {
    transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);

    if (transform.position.y > 7f) { Destroy(this.gameObject); }
}

}
