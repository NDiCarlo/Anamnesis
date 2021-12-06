/*****************************************************************************
// File Name :         ParentBossAttackBehaviour.cs
// Author :            Diego Hudelson
// Creation Date :     November 25, 2021
//
// Brief Description : This is the Parent Attack and how long it lasts on
screen
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBossAttackBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, .2f);
    }
}