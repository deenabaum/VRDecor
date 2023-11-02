using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Material activeMaterial;
    [SerializeField] Material defaultMaterial;

    // Start is called before the first frame update
    void Start()
    {
        activeMaterial = defaultMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
