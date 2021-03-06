﻿using UnityEngine;
using System.Collections;

public class SwitchController : MonoBehaviour {
	// switchOff reflects whether the switch is on ot off
	private bool switchOff = true;

	// determines whether the switch is enabled or not. If enabled the
	// player can toggle the switch by pressing the spacebar
	private bool switchEnabled = false;

	// switchAnimator will hold the gameobjects Animator
	private Animator switchAnimator;

    public BulbController bulbController;

	// The Awake function of each class is called before the Start function. It is
	// here you should initialise class properties/variables like those above.
	void Awake() {
		// Get the Animator off the game object this script is attached to as
		// we'll need it later
		switchAnimator = gameObject.GetComponent<Animator> ();

		// Let's turn off the switch to start with
		turnOff();
	}

	public void turnOn() {
		switchOff = false;
		switchAnimator.SetBool("SwitchOff", switchOff);
        bulbController.turnOn();
    }

	public void turnOff() {
		switchOff = true;
		switchAnimator.SetBool("SwitchOff", switchOff);
        bulbController.turnOff();
    }

	public void enableSwitch() {
		switchEnabled = true;
	}

	public void disableSwitch() {
		switchEnabled = false;
	}

	// The following function will toggle the switch but only if the 
	// switch is enabled
	public void toggleSwitch() {
		if (switchEnabled == true) {
            switchOff = !switchOff;
			switchAnimator.SetBool ("SwitchOff", switchOff);

            if (switchOff == false)
            {
                bulbController.turnOn();
            }

            if (switchOff == true)
            {
                bulbController.turnOff();
            }

        } else {
			Debug.Log ("Can't toggle switch as it's not enabled");
		}
	}
}
