using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMaterial : MonoBehaviour
{

    public void SwitchMaterialToActive()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            Material[] allMat = gameObject.GetComponent<Renderer>().materials;
            Material[] newMats = new Material[renderer.materials.Length];
            for (int i = 0; i < allMat.Length; i++)
            {
                if (allMat[i].name.Contains("change"))
                {
                    newMats[i] = GameManager.activeMaterial;
                }
                else
                {
                    newMats[i] = allMat[i];
                }
            }

            renderer.materials = newMats;
            GameManager.zapFX.transform.position = this.gameObject.transform.position;
            ParticleSystem ps = GameManager.zapFX.GetComponent<ParticleSystem>();
            ps.Emit(10);
            
        }
        else
        {
            Debug.Log("Object is missing a Renderer component");
        }


    }
}
