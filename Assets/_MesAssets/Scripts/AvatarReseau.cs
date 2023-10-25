using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class AvatarReseau : NetworkBehaviour
{
    [SerializeField] private Transform _rootAvatar = default;
    [SerializeField] private Transform _teteAvatar = default;
    [SerializeField] private Transform _mainGAvatar = default;
    [SerializeField] private Transform _mainDAvatar = default;

    private PositionKitVr _positionKitVr;
    // Start is called before the first frame update
    void Start()
    {
        _positionKitVr =FindAnyObjectByType<PositionKitVr>();
    }

    // Update is called once per frame
   private void Update()
    {
        if(IsOwner)
        {
            _rootAvatar.position = _positionKitVr.Root.position;
            _rootAvatar.rotation = _positionKitVr.Root.rotation;

            _teteAvatar.position = _positionKitVr.Tete.position;
            _teteAvatar.rotation = _positionKitVr.Tete.rotation;

            _mainGAvatar.position = _positionKitVr.MainG.position;
            _mainGAvatar.rotation = _positionKitVr.MainG.rotation;

            _mainDAvatar.position = _positionKitVr.MainD.position;
            _mainDAvatar.rotation = _positionKitVr.MainD.rotation;
        }
       
    }
}
