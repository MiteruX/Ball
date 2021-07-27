using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float size = 0.2f;
    public float speed;
    public bool isShoot;
    private Rigidbody rb;
    private Player player;
    public GameObject Boom;
    [HideInInspector] public Boom BoomNow;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }
    void Update()
    {
        transform.localScale = new Vector3(size, size, size);
        if (isShoot)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            player.touchInput.isReloaded = true;
            BoomNow = Instantiate(Boom, transform.position, Quaternion.identity).GetComponent<Boom>();
            BoomNow.size = size * 5;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }

}
