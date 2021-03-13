﻿using HelloDependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDependencyInjection
{
    public class OperationLogger
    {

        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly ISingletonOperation _singletonOperation;

        public OperationLogger(ITransientOperation transientOperation, IScopedOperation scopedOperation, ISingletonOperation singletonOperation)
            => (_transientOperation, _scopedOperation, _singletonOperation) = (transientOperation, scopedOperation, singletonOperation);

        public void LogOperation(string scope)
        {
            LogOperation(_transientOperation, scope, "Always different");
            LogOperation(_scopedOperation, scope, "Changes only with scope");
            LogOperation(_singletonOperation, scope, "Always the same");

        }


        public static void LogOperation<T>(T operation, string scope, string message) where T : IOperation
            => Console.WriteLine($"{scope}: {typeof(T).Name,19} [  {operation.OperationId}...{message,23}  ]");

    }
}
