﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    [ServiceContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
    public interface ICalculator
    {
        [OperationContract]
        [FaultContract(typeof(OperationException))]
        double Add(double val1, double val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        double Multiply(double val1, double val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        double Divide(double val1, double val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        double Substract(double val1, double val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        double Mod(double val1, double val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        double HMultiply(double val1, double val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        int iAdd(int val1, int val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        int iSub(int val1, int val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        int iMul(int val1, int val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        int iDiv(int val1, int val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        int iMod(int val1, int val2);

        [OperationContract]
        [FaultContract(typeof(OperationException))]
        Tuple<int, int> PrimeCalculation(int start, int end);

    }
}