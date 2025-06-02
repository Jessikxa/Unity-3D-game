using UnityEngine;

public class ParticleActivation : MonoBehaviour
{
    [SerializeField] ParticleSystem _collectParticle = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collect();
        }
    }

    public void Collect()
    {
        _collectParticle.Play();
    }
}
