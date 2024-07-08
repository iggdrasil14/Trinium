using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private static InputManager _inputManager;
    public static InputManager Instance => _inputManager;

    public InputActionAsset inputActionsAsset;
    private InputAction _moveAction;
    private InputAction _jumpAction;
    private InputAction _dashAction;
    private InputAction _attackAction;
    private InputAction _interactAction;
    private InputAction _formTriangle;
    private InputAction _formCircle;
    private InputAction _formSquare;
    private InputAction _dragAndPull;
    private InputAction _startButton;

    public Vector2 MoveInput {  get; private set; }
    public bool JumpInput => _jumpAction.triggered;
    public bool DashInput => _dashAction.triggered; 
    public bool FormTriangleInput => _formTriangle.triggered;
    public bool FormCircleInput => _formCircle.triggered;
    public bool FormSquareInput => _formSquare.triggered;
    public bool DragAndPullInput => _dragAndPull.triggered;
    public bool StartButtonInput => _startButton.triggered;
    private void Awake()
    {
        _inputManager = this;
        string map = "Move";
        _moveAction = inputActionsAsset.FindActionMap(map).FindAction("Movement");
        _jumpAction = inputActionsAsset.FindActionMap(map).FindAction("Jump");
        _dashAction = inputActionsAsset.FindActionMap(map).FindAction("Dash");
        _formTriangle = inputActionsAsset.FindActionMap(map).FindAction("FormTriangle");
        _formCircle = inputActionsAsset.FindActionMap(map).FindAction("FormCircle");
        _formSquare = inputActionsAsset.FindActionMap(map).FindAction("FormSquare");
        _dragAndPull = inputActionsAsset.FindActionMap(map).FindAction("DragAndPull");
        _startButton = inputActionsAsset.FindActionMap(map).FindAction("StartButton");
    }

    private void OnEnable()
    {
        _moveAction.Enable();
        _jumpAction.Enable();
        _dashAction.Enable();
        _formTriangle.Enable();
        _formCircle.Enable(); 
        _formSquare.Enable();
        _dragAndPull.Enable();
        _startButton.Enable();

        _moveAction.performed += context => MoveInput = context.ReadValue<Vector2>();
        _moveAction.canceled += contaxt => MoveInput = Vector2.zero;
    }

    private void OnDisable()
    {
        _moveAction.Disable();
        _jumpAction.Disable();
        _dashAction.Disable();
        _formTriangle.Disable();
        _formCircle.Disable();
        _formSquare.Disable();
        _dragAndPull.Disable();
        _startButton.Disable();

        _moveAction.performed -= context => MoveInput = context.ReadValue<Vector2>();
        _moveAction.canceled -= contaxt => MoveInput = Vector2.zero;
    }
}
