using UnityEngine;

public interface IInteractableObject
{
    string Tag { get; }
    AudioSource sound { get; }
    void Interact();
}
