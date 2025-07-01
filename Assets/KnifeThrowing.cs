using System;
using NUnit.Framework.Internal.Filters;
using UnityEngine;

public class KnifeThrowing : MonoBehaviour
{

    public Transform cam;
    public Transform spawnPoint;
    public GameObject knife;
    


    public int totalThrows;
    public float throwCoolDown;

    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float ThrowUpwardForce;

    bool readyToThrow;

    void Start()
    {
        readyToThrow = true;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && readyToThrow && totalThrows > 0)
        {
            Throw();
        }
    }

    private void Throw()
    {
        readyToThrow = false;

        GameObject projectile = Instantiate(knife, spawnPoint.position, cam.rotation);

        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 forceDirection = cam.transform.forward;

        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
        {
            forceDirection = (hit.point - spawnPoint.position).normalized;
        }

        Vector3 forceToAdd = cam.position * throwForce + transform.up * ThrowUpwardForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);
        totalThrows--;

        Invoke(nameof(ResetThrow), throwCoolDown);
        //Destroy(knife, 1f);
    }

    private void ResetThrow()
    {
        readyToThrow = true;
    }
    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetMouseButtonDown(0)) 
    //        launched = true;
    //}

    //private void FixedUpdate()
    //{
    //    if (launched)
    //    {
    //        ThrowingKnife();
    //    }
    //}

    //private void ThrowingKnife()
    //{
    //    GameObject KnifeInstance = Instantiate(knife, spawnPoint.position, knife.transform.rotation);
    //    KnifeInstance.transform.rotation = Quaternion.LookRotation(-spawnPoint.forward);
    //    Rigidbody KnifeRig = KnifeInstance.GetComponent<Rigidbody>();

    //    KnifeRig.AddForce(spawnPoint.forward * _speed, ForceMode.Impulse);
    //    launched = false
    //}
}
