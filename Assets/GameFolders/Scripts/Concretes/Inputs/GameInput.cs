//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/GameFolders/Scripts/Concretes/Inputs/GameInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace UdemyProject2.Inputs
{
    public partial class @GameInput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""PlayerOnFoot"",
            ""id"": ""b0745a15-2981-4cf6-82e0-15b7157d18c6"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""Value"",
                    ""id"": ""c0570467-6a5e-481c-92d0-9fdf34ec6456"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""189407dd-3274-47f9-95a6-56ced74ff4b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""1151f1c0-924d-467a-a6ad-c1303ad72f9a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f53bfeba-251d-4f4d-a29c-f4c68e8693d1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a71f8f6a-5a43-41ff-b15a-c6f6857c5ca1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePAD"",
                    ""id"": ""d8d3dd52-83aa-46c4-bc71-44726a95bb87"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""515b5b9c-0423-42d4-9b48-fe6ef4122fa7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""79868f23-62f2-4de9-9ebd-716a2726d273"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""718b633e-ffdf-4e5a-b1c9-e1455fc6459d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap(duration=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a9e44a9-aa5f-4910-850d-b415aad8cda2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Tap(duration=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerOnFoot
            m_PlayerOnFoot = asset.FindActionMap("PlayerOnFoot", throwIfNotFound: true);
            m_PlayerOnFoot_HorizontalMove = m_PlayerOnFoot.FindAction("HorizontalMove", throwIfNotFound: true);
            m_PlayerOnFoot_Jump = m_PlayerOnFoot.FindAction("Jump", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // PlayerOnFoot
        private readonly InputActionMap m_PlayerOnFoot;
        private IPlayerOnFootActions m_PlayerOnFootActionsCallbackInterface;
        private readonly InputAction m_PlayerOnFoot_HorizontalMove;
        private readonly InputAction m_PlayerOnFoot_Jump;
        public struct PlayerOnFootActions
        {
            private @GameInput m_Wrapper;
            public PlayerOnFootActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @HorizontalMove => m_Wrapper.m_PlayerOnFoot_HorizontalMove;
            public InputAction @Jump => m_Wrapper.m_PlayerOnFoot_Jump;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnFoot; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnFootActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnFootActions instance)
            {
                if (m_Wrapper.m_PlayerOnFootActionsCallbackInterface != null)
                {
                    @HorizontalMove.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @Jump.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_PlayerOnFootActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HorizontalMove.started += instance.OnHorizontalMove;
                    @HorizontalMove.performed += instance.OnHorizontalMove;
                    @HorizontalMove.canceled += instance.OnHorizontalMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public PlayerOnFootActions @PlayerOnFoot => new PlayerOnFootActions(this);
        public interface IPlayerOnFootActions
        {
            void OnHorizontalMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
    }
}