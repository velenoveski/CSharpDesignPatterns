﻿namespace State
{
    public class Context
    {
        public Context(State state)
        {
            State = state;
        }

        public State State { get; set; }

        public void Request()
        {
            State.Handle(this);
        }
    }
}
