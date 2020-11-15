using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BM_Index.Commands.Base;

namespace BM_Index.Commands
{
    internal class LambdaCommand:Command
    {
        private readonly Action<object> myExecute;
        private readonly Func<object, bool> myCanExecute;

        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            myExecute = Execute?? throw new ArgumentNullException(nameof(Execute));
            myCanExecute = CanExecute;
            
        }

        public override bool CanExecute(object parameter) => myCanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => myExecute(parameter);

    }
}
