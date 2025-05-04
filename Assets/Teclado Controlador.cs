using UnityEngine;

public class TecladoControlador : IPlayerController
{
    public void Move(int _move)
    {
        Debug.Log("Moviendo con Teclado: " + _move);
    }

    public void Attack(int _Damage)
    {
        Debug.Log("Atacando con Teclado: " + _Damage);
    }
}
