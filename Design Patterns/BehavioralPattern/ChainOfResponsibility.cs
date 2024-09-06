namespace Design_Patterns.BehavioralPattern
{
    public interface IHandler
    {
        IHandler SetNextHandler(IHandler handler);

        object Handle(object request);
    }

    public abstract class ChainOfResponsibility : IHandler
    {
        private IHandler _nextHandler { get; set; }
        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }

    public class HandleOne() : ChainOfResponsibility
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "person one")
            {
                return "How Are You?";
            }
            return base.Handle(request);
        }
    }

    public class HandleTwo() : ChainOfResponsibility
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "person two")
            {
                return "Thanks";
            }
            return base.Handle(request);
        }
    }

}
