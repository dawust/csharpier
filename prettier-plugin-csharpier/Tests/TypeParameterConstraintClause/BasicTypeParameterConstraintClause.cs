delegate void Delegate<T>()
    where T : struct;

class ClassName<T>
    where T : class
{
    void MethodName<T>()
        where T : class
    {
        void LocalFunction<T>()
            where T : class
        {
            return;
        }
    }
}

interface InterfaceName<T>
    where T : class
{ }

struct Struct<T>
    where T : class
{ }