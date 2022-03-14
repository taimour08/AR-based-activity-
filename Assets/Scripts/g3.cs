using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g3 : MonoBehaviour
{
    int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-170.07f, 111.81f, -114.23f);
    }

    // Update is called once per frame
    void Update()
    {
        x++;

        if (x > 300)
            transform.position = new Vector3(-7.03f, 1.14f, -4.18f);

        if (x > 480)
            transform.position = new Vector3(-170.07f, 111.81f, -114.23f);
    }
}