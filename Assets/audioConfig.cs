using UnityEngine;


//[CreateAssetMenu(fileName = "Audio Config", menuName = "Guns/Audio Config", order = 5)]
public class audioConfig : MonoBehaviour
{
    [Range(0f, 1f)]
    public float volume = 1f;
    public AudioClip fireclips;
    //public AudioClip EmptyClip;
    //public AudioClip ReloadClip;
    //public AudioClip LasBulletClip;

    //public void PlayShootingClip(AudioSource AudioSource, bool IsLastBullet = false)
    //{
    //    if (IsLastBullet && LasBulletClip != null)
    //    {
    //        AudioSource.PlayOneShot(LasBulletClip, volume);
    //    }
    //    else
    //    {
    //        AudioSource.PlayOneShot(fireclips[Random.Range(0, fireclips.Length)], volume);
    //    }
    //}

    //public void PlayOutOfAmmoClip(AudioSource audioSource)
    //{
    //    if(EmptyClip != null)
    //    {
    //        audioSource.PlayOneShot(EmptyClip, volume);
    //    }
    //}

    //public void PlayReloadClip(AudioSource audioSource)
    //{
    //    if (ReloadClip != null)
    //    {
    //        audioSource.PlayOneShot(ReloadClip, volume);
    //    }
    //}
}
