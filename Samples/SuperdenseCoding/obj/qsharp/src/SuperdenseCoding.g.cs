#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Samples.SuperdenseEx", "SuperdenseCodingProtocolRun (bitsAsInt : Int[]) : (Bool, Bool)", new string[] { }, "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs", 1813L, 40L, 4L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.SuperdenseEx", "CreateEPRPair (qubit1 : Qubit, qubit2 : Qubit) : ()", new string[] { }, "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs", 3570L, 89L, 2L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.SuperdenseEx", "SuperdenseEncode (bit1 : Bool, bit2 : Bool, qubit : Qubit) : ()", new string[] { }, "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs", 4533L, 116L, 2L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.SuperdenseEx", "SuperdenseDecode (qubit1 : Qubit, qubit2 : Qubit) : (Bool, Bool)", new string[] { }, "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs", 4824L, 126L, 2L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Samples.SuperdenseEx", "SuperdenseCodingTest (lbit1 : Int, lbit2 : Int) : (Bool, Bool)", new string[] { }, "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs", 5542L, 144L, 2L)]
#line hidden
namespace Microsoft.Quantum.Samples.SuperdenseEx
{
    public class SuperdenseCodingProtocolRun : Operation<QArray<Int64>, (Boolean,Boolean)>
    {
        public SuperdenseCodingProtocolRun(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Canon.AssertBoolEqual), typeof(Microsoft.Quantum.Canon.AssertIntEqual), typeof(Microsoft.Quantum.Samples.SuperdenseEx.CreateEPRPair), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseDecode), typeof(Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseEncode) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get
            {
                return this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>, Microsoft.Quantum.Canon.AssertBoolEqual>();
            }
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get
            {
                return this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>, Microsoft.Quantum.Canon.AssertIntEqual>();
            }
        }

        protected ICallable<(Qubit,Qubit), QVoid> CreateEPRPair
        {
            get
            {
                return this.Factory.Get<ICallable<(Qubit,Qubit), QVoid>, Microsoft.Quantum.Samples.SuperdenseEx.CreateEPRPair>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QVoid>, Microsoft.Quantum.Primitive.ResetAll>();
            }
        }

        protected ICallable<(Qubit,Qubit), (Boolean,Boolean)> SuperdenseDecode
        {
            get
            {
                return this.Factory.Get<ICallable<(Qubit,Qubit), (Boolean,Boolean)>, Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseDecode>();
            }
        }

        protected ICallable<(Boolean,Boolean,Qubit), QVoid> SuperdenseEncode
        {
            get
            {
                return this.Factory.Get<ICallable<(Boolean,Boolean,Qubit), QVoid>, Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseEncode>();
            }
        }

        public override Func<QArray<Int64>, (Boolean,Boolean)> Body
        {
            get => (bitsAsInt) =>
            {
#line hidden
                this.Factory.StartOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseCodingProtocolRun", OperationFunctor.Body, bitsAsInt);
                var __result__ = default((Boolean,Boolean));
                try
                {
#line 42 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    MicrosoftQuantumCanonAssertIntEqual.Apply((2L, bitsAsInt.Count, "Array bitsAsInt must have length 2"));
                    // Get the bits we are going to transmit.
#line 45 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var (bit1,bit2) = ((bitsAsInt[0L] == 0L), (bitsAsInt[1L] == 0L));
#line 46 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var bit1sent = false;
#line 47 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var bit2sent = false;
                    // Get a temporary register for the protocol run.
#line 49 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var qubits = Allocate.Apply(2L);
                    // introduce convenient names for the qubits
#line 51 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var (qubit1,qubit2) = (qubits[0L], qubits[1L]);
                    // Create an EPR pair shared between A and B.
#line 54 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    CreateEPRPair.Apply((qubit1, qubit2));
                    // A encodes 2 bits in the first qubit.
#line 57 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    SuperdenseEncode.Apply((bit1, bit2, qubit1));
                    // "Send" qubit to B and let B decode two bits.
#line 60 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var (decodedBit1,decodedBit2) = SuperdenseDecode.Apply<(Boolean,Boolean)>((qubit1, qubit2));
                    // Now test if the bits were transfered correctly.
#line 65 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    if ((bit1 == decodedBit1))
                    {
#line 65 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                        bit1sent = true;
                    }

#line 66 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    MicrosoftQuantumCanonAssertBoolEqual.Apply((bit1, decodedBit1, "bit1 should be transfered correctly"));
#line 69 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    if ((bit2 == decodedBit2))
                    {
#line 69 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                        bit2sent = true;
                    }

#line 70 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    MicrosoftQuantumCanonAssertBoolEqual.Apply((bit2, decodedBit2, "bit2 should be transfered correctly"));
                    // Make sure that we return qubits back in 0 state.
#line 76 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    ResetAll.Apply(qubits);
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = (bit1sent, bit2sent);
#line 78 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseCodingProtocolRun", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<(Boolean,Boolean)> Run(IOperationFactory __m__, QArray<Int64> bitsAsInt)
        {
            return __m__.Run<SuperdenseCodingProtocolRun, QArray<Int64>, (Boolean,Boolean)>(bitsAsInt);
        }
    }

    public class CreateEPRPair : Operation<(Qubit,Qubit), QVoid>
    {
        public CreateEPRPair(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Assert), typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>,Result,String), QVoid> Assert
        {
            get
            {
                return this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>,Result,String), QVoid>, Microsoft.Quantum.Primitive.Assert>();
            }
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        public override Func<(Qubit,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Microsoft.Quantum.Samples.SuperdenseEx.CreateEPRPair", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (qubit1,qubit2) = _args;
                    // Check that the inputs are as expected.
#line 92 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    Assert.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubit1}, Result.Zero, "First qubit is expected to be in a zero state"));
#line 94 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    Assert.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubit2}, Result.Zero, "Second qubit is expected to be in a zero state"));
                    // Make an EPR pair.
#line 98 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubit1);
#line 99 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubit1, qubit2));
                    // Check that we indeed prepared one.
#line 102 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    Assert.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ, Pauli.PauliZ}, new QArray<Qubit>()
                    {qubit1, qubit2}, Result.Zero, "EPR state must be +1 eigenstate of ZZ"));
#line 106 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    Assert.Apply((new QArray<Pauli>()
                    {Pauli.PauliX, Pauli.PauliX}, new QArray<Qubit>()
                    {qubit1, qubit2}, Result.Zero, "EPR state must be +1 eigenstate of XX"));
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Microsoft.Quantum.Samples.SuperdenseEx.CreateEPRPair", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit1, Qubit qubit2)
        {
            return __m__.Run<CreateEPRPair, (Qubit,Qubit), QVoid>((qubit1, qubit2));
        }
    }

    public class SuperdenseEncode : Operation<(Boolean,Boolean,Qubit), QVoid>
    {
        public SuperdenseEncode(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.X), typeof(Microsoft.Quantum.Primitive.Z) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.Z>();
            }
        }

        public override Func<(Boolean,Boolean,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseEncode", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (bit1,bit2,qubit) = _args;
#line 118 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    if (bit1)
                    {
#line 118 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                        MicrosoftQuantumPrimitiveZ.Apply(qubit);
                    }

#line 119 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    if (bit2)
                    {
#line 119 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qubit);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseEncode", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Boolean bit1, Boolean bit2, Qubit qubit)
        {
            return __m__.Run<SuperdenseEncode, (Boolean,Boolean,Qubit), QVoid>((bit1, bit2, qubit));
        }
    }

    public class SuperdenseDecode : Operation<(Qubit,Qubit), (Boolean,Boolean)>
    {
        public SuperdenseDecode(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Measure) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get
            {
                return this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>, Microsoft.Quantum.Primitive.Measure>();
            }
        }

        public override Func<(Qubit,Qubit), (Boolean,Boolean)> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseDecode", OperationFunctor.Body, _args);
                var __result__ = default((Boolean,Boolean));
                try
                {
                    var (qubit1,qubit2) = _args;
                    // If bit1 in the encoding procedure was true we applied Z to
                    // the first qubit which anti-commutes with XX, therefore bit1 
                    // can be read out from XX measurement.
#line 132 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var bit1 = (Measure.Apply<Result>((new QArray<Pauli>()
                    {Pauli.PauliX, Pauli.PauliX}, new QArray<Qubit>()
                    {qubit1, qubit2})) == Result.One);
                    // If bit2 in the encoding procedure was true we applied X to
                    // the first qubit which anti-commutes with ZZ, therefore bit2 
                    // can be read out from ZZ measurement.
