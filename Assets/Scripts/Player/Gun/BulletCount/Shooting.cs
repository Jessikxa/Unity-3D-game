using System;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : ParticleActivation
{
    [SerializeField] public int _bulletNumber = 10;
    public UnityEvent<int> OnShoot = new UnityEvent<int>();

    private void Start()
    {
        OnShoot.AddListener(hasShot);
    }

   

    void Update()
    { 

        if (Input.GetKeyDown(KeyCode.E)) // shooting
        {
            BulletCount(1);
            Debug.Log("shot a bullet");
            OnShoot.Invoke(1);
        }


        if (Input.GetKeyDown(KeyCode.R)) // reloading
        {
            ReloadBullet(10);
        }

    }

    public void BulletCount(int count) // amount of bullets
    {
        if (_bulletNumber > 0)
        {
            _bulletNumber -= count;
        }


        if (_bulletNumber <= 0)
        {
            _collectParticle.Stop();
            _collectParticle.Pause();
            _collectParticle.Clear();
        }

    }

    public void ReloadBullet(int count)
    {
        if (_bulletNumber <= 0)
        {
            _bulletNumber = count;
        }
        else
        {
            Debug.Log("You have bullets!");
        }
    }


    private void hasShot(int ammoAmount)
    {
        print($"almost no ammo left. you have {ammoAmount} bullets");
    }
}
