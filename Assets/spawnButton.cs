using JetBrains.Annotations;
using UnityEngine;


public class spawnButton : MonoBehaviour, interactableItem
{
    public string InteractMessage => _objectInteractMessage;

    public string _interactMessage => throw new System.NotImplementedException();

    [SerializeField] private GameObject spawnPrefab;

    [SerializeField] private string _objectInteractMessage;
    
    void Spawn()
    {
         

        var spawnedObject = Instantiate(spawnPrefab, transform.position + Vector3.up, Quaternion.identity);

        float randomSize = Random.Range(0.1f, 1f);
        spawnedObject.transform.localScale = Vector3.one * randomSize;

        var randomColour = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        spawnedObject.GetComponent<MeshRenderer>().material.color = randomColour;
    }

    public void Interact()
    {
        Spawn();
    }
}
