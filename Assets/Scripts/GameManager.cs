using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Material activeMaterial;
    [SerializeField] Material defaultMaterial;

    // Start is called before the first frame update
    void Start()
    {
        activeMaterial = defaultMaterial;
    }

    public void SwitchActiveMaterial(Material newMat)
    {
        activeMaterial = newMat;
    }
}
