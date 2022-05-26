using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    [SerializeField] private SkinManager skinManager;
    void Start()
    {
        GetComponentInChildren<MeshRenderer>().materials[0].color = skinManager.GetSelectedSkin().spritematerial.color;
    }

}
