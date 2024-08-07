//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Materials/InPutController.inputactions
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

public partial class @InPutController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InPutController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InPutController"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""5cde3acd-b439-44d4-9b8e-a71f64599c7b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5da5d5c7-da34-4664-9451-42d21880e2e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""150b340b-fbdc-4896-9d69-6ef85a3b796e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""40a40a0d-95f2-4496-b9ab-c65b49ad3b10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FormTriangle"",
                    ""type"": ""Button"",
                    ""id"": ""f51ee3bd-08e8-4760-b1ec-a8f89dfe4cf4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FormCircle"",
                    ""type"": ""Button"",
                    ""id"": ""def84b1b-deff-4296-ae5f-b6f2ea9c2fb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FormSquare"",
                    ""type"": ""Button"",
                    ""id"": ""ad923673-93ce-4e5b-ab4a-5905e5135ccd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DragAndPull"",
                    ""type"": ""Button"",
                    ""id"": ""6abfdb28-4d21-41e3-9eea-ad1cee880537"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StartButton"",
                    ""type"": ""Button"",
                    ""id"": ""5d8f0924-f001-4a89-9e68-fcda0b909735"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f241b9e1-b8c7-4b9b-a03d-75f98ef45182"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fd06a0cf-43cd-4173-9620-4d13e27a55c3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8762eeb3-6ed8-4f75-947c-ee7fb58a0830"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ea1fc273-ca75-4fda-94ec-486068dafa69"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4133d988-0aaa-47c1-bfac-367f556a6aea"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d70c21be-c2cb-4613-9ccf-9f69b889266b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d9dbf880-b611-46ea-a75d-600035ee6251"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5697c4e0-9f02-426a-b02e-96091b261d5c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79147263-01cd-458a-b0ca-bddd55b3a811"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bb5acef-ee10-4416-9c5c-3ce54d76e79b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a61b21f7-5eb6-44a9-8930-c1418a52978a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormTriangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96abe05d-8a70-4678-a24b-f3e9fca469dd"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormTriangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f908a0d-fbb3-4afc-91bd-d4e49b944af9"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormTriangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b854f740-c28a-47bb-8de1-5c3fa179ad0c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormCircle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82a6fe38-ef5d-4403-b880-0579c824ca91"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormCircle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ee88de4-3ccc-49ee-81fe-093d90d8ffde"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormCircle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf31048f-6378-474f-a9df-203d0a3dd5eb"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormSquare"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c72bc6f-d49c-4280-8098-b759042c04cb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormSquare"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f48883ca-b7c4-4519-b8c9-b1d8db4b5eb9"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FormSquare"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b998c17-9813-47f0-add9-d8e5b561b418"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b34df4d-ab8c-411a-ac19-6db4a53600bc"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a00a7a3e-b6c1-43db-bf67-734a23067365"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DragAndPull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64604b6c-f75c-43f0-9f66-ab5db12c923b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DragAndPull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gemapad"",
            ""bindingGroup"": ""Gemapad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Movement = m_Move.FindAction("Movement", throwIfNotFound: true);
        m_Move_Jump = m_Move.FindAction("Jump", throwIfNotFound: true);
        m_Move_Dash = m_Move.FindAction("Dash", throwIfNotFound: true);
        m_Move_FormTriangle = m_Move.FindAction("FormTriangle", throwIfNotFound: true);
        m_Move_FormCircle = m_Move.FindAction("FormCircle", throwIfNotFound: true);
        m_Move_FormSquare = m_Move.FindAction("FormSquare", throwIfNotFound: true);
        m_Move_DragAndPull = m_Move.FindAction("DragAndPull", throwIfNotFound: true);
        m_Move_StartButton = m_Move.FindAction("StartButton", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private List<IMoveActions> m_MoveActionsCallbackInterfaces = new List<IMoveActions>();
    private readonly InputAction m_Move_Movement;
    private readonly InputAction m_Move_Jump;
    private readonly InputAction m_Move_Dash;
    private readonly InputAction m_Move_FormTriangle;
    private readonly InputAction m_Move_FormCircle;
    private readonly InputAction m_Move_FormSquare;
    private readonly InputAction m_Move_DragAndPull;
    private readonly InputAction m_Move_StartButton;
    public struct MoveActions
    {
        private @InPutController m_Wrapper;
        public MoveActions(@InPutController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Move_Movement;
        public InputAction @Jump => m_Wrapper.m_Move_Jump;
        public InputAction @Dash => m_Wrapper.m_Move_Dash;
        public InputAction @FormTriangle => m_Wrapper.m_Move_FormTriangle;
        public InputAction @FormCircle => m_Wrapper.m_Move_FormCircle;
        public InputAction @FormSquare => m_Wrapper.m_Move_FormSquare;
        public InputAction @DragAndPull => m_Wrapper.m_Move_DragAndPull;
        public InputAction @StartButton => m_Wrapper.m_Move_StartButton;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void AddCallbacks(IMoveActions instance)
        {
            if (instance == null || m_Wrapper.m_MoveActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MoveActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @FormTriangle.started += instance.OnFormTriangle;
            @FormTriangle.performed += instance.OnFormTriangle;
            @FormTriangle.canceled += instance.OnFormTriangle;
            @FormCircle.started += instance.OnFormCircle;
            @FormCircle.performed += instance.OnFormCircle;
            @FormCircle.canceled += instance.OnFormCircle;
            @FormSquare.started += instance.OnFormSquare;
            @FormSquare.performed += instance.OnFormSquare;
            @FormSquare.canceled += instance.OnFormSquare;
            @DragAndPull.started += instance.OnDragAndPull;
            @DragAndPull.performed += instance.OnDragAndPull;
            @DragAndPull.canceled += instance.OnDragAndPull;
            @StartButton.started += instance.OnStartButton;
            @StartButton.performed += instance.OnStartButton;
            @StartButton.canceled += instance.OnStartButton;
        }

        private void UnregisterCallbacks(IMoveActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @FormTriangle.started -= instance.OnFormTriangle;
            @FormTriangle.performed -= instance.OnFormTriangle;
            @FormTriangle.canceled -= instance.OnFormTriangle;
            @FormCircle.started -= instance.OnFormCircle;
            @FormCircle.performed -= instance.OnFormCircle;
            @FormCircle.canceled -= instance.OnFormCircle;
            @FormSquare.started -= instance.OnFormSquare;
            @FormSquare.performed -= instance.OnFormSquare;
            @FormSquare.canceled -= instance.OnFormSquare;
            @DragAndPull.started -= instance.OnDragAndPull;
            @DragAndPull.performed -= instance.OnDragAndPull;
            @DragAndPull.canceled -= instance.OnDragAndPull;
            @StartButton.started -= instance.OnStartButton;
            @StartButton.performed -= instance.OnStartButton;
            @StartButton.canceled -= instance.OnStartButton;
        }

        public void RemoveCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMoveActions instance)
        {
            foreach (var item in m_Wrapper.m_MoveActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MoveActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MoveActions @Move => new MoveActions(this);
    private int m_GemapadSchemeIndex = -1;
    public InputControlScheme GemapadScheme
    {
        get
        {
            if (m_GemapadSchemeIndex == -1) m_GemapadSchemeIndex = asset.FindControlSchemeIndex("Gemapad");
            return asset.controlSchemes[m_GemapadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMoveActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnFormTriangle(InputAction.CallbackContext context);
        void OnFormCircle(InputAction.CallbackContext context);
        void OnFormSquare(InputAction.CallbackContext context);
        void OnDragAndPull(InputAction.CallbackContext context);
        void OnStartButton(InputAction.CallbackContext context);
    }
}
