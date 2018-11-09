using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public delegate void MessageHandler(string mes);
    public class SimpleClass : IDisposable
    {
        MessageHandler _del;
        private static int _num;
        private bool _disposed = false;

        static SimpleClass()
        {
            _num = 0;
        }

        public void RegMessage(MessageHandler del)
        {
            _del = del;
        }

        public SimpleClass(MessageHandler message)
        {
            _del = message;
            //_del?.Invoke("Construct");
            _num++;
            _disposed = false;
            //if (_num % 50000 == 0)
            //{
            //    _del.Invoke(_num.ToString());
            //    _del.Invoke(Convert.ToString((double)GC.GetTotalMemory(false) / 1024));
            //}
        }
        //~SimpleClass()
        //{
        //    _num--;
        //    //_del?.Invoke("Destruct");
        //    //_del?.Invoke(_num.ToString());
        //}
        public void GetNum()
        {
            
            _del?.Invoke($"now \"_disposed\" is {_disposed}");
        }

        public void Dispose()
        {
            ToDispose();
            _del($"object № {_num} before GC {(double)GC.GetTotalMemory(false) / 1024} Kbytes");
            GC.Collect();
            _del($"object № {_num} after GC {(double)GC.GetTotalMemory(false) / 1024} Kbytes");
            _del?.Invoke("Disposing...");
        }

        private void ToDispose()
        {
            _disposed = true;
        }
    }
}
