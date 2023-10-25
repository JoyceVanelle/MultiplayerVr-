using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.Netcode;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private Button _hostButton;
    [SerializeField] private Button _ServerButton;
    [SerializeField] private Button _clientButton;

    // Start is called before the first frame update
   private void Start()
    {
        _hostButton.onClick.AddListener(() => NetworkManager.Singleton.StartHost());
        _ServerButton.onClick.AddListener(() => NetworkManager.Singleton.StartServer());
        _clientButton.onClick.AddListener(() => NetworkManager.Singleton.StartClient());// UN EVENEMENT VIDE QUI APPELLE UN AUTRE EVENEMENT 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
