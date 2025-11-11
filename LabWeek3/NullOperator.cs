using System;

namespace LabWeek3
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            // Declare a string variable and assign null
            string username= null;

            // 1. Null check using Ternary Operator
            string messageTernary = (username == null) ? "Username is not available" : username;
            Console.WriteLine("Ternary Operator: " + messageTernary);

            // 2. Null check using Null-Coalescing Operator (??)
            string messageNullCoalescing = username ?? "Username is not available";
            Console.WriteLine("Null-Coalescing Operator: " + messageNullCoalescing);

            // 3. Null-Coalescing Assignment Operator (??=)
            username ??= "DefaultUser";
            Console.WriteLine("After Null-Coalescing Assignment: " + username);
        }
    }
}