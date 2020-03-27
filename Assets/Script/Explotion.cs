using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{
    public GameObject blast;

    // Start is called before the first frame update
    void Start()
    {
        print("start");
        GameObject belast = (GameObject)Instantiate(blast);
        belast.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
