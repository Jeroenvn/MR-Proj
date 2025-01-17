using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnGrabHover : MonoBehaviour
{
    [SerializeField] private MapUX mapUX;

    public void Activate()
    {
        mapUX.OnBuildingSelect(gameObject);
    }

    private void Start()
    {

    }
}
