using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paralax : MonoBehaviour
{
    MeshRenderer meshRendrer;
    [SerializeField] float backgroundSpeed=1f;
    private void Awake()
    {
        meshRendrer = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        meshRendrer.material.mainTextureOffset += new Vector2(backgroundSpeed*Time.deltaTime, 0f); 
    }
}
