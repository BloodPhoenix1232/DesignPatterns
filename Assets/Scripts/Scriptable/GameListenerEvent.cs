using UnityEngine;
using UnityEngine.Events;

public class GameListenerEvent : MonoBehaviour
{
    [SerializeField] private GameEvent _gameEvent;
    [SerializeField] private UnityEvent _response;

    void OnEnable()
    {
        _gameEvent.AddListener(this);
    }

    void OnDisable()
    {
        _gameEvent.RemoveListener(this);
    }

    public void OnEventRaised()
    {
        _response.Invoke();
    }
}
