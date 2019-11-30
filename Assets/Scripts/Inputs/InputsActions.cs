// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/InputsActions.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public class Actions : IInputActionCollection
    {
        private InputActionAsset asset;
        public Actions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputsActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""31a71b1c-c2f2-426f-a6da-685d56abc226"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d774078d-7fd8-4162-b64e-ebe925547ee6"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""976ff062-81ce-4a93-8f7c-7eccf6cfd3e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d5b57684-636b-4b63-85b8-e58e82fe42af"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4a9213ea-45e7-401f-b009-558b355bd0b9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""966b6d96-09f6-4abf-b8b1-10c3a216dd02"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Build"",
                    ""type"": ""Button"",
                    ""id"": ""d18a5353-30ac-4326-8674-7614de2dfd80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Ability1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d6b58bc9-9088-40f7-ad9b-7b7114fc1471"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b0ca82b1-8f07-4cbb-854f-eecb7923c59b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability3"",
                    ""type"": ""PassThrough"",
                    ""id"": ""063c54c5-1c96-4e71-834c-76916cc49d3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability4"",
                    ""type"": ""PassThrough"",
                    ""id"": ""301d0af8-a544-4656-bbd5-1083e492722d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""bc8b5d62-6224-4903-8e68-a55c1978380a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""840ca9bc-e24e-4122-8b08-8719da048a5e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""440cc7d1-b56e-4db8-aec5-f84c0e596a1b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""71b726f1-9e1d-440c-a211-1066ad1dddaf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6791d75a-cf43-4ae2-b734-98c87ffa848f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7a14044b-c117-4150-8355-cd3d797e9b7d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""431d81db-8663-40ea-848c-e715d2648ccd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d777fa31-1b67-43a1-b31e-135b64d3facb"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db3724eb-2895-4142-a296-856f092bf6e2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d646e4c3-27a1-4a26-8e5c-a89de97a5378"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f5611db-8750-4e73-bd11-7a0829d909fa"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15086b2a-fd2e-48ae-89a1-c46179ccc3f3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72a05a09-e580-4279-a6c9-dfc515cdee38"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Ability1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaa12ad2-5345-4406-9cf8-67938f36a486"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Ability1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fb7e3c5-e80d-4c15-aaf8-2250ab55b551"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Ability2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfbc2572-0ef2-4aa6-a5b1-1669d50e9343"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Ability2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0167c019-3215-4fa0-bdfd-7fb6590fb7cb"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Ability3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46ad1152-1166-4821-9b89-083f34f4b139"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Ability3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c00d282-b512-4b36-8663-9dbcabfe3eeb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Ability4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53b61eb8-79d9-4aae-827f-95d81638d245"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Ability4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""694f0ffb-e49c-4875-a652-07a5f0bb0e2d"",
                    ""path"": ""<Gamepad>/dpad/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57ffbaeb-ab09-40f9-ae29-3a89cb39be2b"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dc2d8a0-8da3-4d29-a3cf-7bf43d6d96b8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Build"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04d115a1-03d8-4af7-939b-8f654b8b10de"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Build"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74f4e769-8c43-47b4-9598-6eec56590bd0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3036908c-3675-4691-aba7-f4d6ed924b99"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BuildMenu"",
            ""id"": ""f4f23ffa-052f-4805-ab14-f16b23870e85"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e66f7941-a2b1-4bb2-b60e-0137b9ea2aa3"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""bce4b6d5-6fc7-4c6d-ba6b-ef9f00f16c8f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bc7c23c1-9e02-4fe5-be9a-69ab8e2c0a7f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""24e9e267-94b0-4765-991e-5900c356978b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7271d290-fd5e-4d1f-83df-dda3aa494cba"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""be65f151-9e31-4700-8eea-0cf26898f66e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9c575a20-4efa-4c24-a6c8-0d40e2bafac7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c5c214cb-edcf-41b3-8f35-a9a701d2a917"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""271bfcab-4ab3-4464-a015-2c1e7851ad94"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc200c45-c313-4a66-ba9b-198c3b83d786"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Gameplay
            m_Gameplay = asset.GetActionMap("Gameplay");
            m_Gameplay_Move = m_Gameplay.GetAction("Move");
            m_Gameplay_Dash = m_Gameplay.GetAction("Dash");
            m_Gameplay_Look = m_Gameplay.GetAction("Look");
            m_Gameplay_Zoom = m_Gameplay.GetAction("Zoom");
            m_Gameplay_Action = m_Gameplay.GetAction("Action");
            m_Gameplay_Build = m_Gameplay.GetAction("Build");
            m_Gameplay_Ability1 = m_Gameplay.GetAction("Ability1");
            m_Gameplay_Ability2 = m_Gameplay.GetAction("Ability2");
            m_Gameplay_Ability3 = m_Gameplay.GetAction("Ability3");
            m_Gameplay_Ability4 = m_Gameplay.GetAction("Ability4");
            m_Gameplay_Pause = m_Gameplay.GetAction("Pause");
            // BuildMenu
            m_BuildMenu = asset.GetActionMap("BuildMenu");
            m_BuildMenu_Move = m_BuildMenu.GetAction("Move");
            m_BuildMenu_Select = m_BuildMenu.GetAction("Select");
        }

        ~Actions()
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

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_Move;
        private readonly InputAction m_Gameplay_Dash;
        private readonly InputAction m_Gameplay_Look;
        private readonly InputAction m_Gameplay_Zoom;
        private readonly InputAction m_Gameplay_Action;
        private readonly InputAction m_Gameplay_Build;
        private readonly InputAction m_Gameplay_Ability1;
        private readonly InputAction m_Gameplay_Ability2;
        private readonly InputAction m_Gameplay_Ability3;
        private readonly InputAction m_Gameplay_Ability4;
        private readonly InputAction m_Gameplay_Pause;
        public struct GameplayActions
        {
            private Actions m_Wrapper;
            public GameplayActions(Actions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Gameplay_Move;
            public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
            public InputAction @Look => m_Wrapper.m_Gameplay_Look;
            public InputAction @Zoom => m_Wrapper.m_Gameplay_Zoom;
            public InputAction @Action => m_Wrapper.m_Gameplay_Action;
            public InputAction @Build => m_Wrapper.m_Gameplay_Build;
            public InputAction @Ability1 => m_Wrapper.m_Gameplay_Ability1;
            public InputAction @Ability2 => m_Wrapper.m_Gameplay_Ability2;
            public InputAction @Ability3 => m_Wrapper.m_Gameplay_Ability3;
            public InputAction @Ability4 => m_Wrapper.m_Gameplay_Ability4;
            public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                    Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                    Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                    Zoom.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoom;
                    Zoom.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoom;
                    Zoom.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoom;
                    Action.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction;
                    Action.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction;
                    Action.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction;
                    Build.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBuild;
                    Build.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBuild;
                    Build.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBuild;
                    Ability1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility1;
                    Ability1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility1;
                    Ability1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility1;
                    Ability2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility2;
                    Ability2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility2;
                    Ability2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility2;
                    Ability3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility3;
                    Ability3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility3;
                    Ability3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility3;
                    Ability4.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility4;
                    Ability4.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility4;
                    Ability4.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbility4;
                    Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Move.started += instance.OnMove;
                    Move.performed += instance.OnMove;
                    Move.canceled += instance.OnMove;
                    Dash.started += instance.OnDash;
                    Dash.performed += instance.OnDash;
                    Dash.canceled += instance.OnDash;
                    Look.started += instance.OnLook;
                    Look.performed += instance.OnLook;
                    Look.canceled += instance.OnLook;
                    Zoom.started += instance.OnZoom;
                    Zoom.performed += instance.OnZoom;
                    Zoom.canceled += instance.OnZoom;
                    Action.started += instance.OnAction;
                    Action.performed += instance.OnAction;
                    Action.canceled += instance.OnAction;
                    Build.started += instance.OnBuild;
                    Build.performed += instance.OnBuild;
                    Build.canceled += instance.OnBuild;
                    Ability1.started += instance.OnAbility1;
                    Ability1.performed += instance.OnAbility1;
                    Ability1.canceled += instance.OnAbility1;
                    Ability2.started += instance.OnAbility2;
                    Ability2.performed += instance.OnAbility2;
                    Ability2.canceled += instance.OnAbility2;
                    Ability3.started += instance.OnAbility3;
                    Ability3.performed += instance.OnAbility3;
                    Ability3.canceled += instance.OnAbility3;
                    Ability4.started += instance.OnAbility4;
                    Ability4.performed += instance.OnAbility4;
                    Ability4.canceled += instance.OnAbility4;
                    Pause.started += instance.OnPause;
                    Pause.performed += instance.OnPause;
                    Pause.canceled += instance.OnPause;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);

        // BuildMenu
        private readonly InputActionMap m_BuildMenu;
        private IBuildMenuActions m_BuildMenuActionsCallbackInterface;
        private readonly InputAction m_BuildMenu_Move;
        private readonly InputAction m_BuildMenu_Select;
        public struct BuildMenuActions
        {
            private Actions m_Wrapper;
            public BuildMenuActions(Actions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_BuildMenu_Move;
            public InputAction @Select => m_Wrapper.m_BuildMenu_Select;
            public InputActionMap Get() { return m_Wrapper.m_BuildMenu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BuildMenuActions set) { return set.Get(); }
            public void SetCallbacks(IBuildMenuActions instance)
            {
                if (m_Wrapper.m_BuildMenuActionsCallbackInterface != null)
                {
                    Move.started -= m_Wrapper.m_BuildMenuActionsCallbackInterface.OnMove;
                    Move.performed -= m_Wrapper.m_BuildMenuActionsCallbackInterface.OnMove;
                    Move.canceled -= m_Wrapper.m_BuildMenuActionsCallbackInterface.OnMove;
                    Select.started -= m_Wrapper.m_BuildMenuActionsCallbackInterface.OnSelect;
                    Select.performed -= m_Wrapper.m_BuildMenuActionsCallbackInterface.OnSelect;
                    Select.canceled -= m_Wrapper.m_BuildMenuActionsCallbackInterface.OnSelect;
                }
                m_Wrapper.m_BuildMenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Move.started += instance.OnMove;
                    Move.performed += instance.OnMove;
                    Move.canceled += instance.OnMove;
                    Select.started += instance.OnSelect;
                    Select.performed += instance.OnSelect;
                    Select.canceled += instance.OnSelect;
                }
            }
        }
        public BuildMenuActions @BuildMenu => new BuildMenuActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.GetControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.GetControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IGameplayActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnZoom(InputAction.CallbackContext context);
            void OnAction(InputAction.CallbackContext context);
            void OnBuild(InputAction.CallbackContext context);
            void OnAbility1(InputAction.CallbackContext context);
            void OnAbility2(InputAction.CallbackContext context);
            void OnAbility3(InputAction.CallbackContext context);
            void OnAbility4(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
        }
        public interface IBuildMenuActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnSelect(InputAction.CallbackContext context);
        }
    }
}
