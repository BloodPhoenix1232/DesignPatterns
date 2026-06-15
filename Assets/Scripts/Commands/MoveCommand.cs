using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform _transform;
    private Vector3 _positionA;
    private Vector3 _positionB;

    public MoveCommand(Transform transform, Vector3 from, Vector3 to)
    {
        _transform = transform;
        _positionA = from;
        _positionB = to;
    }

    void ICommand.Execute()
    {
        _transform.position = _positionB;
    }

    void ICommand.Undo()
    {
        _transform.position = _positionA;
    }
}
