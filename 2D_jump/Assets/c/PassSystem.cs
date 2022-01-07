using UnityEngine;
using UnityEngine.Events;

public class PassSystem : MonoBehaviour
{
    public string nameTarget = "和尚";
    public UnityEvent onPass;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == nameTarget) onPass.Invoke();
    }
}
