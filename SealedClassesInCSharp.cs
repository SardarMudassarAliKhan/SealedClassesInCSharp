namespace SealedClassesInCSharp
{
    //Implementing sealed class
    sealed class SealedClass
    {
        public int x;
        public int y;

        public SealedClass()
        {
            x = 100;
            y = 200;
        }

        public int Add()
        {
            return x + y;
        }

        //subtract
        public int Sub()
        {
            return x - y;
        }

        //Multiply
        public int Mul()
        {
            return x * y;
        }

        //Divide
        public int Div()
        {
            return x / y;
        }
    }

}

