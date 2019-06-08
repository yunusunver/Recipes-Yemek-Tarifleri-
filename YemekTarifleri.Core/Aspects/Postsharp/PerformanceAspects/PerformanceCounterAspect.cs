using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace YemekTarifleri.Core.Aspects.Postsharp.PerformanceAspects
{
    [Serializable]
    public class PerformanceCounterAspect:OnMethodBoundaryAspect
    {
        private int _invertal;

        [NonSerialized]
        private Stopwatch _stopwatch;
        public PerformanceCounterAspect(int invertal=1)
        {
            _invertal = invertal;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            _stopwatch = Activator.CreateInstance<Stopwatch>();
            base.RuntimeInitialize(method);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();
            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {

            _stopwatch.Stop();
            if (_stopwatch.Elapsed.TotalSeconds > _invertal)
            {
                Debug.WriteLine("Performance: {0}.{1}->>{2}",args.Method.DeclaringType.FullName,args.Method.Name,_stopwatch.Elapsed.TotalSeconds);
            }
            _stopwatch.Reset();
            base.OnExit(args);
        }
    }
}
