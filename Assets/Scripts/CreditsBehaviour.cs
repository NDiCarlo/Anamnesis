/*****************************************************************************
// File Name :         CreditsBehaviour.cs
// Author :            Diego Hudelson
// Creation Date :     November 25, 2021
//
// Brief Description : This just allowed an old version of the credits scene 
to work
*****************************************************************************/
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
