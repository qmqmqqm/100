using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBlock : TileBase
{
    [SerializeField]
    private GameObject highlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void SetHighLight(bool b)
    {
        highlight.SetActive(b);
    }
}
