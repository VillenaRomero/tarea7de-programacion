using UnityEngine;

public class GamepadControlador : IPlayerController
{
    public void Move(int _move)
    {
        Debug.Log("Moviendo con Gamepad: " + _move);
    }

    public void Attack(int _Damage)
    {
        Debug.Log("Atacando con Gamepad: " + _Damage);
    }
}