#line 137 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var bit2 = (Measure.Apply<Result>((new QArray<Pauli>()
                    {Pauli.PauliZ, Pauli.PauliZ}, new QArray<Qubit>()
                    {qubit1, qubit2})) == Result.One);
#line hidden
                    __result__ = (bit1, bit2);
#line 139 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseDecode", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<(Boolean,Boolean)> Run(IOperationFactory __m__, Qubit qubit1, Qubit qubit2)
        {
            return __m__.Run<SuperdenseDecode, (Qubit,Qubit), (Boolean,Boolean)>((qubit1, qubit2));
        }
    }

    public class SuperdenseCodingTest : Operation<(Int64,Int64), (Boolean,Boolean)>
    {
        public SuperdenseCodingTest(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseCodingProtocolRun) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<QArray<Int64>, (Boolean,Boolean)> SuperdenseCodingProtocolRun
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Int64>, (Boolean,Boolean)>, Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseCodingProtocolRun>();
            }
        }

        public override Func<(Int64,Int64), (Boolean,Boolean)> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseCodingTest", OperationFunctor.Body, _args);
                var __result__ = default((Boolean,Boolean));
                try
                {
                    var (lbit1,lbit2) = _args;
                    // Calls SuperdenseCodingProtocolRun 1 time with 
                    // arguments [a;b]coming from the driver where a tuple of integers (a,b) belongs to 
                    // the Cartesian square {0,1}².
                    //IterateThroughCartesianPower(lbit1,lbit2, SuperdenseCodingProtocolRun );
#line 154 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var bitstosend = new QArray<Int64>(2L);
#line 155 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    bitstosend[0L] = lbit1;
#line 156 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    bitstosend[1L] = lbit2;
#line 158 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    var (b1,b2) = SuperdenseCodingProtocolRun.Apply<(Boolean,Boolean)>(bitstosend);
#line hidden
                    __result__ = (b1, b2);
#line 159 "C:\\Users\\r_cap\\Source\\Repos\\Quantum-1\\Samples\\SuperdenseCoding\\SuperdenseCoding.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Microsoft.Quantum.Samples.SuperdenseEx.SuperdenseCodingTest", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<(Boolean,Boolean)> Run(IOperationFactory __m__, Int64 lbit1, Int64 lbit2)
        {
            return __m__.Run<SuperdenseCodingTest, (Int64,Int64), (Boolean,Boolean)>((lbit1, lbit2));
        }
    }
}