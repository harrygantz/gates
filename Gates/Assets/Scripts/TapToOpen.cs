using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToOpen : MonoBehaviour {
    
    public Animator _animator;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    
    private void OnMouseDown()
    {
        _animator.SetTrigger("Active");   
    }
}
