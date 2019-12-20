using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard : MonoBehaviour
{
    int steps = 200;
    int cpt = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-180, 180)));

    }

    // Update is called once per frame
    void Update()
    {
        if(cpt == steps)
        {
            cpt = 0;
            transform.Rotate(new Vector3(0, 0, 180));
        }
        else
        {
            transform.Translate(new Vector3(1*Time.deltaTime, 0, 0));
            cpt++;
        }
    }
}
