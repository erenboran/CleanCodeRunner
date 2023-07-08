using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    [Range(0.5f,2f)]
    [SerializeField] float _moveSpeed;

    Material _material;
    
    private void Awake()
    {
        _material = GetComponentInChildren<MeshRenderer>().material;
    }
    

    // Update is called once per frame
    void Update()
    {
        _material.mainTextureOffset += Vector2.down * Time.deltaTime * _moveSpeed;
    }
}
