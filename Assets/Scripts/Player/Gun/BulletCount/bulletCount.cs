using System;
using UnityEditor.PackageManager;
using UnityEngine;

public class bulletCount : ParticleActivation
{
    [SerializeField] public int _bulletNumber = 10;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            BulletCount(1);
            Debug.Log("shot a bullet");
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadBullet(10);
        }
    }

    public void BulletCount(int count)
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
}
