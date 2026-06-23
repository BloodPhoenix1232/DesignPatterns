using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "GameEvent", menuName = "Events/GameEvent")]
public class GameEvent : ScriptableObject
{
    private List<GameListenerEvent> _listeners = new List<GameListenerEvent>();
    public void Raise()
    {
        foreach (var listener in _listeners)
        {
            listener.OnEventRaised();
        }
    }

    public void AddListener(GameListenerEvent listener)
    {
        _listeners.Add(listener);
    }

    public void RemoveListener(GameListenerEvent listener)
    {
        _listeners.Remove(listener);
    }
}