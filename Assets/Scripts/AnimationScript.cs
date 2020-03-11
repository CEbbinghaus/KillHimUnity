using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start(){
        anim = GetComponent<Animator>();
    }

    /// <summary>
    /// SInetgugasudiwag
    /// </summary>
    void OnCollisionEnter(){
        anim.SetBool("isDead", true);
    }
    
    /// <summary>
    /// Function to Test stuff
    /// </summary>
    /// <param name="a">Int for Value</param>
    /// <param name="b">String for Name</param>
    void Test(int a, string b){

    }
}
