using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.StrategyPattern
{
    partial class StrategyContext
    {
        private IStrategy _istrategy;

        public StrategyContext(IStrategy istrategy)
        {
            _istrategy = istrategy;
        }

        public void ContextInterface()
        {
            _istrategy.AlgorithmInterface();
        }

    }
}
