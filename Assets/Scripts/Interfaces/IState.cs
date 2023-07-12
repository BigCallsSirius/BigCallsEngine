using System;
using UnityEngine;

namespace Interfaces
{
    public interface IState<T> where T : Enum
    {
        public T Id { get; }
        void Enter();
        void Exit();
    }
}