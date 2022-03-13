/*
 * Jaden Pleasants
 * Assignment 5B
 * Makes the player win when they walk into the trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour {
    public Text winText;

    void OnTriggerEnter(Collider theCollider) {
        if (theCollider.CompareTag("Player")) {
            winText.text = "You Win!";
            winText.gameObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
