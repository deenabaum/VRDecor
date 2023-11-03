using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimateCar : MonoBehaviour
{
    [SerializeField] Transform carMove;
    [SerializeField] Transform startTransform;

    public void MoveCar()
    {
        DOTween.Init();

        if (this.gameObject.transform.position != carMove.position)
        {
            this.gameObject.transform.DOMove(carMove.position, 3f, false);
        }
        else
        {
            this.gameObject.transform.DOMove(startTransform.position, 3f, false);

        }

    }
}
