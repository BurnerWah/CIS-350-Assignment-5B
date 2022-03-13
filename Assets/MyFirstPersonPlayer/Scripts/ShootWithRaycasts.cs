/*
 * Jaden Pleasants
 * Assignment 5B
 * Shoots stuff with raycasts
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour {
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    private void Shoot() {
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo)) {
            Debug.Log(hitInfo.transform.name);

            Target target = hitInfo.transform.GetComponent<Target>();
            target?.TakeDamage(damage);
        }
    }
}
