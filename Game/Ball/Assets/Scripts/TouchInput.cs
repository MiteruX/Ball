using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private float timer;
    public Player player;
    private bool isFirst = true;
    public bool isReloaded = true;
    private float factor;
    private float allsize = 2;
    void Update()
    {
        factor = Time.deltaTime * 0.5f;
        if (Input.touchCount > 0 && isReloaded && timer < allsize)
        {
            if (isFirst)
            {
                player.InstantiateBullet();
            }
            player.isShoting = true;
            player.size -= factor;
            player.BulletNow.size += factor;
            timer += factor;
            allsize = player.size + player.BulletNow.size;
            isFirst = false;
        }
        if (Input.touchCount == 0 && timer > 0)
        {
            player.isShoting = false;
            isReloaded = false;
            player.Shoot();
            isFirst = true;
            timer = 0;
        }
    }

    

}
