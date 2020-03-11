using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject box;

    public void Trigger(){
        box.active = true;
    }
}
