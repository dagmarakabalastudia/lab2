using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class lab4zad3 : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    float mouseXMove;
    float mouseYMove;
    float obrot;

    public float sensitivity = 200f;

    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
        mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        obrot += mouseYMove;
        player.Rotate(Vector3.up * mouseXMove);

        if(obrot < 45 && obrot > -45)
        {
            transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
        }

    }
}