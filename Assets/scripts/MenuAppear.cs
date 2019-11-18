using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{
    public GameObject menu; // Assign in inspector

    void Update()
    {

    }

    public void showMenu()
    {
        menu.SetActive(true);
    }
}
