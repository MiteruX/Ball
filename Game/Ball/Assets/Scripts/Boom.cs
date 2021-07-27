using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    private float time;
    public float size;
    private void Update()
    {
        transform.localScale = new Vector3(size, size, size);
        if (time > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            time += Time.deltaTime;
        }
    }

    
}
