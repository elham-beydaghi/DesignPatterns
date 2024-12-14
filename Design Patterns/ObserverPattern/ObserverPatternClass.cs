using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.ObserverPattern
{
    public interface IObserver
    {
        void Upadte();
    }

    public class ConcreteObserver : IObserver
    {
        private int Count = 0;
        private ConcereteObservable concereteObservable;
        public ConcreteObserver(ConcereteObservable concereteObservable)
        {
            this.concereteObservable = concereteObservable;
        }
        public void Upadte()
        {
            Count = concereteObservable.GetUpdatedAttribute();
        }
    }

    public interface IObservable
    {
        void Remove(IObserver observer);
        void Add(IObserver observer);
        void Notify();

    }
    public class ConcereteObservable : IObservable
    {
        private int Count { get; set; }

        private IList<IObserver> _observers;

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers) { 
                observer.Upadte();
            }
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public int GetUpdatedAttribute()
        {
            return this.Count;
        }

        public void Setcount(int count)
        {
            this.Count = count;
        }
    }
}
