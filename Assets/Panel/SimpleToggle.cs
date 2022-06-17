
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
namespace FinsScript{
    public class SimpleToggle : UdonSharpBehaviour
    {
        public GameObject objectToToggle;

        public bool Interactable = true;


        private void Start(){
            DisableInteractive = !Interactable;
        }
        public override void Interact(){
            ToggleObject();
        }

        public override void OnPlayerTriggerEnter(VRCPlayerApi player){
            if(Networking.LocalPlayer == player && !Interactable){ 
                ToggleObject();
            }
        }

        private void ToggleObject(){
            objectToToggle.SetActive(!objectToToggle.activeSelf);
        }
    }
}
