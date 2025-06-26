using UnityEngine;

public class ParticleActivation : MonoBehaviour
{
    [SerializeField] public ParticleSystem _collectParticle = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Collect();
        }
    }

    public void Collect()
    {
        //_collectParticle.Pause();
        _collectParticle.Clear();
        _collectParticle.Play();
    }
}
