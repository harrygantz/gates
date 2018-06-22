﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour 
{
    private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag == "Bee")
            Destroy(target.gameObject);
    }
}
