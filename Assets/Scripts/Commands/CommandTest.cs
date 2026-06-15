using UnityEngine;
using UnityEngine.InputSystem;

public class CommandTest : MonoBehaviour
{
    [SerializeField] private CommandInvoker _commandInvoker;
    [SerializeField] private Transform _transform;
    [SerializeField] private Vector3 _offset;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            var command = new MoveCommand(_transform, _transform.position, _offset);
            _commandInvoker.ExecuteCommand(command);
        }

        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            _commandInvoker.Undo();
        }
    }
}
