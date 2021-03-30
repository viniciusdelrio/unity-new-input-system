using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public void OnMovement() => 
        Debug.Log("OnMovement Called!");

    public void OnJump() =>
        Debug.Log("OnJump Called!");
}
