using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Material activeMaterial;
    public static GameObject zapFX;
    [SerializeField] Material defaultMaterial;

    // Start is called before the first frame update
    void Start()
    {
        activeMaterial = defaultMaterial;
        zapFX = this.gameObject.transform.GetChild(0).gameObject;
    }

    public void SwitchActiveMaterial(Material newMat)
    {
        activeMaterial = newMat;
    }

    
}
