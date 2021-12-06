using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsBehaviour : MonoBehaviour
{
    public GameObject thisObject;

    // Start is called before the first frame update
    void Start()
    {
        thisObject.SetActive(false);

        Invoke("Function", 85f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Function()
    {
        thisObject.SetActive(true);
    }
}
