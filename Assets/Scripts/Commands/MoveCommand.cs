using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform _transform;
    private Vector3 _from;
    private Vector3 _offset;

    public MoveCommand(Transform transform, Vector3 from, Vector3 offset)
    {
        _transform = transform;
        _from = from;
        _offset = offset;
    }

    void ICommand.Execute()
    {
        _transform.position += _offset;
    }

    void ICommand.Undo()
    {
        _transform.position = _from;
    }
}
