using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionKitVr : MonoBehaviour
{
    [SerializeField] private Transform _root = default;
    public Transform Root => _root;
    [SerializeField] private Transform _tete = default;
    public Transform Tete => _tete;
    [SerializeField] private Transform _mainD = default;
    public Transform MainD => _mainD;
    [SerializeField] private Transform _mainG = default;
    public Transform MainG => _mainG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
