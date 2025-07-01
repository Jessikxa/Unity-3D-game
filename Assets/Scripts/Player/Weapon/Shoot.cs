using System;
using TMPro;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform FirePoint;
    [SerializeField] public int _bulletNumber = 10;
    [SerializeField] private TextMeshProUGUI _uiAmmo;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    public audioConfig audioConfig;

    private AudioSource ShootingAudioSource;

    private void Start()
    {
        ShootingAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            BulletCount(1);
            //Shooting();
        }

        if (Input.GetKeyDown(KeyCode.R)) // reloading
        {
            ReloadBullet(10);
        }

    }

    private void Shooting()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(FirePoint.transform.position, FirePoint.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);

            ShootThem enemy = hit.transform.GetComponent<ShootThem>();
            //BackAndForthMovement target = hit.transform.GetComponent<BackAndForthMovement>();
            if(enemy != null)
            {
                enemy.TakeDamage(10);
            }
            GameObject ImpactHit =Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            //Destroy(ImpactHit, 2f );
        }


    }

    public void BulletCount(int count) // amount of bullets
    {
        

        if (_bulletNumber > 0)
        {
            Shooting();
            PlayFireSound();
            _bulletNumber -= count;
            _uiAmmo.text = "AMMO:" + _bulletNumber.ToString();
        }
        else
        {
            muzzleFlash.Stop();
            Debug.Log("Reload. You dont have bullets.");
        }

        //if (_bulletNumber <= 0)
        //{
        //    _collectParticle.Stop();
        //    _collectParticle.Pause();
        //    _collectParticle.Clear();
        //}

    }

    public void ReloadBullet(int count)
    {
        if (_bulletNumber <= 0)
        {
            muzzleFlash.Stop();
            _bulletNumber = count;
            _uiAmmo.text = "AMMO:" + _bulletNumber.ToString();
        }
        else
        {
            Debug.Log("You have bullets!");
        }
    }

    private void PlayFireSound()
    {
        if (audioConfig.fireclips != null && ShootingAudioSource != null)
        {
            ShootingAudioSource.PlayOneShot(audioConfig.fireclips);
        }
    }

    private void OnDisable()
    {
        print("Kikker");
        muzzleFlash.Stop();
    }
}
