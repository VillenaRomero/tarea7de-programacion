using UnityEngine;

public interface IPlayerController
{
    public void Move(int _move);
    public void Attack(int _Damege);
}


public class player : MonoBehaviour
{
    private bool usarTeclado = true;

    private IPlayerController controller;
    private TecladoControlador teclado = new TecladoControlador();
    private GamepadControlador gamepad = new GamepadControlador();

    void Start()
    {
        if (usarTeclado)
        {
            controller = teclado;
            Debug.Log("Controlador asignado: Teclado");
        }
        else
        {
            controller = gamepad;
            Debug.Log("Controlador asignado: Gamepad");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            controller.Move(1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            controller.Attack(5);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (controller == teclado)
            {
                controller = gamepad;
                Debug.Log("Controlador cambiado a: Gamepad");
            }
            else
            {
                controller = teclado;
                Debug.Log("Controlador cambiado a: Teclado");
            }
        }
    }
}
