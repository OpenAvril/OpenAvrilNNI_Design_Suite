
using System;

namespace Avril_NNAI
{
    public class Node
    {
        ulong _numberOfInputs;
        ulong[] _VALUEofInput;
        Object[] _NeuralPathOfInput_SubSet;
        ulong _VALUEofOutput;

        public Node()
        {
            Set_NumberOfInputs(0);
            Create_Array_VALUEofInput(new ulong[1]);
            Create_Array_NeuralPathOfInput_SubSet(new Object[1]);
            Set_VALUEofOutput(0);
        }

        public Object[] Get_NeuralPathOfInput_SubSet()
        {
            return _NeuralPathOfInput_SubSet;
        }

        public ulong Get_NumberOfInputs()
        {
            return _numberOfInputs;
        }
        public ulong[] Get_VALUEofInput()
        {
            return _VALUEofInput;
        }

        public ulong Get_VALUEofOutput()
        {
            return _VALUEofOutput;
        }

        private void Create_Array_NeuralPathOfInput_SubSet(Object[] NeuralPathOfInput_SubSet)
        {
            _NeuralPathOfInput_SubSet = NeuralPathOfInput_SubSet;
        }

        private void Create_Array_VALUEofInput(ulong[] VALUEofInput)
        {
            _VALUEofInput = VALUEofInput;
        }

        public void Set_NumberOfInputs(Avril_NNAI.Framework_NNAI obj, ulong numberOfInputs)
        {
            _numberOfInputs = numberOfInputs;
            Create_Array_VALUEofInput(new ulong[_numberOfInputs]);
            Create_Array_NeuralPathOfInput_SubSet(new Object[_numberOfInputs]);
        }
        private void Set_NumberOfInputs(ulong numberOfInputs)
        {
            _numberOfInputs = numberOfInputs;
            Create_Array_VALUEofInput(new ulong[_numberOfInputs]);
            Create_Array_NeuralPathOfInput_SubSet(new Object[_numberOfInputs]);
        }
        private void Set_VALUEofOutput(ulong VALUEofOutput)
        {
            _VALUEofOutput = VALUEofOutput;
        }
    }
}
