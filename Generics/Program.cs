using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>(); 
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T>
    {
        T[] _array; // son elemanı tutar
        T[] _tempArray; // son elemandan öncekileri tutar
        public MyList()
        {
            _array = new T[0];
        }
       public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1]; // elemanları bir bir arttırmak. // new lemek yeni bir adres tutsun demek

            for (int i = 0; i < _tempArray.Length; i++) // _tempArray'dekileri _array' e atmak
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
