using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour {

    private Animator bulbAnimator;

    public void Awake()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();

        turnOff();
    }

    public void turnOn()
    {
        bulbAnimator.SetBool("BulbOff", false);
    }

    public void turnOff()
    {
        bulbAnimator.SetBool("BulbOff", true);
    }
}
