using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstaction : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey("up")){
            anim.ResetTrigger("pelear");
            anim.ResetTrigger("disparar");
            anim.ResetTrigger("parar");
            anim.SetTrigger("caminar");
        }
        if(Input.GetKey("space")){
            anim.ResetTrigger("danzar");
            anim.ResetTrigger("caminar");
            anim.SetTrigger("parar");
        }
        if(Input.GetKey("d")){
            anim.ResetTrigger("parar");
            anim.SetTrigger("danzar");
        }
         if(Input.GetKey("p")){
            anim.ResetTrigger("caminar");
            anim.SetTrigger("pelear");
        }
        if(Input.GetKey("l")){
            anim.ResetTrigger("caminar");
            anim.SetTrigger("disparar");
        }

    }
}
