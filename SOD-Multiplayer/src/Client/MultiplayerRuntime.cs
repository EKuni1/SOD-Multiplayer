using System;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using SOD.Multiplayer.Client.UI;

namespace SOD.Multiplayer.Client
{
    public sealed class MultiplayerRuntime : MonoBehaviour
    {
        private bool _controlWasDown;
        private ServerBrowserUI _browser;

        public MultiplayerRuntime(IntPtr ptr) : base(ptr)
        {
        }

        public MultiplayerRuntime() : this(ClassInjector.DerivedConstructorPointer<MultiplayerRuntime>())
        {
            ClassInjector.DerivedConstructorBody(this);
        }

        public void SetBrowser(ServerBrowserUI browser)
        {
            _browser = browser;
        }

        private void Update()
        {
            var controlDown = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
            var menuPressed = Input.GetKeyDown(KeyCode.M);

            if (controlDown && menuPressed && !_controlWasDown)
            {
                if (_browser == null)
                {
                    Debug.LogError("[SOD Multiplayer] Serverbrowser component is not available.");
                }
                else
                {
                    _browser.ToggleMenu();
                    Debug.Log("[SOD Multiplayer] Serverbrowser toggled with Ctrl+M.");
                }
            }

            _controlWasDown = controlDown;
        }
    }
}
