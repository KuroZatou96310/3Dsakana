using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLv : MonoBehaviour
{
    public int DestroyLv;
    public float SizeLv = 1f;
    public int score;
    public int pt;
    private int tmp;
    public int SpeedLv;

    /// <summary>
    /// è’ìÀÇµÇΩéû
    /// </summary>
    /// <param name="collision"></param>

    private void Update()
    {
        transform.localScale = Vector3.one * SizeLv;
    }

    void OnCollisionEnter(Collision collision)
    {



    }
}
