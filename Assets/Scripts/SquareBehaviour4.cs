using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBehaviour4 : MonoBehaviour
{
    int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-170.07f, 111.81f, -114.23f);
    }

    // Update is called once per frame.
    void Update()
    {
        x++;

        if(x > 150)
        transform.position = new Vector3(-7.07f, 1.81f, -4.23f);

        if (x > 300)
        transform.position = new Vector3(-170.07f, 111.81f, -114.23f);
    }
}
