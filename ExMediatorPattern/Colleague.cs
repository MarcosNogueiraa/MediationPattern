using System;
using System.Collections.Generic;
using System.Text;

namespace ExMediatorPattern
{
    public abstract class Colleague
    {
        protected IMediator Mediator;

        public Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
