using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("inair", true);
        }
        else
        {
            anim.SetBool("inair", false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("punsh", true);
        }
        else
        {
            anim.SetBool("punsh", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }

    }
}
