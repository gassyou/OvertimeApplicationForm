using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public static class DomainEvents
    {
        [ThreadStatic]
        private static List<Delegate> _actions;

        private static List<Delegate> Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new List<Delegate>();
                }
                return _actions;
            }
        }


        public static IDisposable Register<T>(Action<T> callback)
        {
            Actions.Add(callback);
            return new DomainEventRegistrationRemover(() => Actions.Remove(callback));
        }

        public static void Raise<T>(T eventArgs)
        {
            foreach (Delegate action in Actions)
            {
                Action<T> typedAction = action as Action<T>;
                if (typedAction != null)
                {
                    typedAction(eventArgs);
                }
            }
        }

        private sealed class DomainEventRegistrationRemover : IDisposable
        {
            private readonly Action _callOnDispose;
            public DomainEventRegistrationRemover(Action toCall)
            {
                _callOnDispose = toCall;
            }

            public void Dispose()
            {
                _callOnDispose();
            }
        }

    }
}
