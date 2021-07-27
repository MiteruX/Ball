using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float size;
    public float speed;
    public bool isMoving;
    public bool isShoting;
    public TouchInput touchInput;
    public GameObject Bullet;
    [HideInInspector] public Bullet BulletNow = null;

    void Update()
    {
        if (isMoving && !isShoting)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
        transform.localScale = new Vector3(size, size, size);
        if (size <= 0.35f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lose");
        }
    }

    public void InstantiateBullet()
    {
        BulletNow = Instantiate(Bullet, new Vector3(transform.position.x, -0.4f, transform.position.z + 2f), Quaternion.identity).GetComponent<Bullet>();
    }
    public void Shoot()
    {
        BulletNow.isShoot = true;
    }

}
