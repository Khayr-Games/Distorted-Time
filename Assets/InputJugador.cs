// GENERATED AUTOMATICALLY FROM 'Assets/InputJugador.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputJugador : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputJugador()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputJugador"",
    ""maps"": [
        {
            ""name"": ""Jugador"",
            ""id"": ""bc511df1-ab21-4ceb-9138-98fd4cebaafd"",
            ""actions"": [
                {
                    ""name"": ""Moverse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""16f8025c-941c-45f7-9b8d-27108e46eb45"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""salto"",
                    ""type"": ""Button"",
                    ""id"": ""e7191bfc-44b4-4a3b-8bcd-f9652c7f31ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disparo"",
                    ""type"": ""Button"",
                    ""id"": ""5b8f098c-390c-4ee5-b7a5-a7638ef76716"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a29dd3c5-fb78-4a52-a765-6ec8bfff8edd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9f289723-6ef3-46c4-ba46-397274256a97"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""df9db446-65de-4081-ad9b-3abc1a30af37"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73ec7d40-1440-401a-af7d-6923c4a6d101"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""32bde1ac-f4ef-42b2-8220-9890a13167cf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""af191ca5-94ee-4535-8523-76a150292a8f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""salto"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b3f9613-8a77-4f51-8d00-26fff0356a03"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
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
        },
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
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Jugador
        m_Jugador = asset.FindActionMap("Jugador", throwIfNotFound: true);
        m_Jugador_Moverse = m_Jugador.FindAction("Moverse", throwIfNotFound: true);
        m_Jugador_salto = m_Jugador.FindAction("salto", throwIfNotFound: true);
        m_Jugador_disparo = m_Jugador.FindAction("disparo", throwIfNotFound: true);
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

    // Jugador
    private readonly InputActionMap m_Jugador;
    private IJugadorActions m_JugadorActionsCallbackInterface;
    private readonly InputAction m_Jugador_Moverse;
    private readonly InputAction m_Jugador_salto;
    private readonly InputAction m_Jugador_disparo;
    public struct JugadorActions
    {
        private @InputJugador m_Wrapper;
        public JugadorActions(@InputJugador wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moverse => m_Wrapper.m_Jugador_Moverse;
        public InputAction @salto => m_Wrapper.m_Jugador_salto;
        public InputAction @disparo => m_Wrapper.m_Jugador_disparo;
        public InputActionMap Get() { return m_Wrapper.m_Jugador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JugadorActions set) { return set.Get(); }
        public void SetCallbacks(IJugadorActions instance)
        {
            if (m_Wrapper.m_JugadorActionsCallbackInterface != null)
            {
                @Moverse.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnMoverse;
                @Moverse.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnMoverse;
                @Moverse.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnMoverse;
                @salto.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnSalto;
                @salto.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnSalto;
                @salto.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnSalto;
                @disparo.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnDisparo;
                @disparo.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnDisparo;
                @disparo.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnDisparo;
            }
            m_Wrapper.m_JugadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moverse.started += instance.OnMoverse;
                @Moverse.performed += instance.OnMoverse;
                @Moverse.canceled += instance.OnMoverse;
                @salto.started += instance.OnSalto;
                @salto.performed += instance.OnSalto;
                @salto.canceled += instance.OnSalto;
                @disparo.started += instance.OnDisparo;
                @disparo.performed += instance.OnDisparo;
                @disparo.canceled += instance.OnDisparo;
            }
        }
    }
    public JugadorActions @Jugador => new JugadorActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IJugadorActions
    {
        void OnMoverse(InputAction.CallbackContext context);
        void OnSalto(InputAction.CallbackContext context);
        void OnDisparo(InputAction.CallbackContext context);
    }
}
