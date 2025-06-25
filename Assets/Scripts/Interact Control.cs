using System;
using TMPro;
using UnityEngine;

public class InteractControl : MonoBehaviour
{

    [SerializeField] private Camera playerCamera;
    [SerializeField]  TextMeshProUGUI interactionText;
    [SerializeField] private float interactionDistance = 5f;
    private interactableItem currentTargergetedInteractable;

    public void Update()
    {
        UpdateCurrentInteractable();

        UpdateInteractionText();

        CheckForInteractionInput();
    }

    public void CheckForInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentTargergetedInteractable != null)
        {
            currentTargergetedInteractable.Interact();
        }
    }

    public void UpdateInteractionText()
    {
        if (currentTargergetedInteractable != null)
        {
            interactionText.text = string.Empty;
            return;
        }

        interactionText.text = currentTargergetedInteractable._interactMessage;
    }

    private void UpdateCurrentInteractable()
    {
        var ray = playerCamera.ViewportPointToRay(new Vector2(0.5f, 0.5f));

        Physics.Raycast(ray, out var hit, interactionDistance);

        currentTargergetedInteractable = hit.collider?.GetComponent<interactableItem>();
    }
}
