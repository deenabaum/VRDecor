using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMaterial : MonoBehaviour
{

    public void SwitchMaterialToActive()
    {
        gameObject.GetComponent<Renderer>().material = GameManager.activeMaterial;
    }
}
