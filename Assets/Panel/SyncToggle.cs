
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
namespace FinsScript{
   
public class SyncToggle : UdonSharpBehaviour
{
    [UdonSynced()] private bool state = true;
    
    public Animator anim;

    public string animName;

    public override void Interact(){
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(SetBool));
    }

    public void SetBool(){
        if(Networking.LocalPlayer.IsOwner(gameObject)){
            state = !state;
            RequestSerialization();
            updateSync();
        }
    }

    public override void OnDeserialization(){
        updateSync();
    }

    private void updateSync(){
        anim.SetBool(animName, state);
    }
}
}
