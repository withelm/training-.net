using System;

namespace strings
{
    class Program
    {
        enum CaseType
        {
            Loud,
            Quiet,
        };

        static void Main(string[] args)
        {
            Console.WriteLine(Welcome("Hello", "Withelm", CaseType.Loud));
        }

        private static string Welcome(string gretting, string name, CaseType caseType)
        {
            var welcom = $"{gretting} {name}!";
            switch (caseType)
            {
                case CaseType.Loud:
                    return welcom.ToUpper();
                case CaseType.Quiet:
                    return welcom.ToLower();
                default:
                    return welcom;
            }
        }
    }
}
