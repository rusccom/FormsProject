using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProject.HandlerData
{
    public static class CreateOperation
    {
        public static void Init(Operations.OperationCode operationCode)
        {
            switch(operationCode)
            {
                case Operations.OperationCode.LIST_TMC:
                    break;
                case Operations.OperationCode.LIST_CUSTOMER:
                    break;
            }
        }
    }
}
